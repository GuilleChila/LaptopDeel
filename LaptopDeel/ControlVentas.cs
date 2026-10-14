using System;
using System.Collections.Generic;
using System.Drawing;
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

        private Cliente clienteActual = null;
        private List<Notebook> carritoVenta = new List<Notebook>();

        public ControlVentas()
        {
            InitializeComponent();
            ConfigurarGrillaCatalogo();
            ConfigurarGrillaCarrito();
            CargarCatalogoNotebooks();
        }

        // ==========================================
        // 1. SELECCIÓN Y BÚSQUEDA DE CLIENTE
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

            // Consulta en BD mediante el DAO
            clienteActual = _clientesDao.ObtenerPorDNI(dniIngresado);

            if (clienteActual != null)
            {
                // Cliente existente: Autocompletar tarjeta
                lblClienteNombre.Text = clienteActual.NombreCompleto;
                lblClienteDni.Text = $"DNI: {clienteActual.Dni}";
                btnRedirigirCrudCliente.Visible = false;
            }
            else
            {
                // Cliente NO existente: Activar botón de redirección directa al CRUD
                lblClienteNombre.Text = "⚠️ Cliente No Registrado";
                lblClienteDni.Text = $"No existe cliente con DNI {dniIngresado}";
                btnRedirigirCrudCliente.Visible = true;
            }
        }

        private void btnRedirigirCrudCliente_Click(object sender, EventArgs e)
        {
            // Redirecciona al CRUD de clientes conservando el DNI buscado
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
                Notebook noteSeleccionada = dgvCatalogo.Rows[e.RowIndex].Tag as Notebook;

                if (noteSeleccionada != null)
                {
                    // Abrir la ventana modal flotante Quick View
                    using (FormDetalleNotebook modal = new FormDetalleNotebook(noteSeleccionada))
                    {
                        if (modal.ShowDialog() == DialogResult.OK)
                        {
                            AgregarAlCarrito(modal.LaptopSeleccionada);
                        }
                    }
                }
            }
        }

        // ==========================================
        // 3. GESTIÓN DE CARRITO Y SUBTOTAL
        // ==========================================
        private void AgregarAlCarrito(Notebook notebook)
        {
            carritoVenta.Add(notebook);
            ActualizarVistaCarrito();
        }

        private void ActualizarVistaCarrito()
        {
            dgvCarrito.Rows.Clear();
            decimal subtotal = 0;

            foreach (var item in carritoVenta)
            {
                dgvCarrito.Rows.Add(item.Marca, item.Modelo, $"${item.Precio:N0}");
                subtotal += item.Precio;
            }

            lblSubtotalEstimado.Text = $"${subtotal:N0}";
        }

        private void btnPasarAFacturacion_Click(object sender, EventArgs e)
        {
            if (clienteActual == null)
            {
                KryptonMessageBox.Show("Debe seleccionar un cliente antes de continuar a facturación.", "Atención",
                                       KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            if (carritoVenta.Count == 0)
            {
                KryptonMessageBox.Show("El carrito de compras está vacío. Seleccione al menos una notebook.", "Atención",
                                       KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            // Transferir cliente y lista de productos al módulo de facturación
            FormFacturacion formFacturacion = new FormFacturacion(clienteActual, carritoVenta);
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
                HeaderText = "Acción",
                Text = "🔍 Ver Detalles",
                UseColumnTextForButtonValue = true
            };
            dgvCatalogo.Columns.Add(btnCol);
            dgvCatalogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarGrillaCarrito()
        {
            dgvCarrito.Columns.Clear();
            dgvCarrito.Columns.Add("colCarMarca", "Marca");
            dgvCarrito.Columns.Add("colCarModelo", "Modelo");
            dgvCarrito.Columns.Add("colCarPrecio", "Precio");
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}