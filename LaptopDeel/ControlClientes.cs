using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class ControlClientes : UserControl
    {
        public ControlClientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ControlClientes_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarColumnasGrilla();
            LimpiarFormulario();
        }

        private void CargarCombos()
        {
            // Opciones de IVA
            cmbIva.Items.Clear();
            cmbIva.Items.Add("Consumidor Final");
            cmbIva.Items.Add("Responsable Inscripto");
            cmbIva.Items.Add("Monotributo");
            cmbIva.Items.Add("Exento");
            cmbIva.SelectedIndex = 0;

            // Opciones de Filtro
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("Activos");
            cmbFiltroEstado.Items.Add("Inactivos / Eliminados");
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("DniCuit", "DNI / CUIT");
            dgvClientes.Columns.Add("NombreCompleto", "Nombre Completo / Razón Social");
            dgvClientes.Columns.Add("Correo", "Correo Electrónico");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Iva", "Condición IVA");
            dgvClientes.Columns.Add("Estado", "Estado");

            // Configurar auto-fill para que la grilla ocupe todo el ancho
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarFormulario()
        {
            txtDniCuit.Text = string.Empty;
            txtDniCuit.Enabled = true; // Permite ingresar la PK
            txtNombreCompleto.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cmbIva.SelectedIndex = 0;

            btnGuardarNuevo.Enabled = true;
            btnActualizar.Enabled = false;

            dgvClientes.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                "Modo Maqueta: Aquí se validarán los datos y se guardará el nuevo cliente en la BD.",
                "Información",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                "Modo Maqueta: Aquí se actualizarán los datos del cliente seleccionado.",
                "Información",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }

        private void btnDesactivarCliente_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                "Modo Maqueta: Aquí se marcará al cliente seleccionado como Eliminado (baja lógica).",
                "Atención",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Warning
            );
        }

        private void btnReactivarCliente_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show(
                "Modo Maqueta: Aquí se restaurará al cliente inactivo como Activo nuevamente.",
                "Éxito",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            // Lógica de búsqueda simulada
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrandoInactivos = cmbFiltroEstado.SelectedIndex == 1;

            // Si está filtrando por inactivos, se habilita el botón de reactivación
            btnReactivarCliente.Enabled = mostrandoInactivos;
            btnDesactivarCliente.Enabled = !mostrandoInactivos;
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                // Al seleccionar un cliente, pasamos a Modo Edición
                btnGuardarNuevo.Enabled = false;
                btnActualizar.Enabled = true;
                txtDniCuit.Enabled = false; // Se bloquea la PK
            }
        }
    }
}