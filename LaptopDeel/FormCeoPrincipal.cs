using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class FormCeoPrincipal : KryptonForm
    {
        public FormCeoPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
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
    }
}