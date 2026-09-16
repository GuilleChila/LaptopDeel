using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class FormVendedorPrincipal : KryptonForm
    {
        public FormVendedorPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Selección y Punto de Venta (POS)";

            // Habilita controles estándar de ventana (Minimizar, Maximizar y Cerrar)
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);
        }

        private void btnProcesarVenta_Click(object sender, EventArgs e)
        {
            // Redirección al Formulario de Facturación y Cobro con los equipos seleccionados
            KryptonMessageBox.Show(
                "Redirigiendo al Formulario de Facturación con la lista de notebooks seleccionadas por el cliente...",
                "Paso a Facturación",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );

            // Código para abrir la vista de facturación:
            // FormFacturacion formFacturacion = new FormFacturacion(clienteActual, listaNotebooksSeleccionadas);
            // formFacturacion.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Notifica a Program.cs que se cerró sesión para retornar al Login
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}