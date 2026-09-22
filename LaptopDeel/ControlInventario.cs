using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class ControlInventario : UserControl
    {
        public ControlInventario()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        private void ControlInventario_Load(object sender, EventArgs e)
        {
            CargarCombosHardware();
            ConfigurarColumnasGrilla();
            LimpiarFormulario();
        }

        private void CargarCombosHardware()
        {
            // Marcas
            cmbMarca.Items.Clear();
            cmbMarca.Items.AddRange(new string[] { "Lenovo", "ASUS", "HP", "Dell", "Acer", "Apple", "MSI" });
            cmbMarca.SelectedIndex = 0;

            // Procesadores
            cmbProcesador.Items.Clear();
            cmbProcesador.Items.AddRange(new string[] { "Intel Core i5-13400H", "Intel Core i7-13700H", "AMD Ryzen 5 5500U", "AMD Ryzen 7 7735HS", "Apple M2" });
            cmbProcesador.SelectedIndex = 0;

            // RAM
            cmbRam.Items.Clear();
            cmbRam.Items.AddRange(new string[] { "8 GB DDR4", "16 GB DDR4", "16 GB DDR5", "32 GB DDR5" });
            cmbRam.SelectedIndex = 0;

            // Almacenamiento
            cmbAlmacenamiento.Items.Clear();
            cmbAlmacenamiento.Items.AddRange(new string[] { "256 GB SSD NVMe", "512 GB SSD NVMe", "1 TB SSD NVMe", "2 TB SSD NVMe" });
            cmbAlmacenamiento.SelectedIndex = 0;

            // Pantalla
            cmbPantalla.Items.Clear();
            cmbPantalla.Items.AddRange(new string[] { "14.0\" FHD (1920x1080)", "15.6\" FHD 144Hz", "16.0\" QHD 165Hz", "13.3\" Retina" });
            cmbPantalla.SelectedIndex = 0;

            // Filtros de tabla
            cmbFiltroCategoria.Items.Clear();
            cmbFiltroCategoria.Items.AddRange(new string[] { "Todas las Categorías", "Gaming", "Diseño/Edición", "Ofimática", "Estudio" });
            cmbFiltroCategoria.SelectedIndex = 0;

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.AddRange(new string[] { "Activas", "Inactivas / Eliminadas" });
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.Columns.Add("IdNotebook", "ID");
            dgvInventario.Columns.Add("Marca", "Marca");
            dgvInventario.Columns.Add("Modelo", "Modelo");
            dgvInventario.Columns.Add("Especificaciones", "Especificaciones de Hardware");
            dgvInventario.Columns.Add("Precio", "Precio ($)");
            dgvInventario.Columns.Add("Stock", "Stock (Uds)");
            dgvInventario.Columns.Add("Estado", "Estado");

            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarFormulario()
        {
            txtId.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            numStock.Value = 1;
            txtGpu.Text = string.Empty;

            chkGaming.Checked = false;
            chkDiseno.Checked = false;
            chkOfimatica.Checked = false;
            chkEstudio.Checked = false;

            if (cmbMarca.Items.Count > 0) cmbMarca.SelectedIndex = 0;
            if (cmbProcesador.Items.Count > 0) cmbProcesador.SelectedIndex = 0;
            if (cmbRam.Items.Count > 0) cmbRam.SelectedIndex = 0;
            if (cmbAlmacenamiento.Items.Count > 0) cmbAlmacenamiento.SelectedIndex = 0;
            if (cmbPantalla.Items.Count > 0) cmbPantalla.SelectedIndex = 0;

            btnGuardarNuevo.Enabled = true;
            btnActualizar.Enabled = false;

            dgvInventario.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarFormulario();

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Modo Maqueta: Se validarán los componentes y se registrará el equipo en el catálogo.",
                                   "Información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Modo Maqueta: Se actualizarán las especificaciones técnicas y precio del equipo.",
                                   "Información", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void btnDesactivarNotebook_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Modo Maqueta: Se desactivará el equipo del catálogo público (baja lógica).",
                                   "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
        }

        private void btnReactivarNotebook_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Modo Maqueta: Se restaurará el equipo como disponible en el catálogo.",
                                   "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) { }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool mostrandoInactivos = cmbFiltroEstado.SelectedIndex == 1;
            btnReactivarNotebook.Enabled = mostrandoInactivos;
            btnDesactivarNotebook.Enabled = !mostrandoInactivos;
        }

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                btnGuardarNuevo.Enabled = false;
                btnActualizar.Enabled = true;
            }
        }
    }
}