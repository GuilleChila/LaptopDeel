using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades; // <-- IMPORTANTE: Agregamos la ruta del Usuario

namespace LaptopDeel
{
    public partial class FormCeoPrincipal : KryptonForm
    {
        // 1. Variable para guardar el usuario en esta pantalla
        private Usuario usuarioActual;

        // 2. Tu constructor original
        public FormCeoPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
        }

        // 3. EL CONSTRUCTOR NUEVO: Esta es la "puerta" que Program.cs está buscando
        public FormCeoPrincipal(Usuario usuarioLogueado) : this()
        {
            usuarioActual = usuarioLogueado;
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Panel Ejecutivo (CEO)";

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
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void btnNavClientes_Click(object sender, EventArgs e)
        {
            //referenciar a ControlCliente.cs//
        }
    }
}