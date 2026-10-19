using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormDetalleNotebook : KryptonForm
    {
        public Notebook LaptopSeleccionada { get; private set; }
        public int CantidadSeleccionada { get; private set; } = 1;

        public FormDetalleNotebook(Notebook notebook)
        {
            this.LaptopSeleccionada = notebook;
            InitializeComponent();
            ConfigurarEstiloModal();
            CargarDatosNotebook();
        }

        private void ConfigurarEstiloModal()
        {
            this.Text = "Detalles del Equipo - Quick View";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(640, 520);
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC");
        }

        private void CargarDatosNotebook()
        {
            // Encabezado Principal
            lblMarcaModelo.Text = $"{LaptopSeleccionada.Marca} {LaptopSeleccionada.Modelo}";
            lblPrecio.Text = $"${LaptopSeleccionada.Precio:N0}";

            // Especificaciones de Hardware
            lblProcesadorVal.Text = string.IsNullOrWhiteSpace(LaptopSeleccionada.Procesador) ? "No especificado" : LaptopSeleccionada.Procesador;
            lblRamVal.Text = string.IsNullOrWhiteSpace(LaptopSeleccionada.Ram) ? "No especificado" : LaptopSeleccionada.Ram;
            lblAlmacenamientoVal.Text = string.IsNullOrWhiteSpace(LaptopSeleccionada.Almacenamiento) ? "No especificado" : LaptopSeleccionada.Almacenamiento;
            lblPantallaVal.Text = string.IsNullOrWhiteSpace(LaptopSeleccionada.Pantalla) ? "No especificado" : LaptopSeleccionada.Pantalla;

            // Uso directo de TarjetaGrafica (Evita el error CS1061)
            lblGpuVal.Text = string.IsNullOrWhiteSpace(LaptopSeleccionada.TarjetaGrafica) ? "Gráficos Integrados" : LaptopSeleccionada.TarjetaGrafica;

            // Gestión de Stock y Control de Cantidad
            if (LaptopSeleccionada.Stock <= 0)
            {
                lblStockModal.Text = "🚫 SIN STOCK DISPONIBLE";
                lblStockModal.StateCommon.ShortText.Color1 = Color.FromArgb(239, 68, 68);
                btnSeleccionar.Enabled = false;

                numCantidad.Enabled = false;
                numCantidad.Minimum = 0;
                numCantidad.Value = 0;
            }
            else
            {
                lblStockModal.Text = $"🟢 Unidades Disponibles: {LaptopSeleccionada.Stock}";
                lblStockModal.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);
                btnSeleccionar.Enabled = true;

                numCantidad.Enabled = true;
                numCantidad.Minimum = 0;
                numCantidad.Maximum = LaptopSeleccionada.Stock;
                numCantidad.Minimum = 1;
                numCantidad.Value = 1;
            }

            this.Refresh();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            CantidadSeleccionada = (int)numCantidad.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void FormDetalleNotebook_Load(object sender, EventArgs e)
        {

        }
    }
}