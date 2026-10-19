using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlVentas : UserControl
    {
        private readonly ClientesDAO _clientesDao = new ClientesDAO();
        private readonly NotebookDAO _notebookDao = new NotebookDAO();

        // Snapshot inmutable del cliente seleccionado
        private Cliente clienteSnapshot = null;
        private List<ElementoCarrito> carritoVenta = new List<ElementoCarrito>();

        public ControlVentas()
        {
            InitializeComponent();
            ConfigurarGrillaCatalogo();
            ConfigurarGrillaCarrito();
            CargarCatalogoNotebooks();

            // 🟢 SOLUCIÓN CLAVE: Suscripción explícita al evento CellClick del carrito
            this.dgvCarrito.CellClick -= dgvCarrito_CellClick;
            this.dgvCarrito.CellClick += dgvCarrito_CellClick;
        }

        // ==========================================
        // 1. SELECCIÓN Y BÚSQUEDA DE CLIENTE (SNAPSHOT)
        // ==========================================
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string dniIngresado = txtDniCliente.Text.Trim();

            if (string.IsNullOrEmpty(dniIngresado))
            {
                KryptonMessageBox.Show("Ingrese un número de DNI para realizar la búsqueda.", "Atención",
                                       KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            Cliente clienteBD = _clientesDao.ObtenerPorDNI(dniIngresado);

            // Cláusula de guarda: Verificación de existencia y estado activo
            if (clienteBD != null && !clienteBD.Eliminado)
            {
                // Generación de Snapshot Inmutable
                clienteSnapshot = new Cliente(
                    clienteBD.IdCliente,
                    clienteBD.Dni,
                    clienteBD.NombreCompleto,
                    clienteBD.Correo,
                    clienteBD.Telefono,
                    clienteBD.Direccion,
                    clienteBD.Iva,
                    clienteBD.Eliminado
                );

                lblClienteNombre.Text = clienteSnapshot.NombreCompleto;
                lblClienteDni.Text = $"DNI: {clienteSnapshot.Dni} ({clienteSnapshot.Iva})";
                btnRedirigirCrudCliente.Visible = false;
            }
            else
            {
                clienteSnapshot = null;
                lblClienteNombre.Text = "⚠️ Cliente No Registrado o Inactivo";
                lblClienteDni.Text = $"No existe cliente activo con DNI {dniIngresado}";
                btnRedirigirCrudCliente.Visible = true;
            }
        }

        private void btnRedirigirCrudCliente_Click(object sender, EventArgs e)
        {
            Form formPadre = this.FindForm();
            if (formPadre is FormVendedorPrincipal formVendedor)
            {
                ControlClientes vistaClientes = new ControlClientes(txtDniCliente.Text.Trim());
                formVendedor.CargarVistaConTransicion(vistaClientes);
            }
        }

        // ==========================================
        // 2. BÚSQUEDA DE LAPTOPS Y MODAL QUICK VIEW
        // ==========================================
        private void txtBuscarNotebook_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscarNotebook.Text.Trim();
            CargarCatalogoNotebooks(filtro);
        }

        private void CargarCatalogoNotebooks(string filtro = "")
        {
            List<Notebook> lista = _notebookDao.ObtenerCatalogo(filtro);
            dgvCatalogo.Rows.Clear();

            foreach (var note in lista)
            {
                int rowIndex = dgvCatalogo.Rows.Add();
                DataGridViewRow fila = dgvCatalogo.Rows[rowIndex];

                fila.Cells["colId"].Value = note.IdNotebook;
                fila.Cells["colMarca"].Value = note.Marca;
                fila.Cells["colModelo"].Value = note.Modelo;
                fila.Cells["colPrecio"].Value = $"${note.Precio:N0}";

                if (note.Stock <= 0)
                {
                    fila.Cells["colStock"].Value = "Sin Stock";
                    fila.DefaultCellStyle.ForeColor = Color.Gray;
                }
                else
                {
                    fila.Cells["colStock"].Value = note.Stock.ToString();
                }

                fila.Tag = note;
            }
        }

        private void dgvCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCatalogo.Columns["colVerDetalles"].Index && e.RowIndex >= 0)
            {
                if (dgvCatalogo.Rows[e.RowIndex].Tag is Notebook noteSeleccionada)
                {
                    using (FormDetalleNotebook modal = new FormDetalleNotebook(noteSeleccionada))
                    {
                        if (modal.ShowDialog() == DialogResult.OK)
                        {
                            AgregarAlCarrito(modal.LaptopSeleccionada, modal.CantidadSeleccionada);
                        }
                    }
                }
            }
        }

        // ==========================================
        // 3. GESTIÓN DE CARRITO, DEDUPLICACIÓN Y PRECIO CONGELADO
        // ==========================================
        private void AgregarAlCarrito(Notebook notebook, int cantidad)
        {
            // Consolidación por Clave Primaria (IdNotebook)
            var itemExistente = carritoVenta.FirstOrDefault(x => x.Laptop.IdNotebook == notebook.IdNotebook);

            if (itemExistente != null)
            {
                int cantidadTotalDeseada = itemExistente.Cantidad + cantidad;

                if (cantidadTotalDeseada > notebook.Stock)
                {
                    KryptonMessageBox.Show($"Supera el stock disponible ({notebook.Stock} unidades). Ya tiene {itemExistente.Cantidad} en el carrito.",
                                           "Stock Insuficiente", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    return;
                }
                itemExistente.Cantidad = cantidadTotalDeseada;
            }
            else
            {
                // Se instancian utilizando ElementoCarrito de LaptopDeel.Entidades (congela el precio)
                carritoVenta.Add(new ElementoCarrito(notebook, cantidad));
            }

            ActualizarVistaCarrito();
        }

        private void ActualizarVistaCarrito()
        {
            dgvCarrito.Rows.Clear();
            decimal subtotalGeneral = 0;

            foreach (var item in carritoVenta)
            {
                dgvCarrito.Rows.Add(item.Laptop.Marca, item.Laptop.Modelo, item.Cantidad, $"${item.PrecioUnitarioCongelado:N0}");
                subtotalGeneral += item.SubtotalItem;
            }

            lblSubtotalEstimado.Text = $"${subtotalGeneral:N0}";
        }

        // 🟢 EVENTO DE ELIMINACIÓN DE ÍTEMS CORREGIDO
        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitar clics en los encabezados
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Validación por el nombre explícito de la columna
            if (dgvCarrito.Columns[e.ColumnIndex].Name == "colCarEliminar")
            {
                if (e.RowIndex < carritoVenta.Count)
                {
                    carritoVenta.RemoveAt(e.RowIndex);
                    ActualizarVistaCarrito();
                }
            }
        }

        // ==========================================
        // 4. PRE-COMMIT CHECK Y TRANSMISIÓN VÍA DTO
        // ==========================================
        private void btnPasarAFacturacion_Click(object sender, EventArgs e)
        {
            // Cláusula de Guarda 1: Cliente Seleccionado
            if (clienteSnapshot == null)
            {
                KryptonMessageBox.Show("Debe seleccionar un cliente activo antes de continuar a facturación.", "Atención",
                                       KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            // Cláusula de Guarda 2: Carrito no vacío
            if (carritoVenta.Count == 0)
            {
                KryptonMessageBox.Show("El carrito de compras está vacío. Seleccione al menos una notebook.", "Atención",
                                       KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            // Pre-Commit Stock Check: Re-verificación en tiempo real contra MariaDB
            foreach (var item in carritoVenta)
            {
                int stockRealBD = _notebookDao.ObtenerStockActual(item.Laptop.IdNotebook);

                if (stockRealBD < item.Cantidad)
                {
                    KryptonMessageBox.Show($"El stock disponible para '{item.Laptop.Marca} {item.Laptop.Modelo}' ha cambiado. Stock actual en BD: {stockRealBD}.",
                                           "Conflicto de Stock", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                    CargarCatalogoNotebooks(); // Refresca catálogo visual
                    return;
                }
            }

            // Embalaje de datos inmutables en PedidoVentaDTO
            decimal totalCalculado = carritoVenta.Sum(x => x.SubtotalItem);
            PedidoVentaDTO pedidoDraft = new PedidoVentaDTO(clienteSnapshot, carritoVenta, totalCalculado);

            // Transmisión al módulo de Facturación
            FormFacturacion formFacturacion = new FormFacturacion(pedidoDraft);
            formFacturacion.ShowDialog();
        }

        private void ConfigurarGrillaCatalogo()
        {
            dgvCatalogo.Columns.Clear();
            dgvCatalogo.Columns.Add("colId", "ID");
            dgvCatalogo.Columns["colId"].Visible = false;
            dgvCatalogo.Columns.Add("colMarca", "Marca");
            dgvCatalogo.Columns.Add("colModelo", "Modelo");
            dgvCatalogo.Columns.Add("colStock", "Stock");
            dgvCatalogo.Columns.Add("colPrecio", "Precio ($)");

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn
            {
                Name = "colVerDetalles",
                HeaderText = "Características",
                Text = "🔍 Ver Detalles",
                UseColumnTextForButtonValue = true
            };
            dgvCatalogo.Columns.Add(btnCol);
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCatalogo.ReadOnly = true;
            dgvCatalogo.AllowUserToAddRows = false;
            dgvCatalogo.AllowUserToDeleteRows = false;
            dgvCatalogo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatalogo.MultiSelect = false;
        }

        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add("colCarMarca", "Marca");
            dgvCarrito.Columns.Add("colCarModelo", "Modelo");
            dgvCarrito.Columns.Add("colCarCant", "Cant.");
            dgvCarrito.Columns.Add("colCarPrecio", "Precio Un.");

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "colCarEliminar",
                HeaderText = "",
                Text = "❌",
                UseColumnTextForButtonValue = true
            };
            dgvCarrito.Columns.Add(btnEliminar);

            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.Columns["colCarEliminar"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvCarrito.Columns["colCarEliminar"].Width = 35;

            dgvCarrito.ReadOnly = true;
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.MultiSelect = false;
        }
    }
}