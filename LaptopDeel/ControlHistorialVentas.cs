using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;
using LaptopDeel.Servicios;

namespace LaptopDeel
{
    public partial class ControlHistorialVentas : UserControl
    {
        private readonly VentasDAO _ventasDao = new VentasDAO();
        private readonly UsuarioDAO _usuarioDao = new UsuarioDAO();
        private readonly ClientesDAO _clientesDao = new ClientesDAO();
        private readonly Usuario _usuarioActual;

        private List<VentaHistorialDTO> _listaCache = new List<VentaHistorialDTO>();

        public ControlHistorialVentas() : this(new Usuario())
        {
        }

        public ControlHistorialVentas(Usuario usuarioLogueado)
        {
            _usuarioActual = usuarioLogueado ?? new Usuario();
            InitializeComponent();

            ConfigurarSegunRol();
            ConfigurarGrilla();
            CargarHistorial();
        }

        private void ConfigurarSegunRol()
        {
            bool esGerenteOAdmin = _usuarioActual.IdRol == 1 || _usuarioActual.IdRol == 3 ||
                (_usuarioActual.RolUsuario != null &&
                (_usuarioActual.RolUsuario.RolName.ToLower().Contains("gerente") ||
                 _usuarioActual.RolUsuario.RolName.ToLower().Contains("admin")));

            lblVendedor.Visible = esGerenteOAdmin;
            cmbVendedor.Visible = esGerenteOAdmin;

            if (esGerenteOAdmin)
            {
                cmbVendedor.Items.Clear();
                cmbVendedor.Items.Add(new KeyValuePair<int?, string>(null, "Todos los Vendedores"));

                try
                {
                    var listaUsuarios = _usuarioDao.ObtenerTodos();
                    foreach (var usr in listaUsuarios.Where(u => !u.Eliminado))
                    {
                        cmbVendedor.Items.Add(new KeyValuePair<int?, string>(usr.IdUsuario, $"{usr.Nombre} {usr.Apellido}"));
                    }
                }
                catch
                {
                    // Manejo preventivo
                }

                cmbVendedor.DisplayMember = "Value";
                cmbVendedor.ValueMember = "Key";
                cmbVendedor.SelectedIndex = 0;
            }
        }

        private void ConfigurarGrilla()
        {
            dgvHistorial.Columns.Clear();

            var colId = new DataGridViewTextBoxColumn
            {
                Name = "colIdVenta",
                HeaderText = "ID",
                Visible = false
            };
            dgvHistorial.Columns.Add(colId);

            dgvHistorial.Columns.Add("colFecha", "Fecha / Hora");
            dgvHistorial.Columns.Add("colFactura", "N° Factura");
            dgvHistorial.Columns.Add("colCliente", "Cliente");
            dgvHistorial.Columns.Add("colVendedor", "Vendedor");
            dgvHistorial.Columns.Add("colMedioPago", "Medio de Pago");
            dgvHistorial.Columns.Add("colTotal", "Total ($)");

            var colPdf = new DataGridViewButtonColumn
            {
                Name = "colVerPdf",
                HeaderText = "Acción",
                Text = "📄 Ver PDF",
                UseColumnTextForButtonValue = true
            };
            dgvHistorial.Columns.Add(colPdf);

            dgvHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorial.MultiSelect = false;
            dgvHistorial.ReadOnly = true;
        }

        private void CargarHistorial()
        {
            try
            {
                int? idVendedorFiltro = null;

                // Si el usuario es rol Vendedor (no Admin/Gerente), filtra por su propio ID
                if (_usuarioActual.IdRol == 2)
                {
                    idVendedorFiltro = _usuarioActual.IdUsuario;
                }

                _listaCache = _ventasDao.ObtenerHistorialVentas(idVendedorFiltro);
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error al cargar el historial de ventas: {ex.Message}", "Error de Carga",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void AplicarFiltros()
        {
            if (_listaCache == null) return;

            string filtroTexto = txtBuscar.Text.Trim().ToLower();
            if (filtroTexto == "🔍 buscar...") filtroTexto = string.Empty;

            bool usarFechas = chkUsarFiltroFecha.Checked;
            DateTime fechaDesde = dtpInicio.Value.Date;
            DateTime fechaHasta = dtpFin.Value.Date.AddDays(1).AddTicks(-1);

            int? idVendedorSeleccionado = null;
            if (cmbVendedor.Visible && cmbVendedor.SelectedItem is KeyValuePair<int?, string> pair)
            {
                idVendedorSeleccionado = pair.Key;
            }

            dgvHistorial.Rows.Clear();

            var ventasFiltradas = _listaCache.AsEnumerable();

            if (idVendedorSeleccionado.HasValue)
            {
                ventasFiltradas = ventasFiltradas.Where(v => v.IdUsuario == idVendedorSeleccionado.Value);
            }

            if (usarFechas)
            {
                ventasFiltradas = ventasFiltradas.Where(v => v.FechaHora >= fechaDesde && v.FechaHora <= fechaHasta);
            }

            if (!string.IsNullOrEmpty(filtroTexto))
            {
                ventasFiltradas = ventasFiltradas.Where(v =>
                    (!string.IsNullOrEmpty(v.NombreCliente) && v.NombreCliente.ToLower().Contains(filtroTexto)) ||
                    (!string.IsNullOrEmpty(v.DniCliente) && v.DniCliente.ToLower().Contains(filtroTexto)) ||
                    (!string.IsNullOrEmpty(v.NumeroFactura) && v.NumeroFactura.ToLower().Contains(filtroTexto)));
            }

            foreach (var venta in ventasFiltradas)
            {
                int index = dgvHistorial.Rows.Add();
                DataGridViewRow gridRow = dgvHistorial.Rows[index];

                gridRow.Cells["colIdVenta"].Value = venta.IdVenta;
                gridRow.Cells["colFecha"].Value = venta.FechaHora.ToString("dd/MM/yyyy HH:mm");
                gridRow.Cells["colFactura"].Value = venta.NumeroFactura;
                gridRow.Cells["colCliente"].Value = venta.NombreCliente;
                gridRow.Cells["colVendedor"].Value = venta.NombreVendedor;
                gridRow.Cells["colMedioPago"].Value = venta.MedioPago;
                gridRow.Cells["colTotal"].Value = venta.PrecioTotal.ToString("C2");
            }
        }

        // ==========================================
        // EVENTOS DE LA INTERFAZ
        // ==========================================

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkUsarFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            dtpInicio.Enabled = chkUsarFiltroFecha.Checked;
            dtpFin.Enabled = chkUsarFiltroFecha.Checked;
            AplicarFiltros();
        }

        private void cmbVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void dgvHistorial_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Verificación del botón "Ver PDF"
            if (dgvHistorial.Columns[e.ColumnIndex].Name == "colVerPdf")
            {
                object idVentaObj = dgvHistorial.Rows[e.RowIndex].Cells["colIdVenta"].Value;

                if (idVentaObj != null && int.TryParse(idVentaObj.ToString(), out int idVenta))
                {
                    GenerarYAbrirPdfVenta(idVenta);
                }
            }
        }

        /// <summary>
        /// Reconstruye el pedido desde la base de datos e invoca el generador de PDF.
        /// </summary>
        private void GenerarYAbrirPdfVenta(int idVenta)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // 1. Obtener la venta DTO desde la lista en caché
                var ventaDTO = _listaCache.FirstOrDefault(v => v.IdVenta == idVenta);
                if (ventaDTO == null)
                {
                    KryptonMessageBox.Show("No se encontró la información de la venta seleccionada.", "Error",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                    return;
                }

                // 2. Recuperar el cliente completo por DNI o crear uno temporal
                Cliente cliente = null;
                if (!string.IsNullOrEmpty(ventaDTO.DniCliente))
                {
                    cliente = _clientesDao.ObtenerPorDNI(ventaDTO.DniCliente);
                }

                if (cliente == null)
                {
                    cliente = new Cliente(
                        0,
                        string.IsNullOrEmpty(ventaDTO.DniCliente) ? "00000000" : ventaDTO.DniCliente,
                        string.IsNullOrEmpty(ventaDTO.NombreCliente) ? "Consumidor Final" : ventaDTO.NombreCliente,
                        "", "", "Sin Dirección Registrada", "Consumidor Final", false
                    );
                }

                // 3. Recuperar los ítems del detalle de la venta desde MariaDB
                DataTable dtDetalle = _ventasDao.ObtenerDetalleVentaPorId(idVenta);
                var itemsCarrito = new List<ElementoCarrito>();

                foreach (DataRow row in dtDetalle.Rows)
                {
                    int idNotebook = row.Table.Columns.Contains("id_notebook") && row["id_notebook"] != DBNull.Value ? Convert.ToInt32(row["id_notebook"]) : 0;
                    string marca = row.Table.Columns.Contains("marca") ? row["marca"].ToString() ?? "" : "";
                    string modelo = row.Table.Columns.Contains("modelo") ? row["modelo"].ToString() ?? "" : "";
                    int cantidad = row.Table.Columns.Contains("cantidad") ? Convert.ToInt32(row["cantidad"]) : 1;
                    decimal precioUnitario = row.Table.Columns.Contains("precio_unitario") ? Convert.ToDecimal(row["precio_unitario"]) : 0m;

                    var notebook = new Notebook
                    {
                        IdNotebook = idNotebook,
                        Marca = marca,
                        Modelo = modelo,
                        Precio = precioUnitario
                    };

                    var elemento = new ElementoCarrito(notebook, cantidad)
                    {
                        PrecioUnitarioCongelado = precioUnitario
                    };

                    itemsCarrito.Add(elemento);
                }

                // 4. Crear el DTO de Pedido
                var pedidoDraft = new PedidoVentaDTO(cliente, itemsCarrito, ventaDTO.PrecioTotal);

                // 5. Determinar el Tipo de Comprobante
                string condicionIva = cliente.Iva?.Trim() ?? "Consumidor Final";
                string tipoComprobante = condicionIva.Equals("Responsable Inscripto", StringComparison.OrdinalIgnoreCase)
                    ? "Factura A"
                    : "Factura B";

                string numeroFactura = string.IsNullOrEmpty(ventaDTO.NumeroFactura)
                    ? $"0001-{idVenta:D8}"
                    : ventaDTO.NumeroFactura;

                string medioPago = string.IsNullOrEmpty(ventaDTO.MedioPago) ? "Efectivo" : ventaDTO.MedioPago;

                // 6. Generar el PDF mediante QuestPDF
                string rutaPdf = GeneradorFacturaPDF.GenerarFactura(pedidoDraft, numeroFactura, tipoComprobante, medioPago);

                // 7. Abrir automáticamente en el visor predeterminado de Windows
                if (File.Exists(rutaPdf))
                {
                    Process.Start(new ProcessStartInfo(rutaPdf) { UseShellExecute = true });
                }
                else
                {
                    KryptonMessageBox.Show($"No se pudo ubicar el archivo generado en: {rutaPdf}", "Advertencia",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Ocurrió un error al generar el comprobante PDF:\n{ex.Message}", "Error al Generar PDF",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}