using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class FormAdminPrincipal : KryptonForm
    {
        public FormAdminPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Panel de Administración";

            // Permite mostrar la barra superior con botones de control (Minimizar, Expandir y Cerrar)
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            // Notifica a Program.cs que se cerró sesión para retornar al Login
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnNavUsuarios_Click(object sender, EventArgs e)
        {
            // Cambiar estado visual del menú activo
            btnNavInicio.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnNavUsuarios.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235); // Destacar botón seleccionado

            // Instanciar y cargar la vista dentro del contenedor canvas
            ControlUsuarios vistaUsuarios = new ControlUsuarios
            {
                Dock = DockStyle.Fill
            };

            panelCanvas.Controls.Clear();
            panelCanvas.Controls.Add(vistaUsuarios);
            vistaUsuarios.BringToFront();
        }
    }
}