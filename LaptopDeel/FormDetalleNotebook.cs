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
            this.StartPosition = FormStartPosition.CenterParent; // Flotante centrado sobre el POS
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC");
        }

        private void CargarDatosNotebook()
        {
            lblMarcaModelo.Text = $"{LaptopSeleccionada.Marca} {LaptopSeleccionada.Modelo}";
            lblPrecio.Text = $"${LaptopSeleccionada.Precio:N0}";

            // Cargar especificaciones de hardware
            lblProcesadorVal.Text = string.IsNullOrEmpty(LaptopSeleccionada.Procesador) ? "No especificado" : LaptopSeleccionada.Procesador;
            lblRamVal.Text = string.IsNullOrEmpty(LaptopSeleccionada.Ram) ? "No especificado" : LaptopSeleccionada.Ram;
            lblAlmacenamientoVal.Text = string.IsNullOrEmpty(LaptopSeleccionada.Almacenamiento) ? "No especificado" : LaptopSeleccionada.Almacenamiento;
            lblPantallaVal.Text = string.IsNullOrEmpty(LaptopSeleccionada.Pantalla) ? "No especificado" : LaptopSeleccionada.Pantalla;
            lblGpuVal.Text = string.IsNullOrEmpty(LaptopSeleccionada.TarjetaGrafica) ? "Gráficos Integrados" : LaptopSeleccionada.TarjetaGrafica;

            // Validación de Existencias / Stock
            if (LaptopSeleccionada.Stock <= 0)
            {
                lblStockModal.Text = "🚫 SIN STOCK DISPONIBLE";
                lblStockModal.StateCommon.ShortText.Color1 = Color.FromArgb(239, 68, 68); // Rojo
                btnSeleccionar.Enabled = false;
            }
            else
            {
                lblStockModal.Text = $"🟢 Unidades Disponibles: {LaptopSeleccionada.Stock}";
                lblStockModal.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129); // Verde
                btnSeleccionar.Enabled = true;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // Indica selección exitosa
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}