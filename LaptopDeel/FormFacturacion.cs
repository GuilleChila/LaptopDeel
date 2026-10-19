using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;
using LaptopDeel.Servicios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace LaptopDeel
{
    public partial class FormFacturacion : KryptonForm
    {
        private readonly FacturacionDAO _facturacionDao = new FacturacionDAO();

        // Objeto borrador inmutable transmitido desde ControlVentas (POS)
        public PedidoVentaDTO PedidoDraft { get; private set; }

        // ID del usuario operador/vendedor autenticado en el sistema (por defecto 1 o extraído de la sesión)
        private readonly int _idUsuarioOperador = 1;

        // ==========================================
        // CONSTRUCTORES
        // ==========================================
        public FormFacturacion(PedidoVentaDTO pedidoDraft)
        {
            InitializeComponent();
            PedidoDraft = pedidoDraft;

            ConfigurarFormulario();
            CargarDatosCliente();
            DeterminarTipoComprobanteFiscal();
            CargarGrillaDetalle();
            CargarMediosDePago();
            CalcularImpresionTotales();
        }

        // Sobrecarga de compatibilidad en caso de ser invocado con entidad Cliente y Lista tradicional
        public FormFacturacion(Cliente cliente, List<Notebook> carrito)
        {
            InitializeComponent();

            // Construcción directa del DTO interno
            List<ElementoCarrito> items = new List<ElementoCarrito>();
            decimal total = 0;

            foreach (var note in carrito)
            {
                var item = new ElementoCarrito(note, 1);
                items.Add(item);
                total += item.SubtotalItem;
            }

            PedidoDraft = new PedidoVentaDTO(cliente, items, total);

            ConfigurarFormulario();
            CargarDatosCliente();
            DeterminarTipoComprobanteFiscal();
            CargarGrillaDetalle();
            CargarMediosDePago();
            CalcularImpresionTotales();
        }

        // ==========================================
        // CONFIGURACIÓN E INICIALIZACIÓN
        // ==========================================
        private void ConfigurarFormulario()
        {
            this.Text = "LaptopDeel - Módulo de Facturación y Cobro";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void CargarDatosCliente()
        {
            if (PedidoDraft?.ClienteAsociado != null)
            {
                lblClienteNombre.Text = $"Cliente: {PedidoDraft.ClienteAsociado.NombreCompleto}";
                lblClienteDni.Text = $"DNI / CUIT: {PedidoDraft.ClienteAsociado.Dni}";
                lblClienteIva.Text = $"Condición IVA: {PedidoDraft.ClienteAsociado.Iva}";
            }
            else
            {
                lblClienteNombre.Text = "Cliente: --";
                lblClienteDni.Text = "DNI / CUIT: --";
                lblClienteIva.Text = "Condición IVA: --";
            }
        }

        // Determina el comprobante fiscal en base a las normativas comerciales de la AFIP
        private void DeterminarTipoComprobanteFiscal()
        {
            cmbTipoFactura.Items.Clear();

            string condicionIva = PedidoDraft?.ClienteAsociado?.Iva?.Trim() ?? "Consumidor Final";

            if (condicionIva.Equals("Responsable Inscripto", StringComparison.OrdinalIgnoreCase))
            {
                cmbTipoFactura.Items.Add("Factura A");
                cmbTipoFactura.SelectedIndex = 0;
            }
            else
            {
                cmbTipoFactura.Items.Add("Factura B");
                cmbTipoFactura.Items.Add("Factura C");
                cmbTipoFactura.SelectedIndex = 0;
            }
        }

        private void CargarGrillaDetalle()
        {
            dgvDetalleFactura.Columns.Clear();
            dgvDetalleFactura.Columns.Add("colMarca", "Marca");
            dgvDetalleFactura.Columns.Add("colModelo", "Modelo");
            dgvDetalleFactura.Columns.Add("colCant", "Cant.");
            dgvDetalleFactura.Columns.Add("colPrecioUnit", "Precio Un.");
            dgvDetalleFactura.Columns.Add("colSubtotal", "Subtotal");

            dgvDetalleFactura.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalleFactura.ReadOnly = true;
            dgvDetalleFactura.AllowUserToAddRows = false;
            dgvDetalleFactura.AllowUserToDeleteRows = false;
            dgvDetalleFactura.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvDetalleFactura.Rows.Clear();

            if (PedidoDraft?.ItemsCarrito != null)
            {
                foreach (var item in PedidoDraft.ItemsCarrito)
                {
                    dgvDetalleFactura.Rows.Add(
                        item.Laptop.Marca,
                        item.Laptop.Modelo,
                        item.Cantidad,
                        $"${item.PrecioUnitarioCongelado:N0}",
                        $"${item.SubtotalItem:N0}"
                    );
                }
            }
        }

        private void CargarMediosDePago()
        {
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta de Débito");
            cmbMetodoPago.Items.Add("Tarjeta de Crédito");
            cmbMetodoPago.Items.Add("Transferencia Bancaria");
            cmbMetodoPago.SelectedIndex = 0;
        }

        // ==========================================
        // CÁLCULOS IMPOSITIVOS Y REDONDEO FINANCIERO
        // ==========================================
        private void CalcularImpresionTotales()
        {
            decimal totalGeneral = PedidoDraft?.TotalVenta ?? 0;

            // Uso estricto del tipo decimal y Math.Round a 2 decimales
            decimal subtotalNeto = Math.Round(totalGeneral / 1.21m, 2);
            decimal montoIva = Math.Round(totalGeneral - subtotalNeto, 2);

            lblSubtotalNeto.Text = $"Subtotal Neto: ${subtotalNeto:N2}";
            lblIva21.Text = $"IVA (21%): ${montoIva:N2}";
            lblExento.Text = $"Libre Impuesto: $0.00";
            lblTotalPagar.Text = $"TOTAL: ${totalGeneral:N0}";
        }

        // ==========================================
        // EVENTOS DE LA INTERFAZ Y PROCESAMIENTO
        // ==========================================
        private void cmbTipoFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularImpresionTotales();
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medioSeleccionado = cmbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";
            bool esEfectivo = medioSeleccionado.Equals("Efectivo", StringComparison.OrdinalIgnoreCase);

            txtMontoAbonado.Enabled = esEfectivo;

            if (!esEfectivo)
            {
                txtMontoAbonado.Text = PedidoDraft.TotalVenta.ToString("N0");
                lblVuelto.Text = "Vuelto: $0.00";
                lblVuelto.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            }
            else
            {
                txtMontoAbonado.Text = string.Empty;
                lblVuelto.Text = "Vuelto: $0.00";
                lblVuelto.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            }
        }

        private void txtMontoAbonado_TextChanged(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedItem?.ToString() != "Efectivo") return;

            string textoIngresado = txtMontoAbonado.Text.Trim();

            if (decimal.TryParse(textoIngresado, out decimal montoAbonado))
            {
                decimal vuelto = montoAbonado - PedidoDraft.TotalVenta;

                if (vuelto >= 0)
                {
                    lblVuelto.Text = $"Vuelto: ${vuelto:N2}";
                    lblVuelto.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129); // Verde
                }
                else
                {
                    lblVuelto.Text = $"Faltan: ${Math.Abs(vuelto):N2}";
                    lblVuelto.StateCommon.ShortText.Color1 = Color.FromArgb(239, 68, 68); // Rojo
                }
            }
            else
            {
                lblVuelto.Text = "Vuelto: $0.00";
                lblVuelto.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            }
        }

        // ==========================================
        // PROCESAMIENTO ATÓMICO (ACID + IDEMPOTENCIA)
        // ==========================================
        private void btnConfirmarFactura_Click(object sender, EventArgs e)
        {
            btnConfirmarFactura.Enabled = false;
            btnCancelar.Enabled = false;
            Cursor = Cursors.WaitCursor;

            try
            {
                string metodoPago = cmbMetodoPago.SelectedItem?.ToString() ?? "Efectivo";
                string tipoComprobante = cmbTipoFactura.SelectedItem?.ToString() ?? "Factura B";

                // Validar pago en efectivo
                if (metodoPago == "Efectivo")
                {
                    if (!decimal.TryParse(txtMontoAbonado.Text.Trim(), out decimal abonado) || abonado < PedidoDraft.TotalVenta)
                    {
                        KryptonMessageBox.Show("El monto ingresado en efectivo es insuficiente para cubrir la venta.",
                                               "Pago Incompleto", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                        RestablecerControlesControles();
                        return;
                    }
                }

                // 2. Persistencia atómica en MariaDB
                bool exito = _facturacionDao.ProcesarFacturaYVenta(
                    PedidoDraft,
                    tipoComprobante,
                    metodoPago,
                    _idUsuarioOperador,
                    out string numFacturaGenerada,
                    out string mensajeError
                );

                if (exito)
                {
                    string rutaPdfGenerado = string.Empty;

                    // 3. Generación automática de la Factura en PDF
                    try
                    {
                        rutaPdfGenerado = GeneradorFacturaPDF.GenerarFactura(PedidoDraft, numFacturaGenerada, tipoComprobante, metodoPago);
                    }
                    catch (Exception exPdf)
                    {
                        KryptonMessageBox.Show($"La venta se guardó en la BD pero ocurrió un error al generar el PDF:\n{exPdf.Message}",
                                               "Advertencia PDF", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    }

                    // 4. Notificación al usuario
                    string mensajeÉxito = $"¡Venta y Facturación procesadas con éxito!\n\n" +
                                         $"Comprobante Emitido: {tipoComprobante}\n" +
                                         $"Número de Factura: {numFacturaGenerada}\n" +
                                         $"Monto Total: ${PedidoDraft.TotalVenta:N0}\n";

                    if (!string.IsNullOrEmpty(rutaPdfGenerado))
                    {
                        mensajeÉxito += $"\n📄 El PDF se guardó en:\n{rutaPdfGenerado}";
                    }

                    KryptonMessageBox.Show(mensajeÉxito, "Operación Exitosa", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                    // 5. Abrir automáticamente el PDF en el visor por defecto de Windows
                    if (!string.IsNullOrEmpty(rutaPdfGenerado) && System.IO.File.Exists(rutaPdfGenerado))
                    {
                        try
                        {
                            Process.Start(new ProcessStartInfo(rutaPdfGenerado) { UseShellExecute = true });
                        }
                        catch (Exception)
                        {
                            // Ignorar si no hay un visor predeterminado configurado
                        }
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    KryptonMessageBox.Show($"Ocurrió un error al emitir la factura:\n{mensajeError}",
                                           "Error de Transacción", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                    RestablecerControlesControles();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error inesperado durante el procesamiento:\n{ex.Message}",
                                       "Error Crítico", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                RestablecerControlesControles();
            }
        }

        private void RestablecerControlesControles()
        {
            btnConfirmarFactura.Enabled = true;
            btnCancelar.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}