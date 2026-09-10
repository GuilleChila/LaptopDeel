using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class FormPrincipal : KryptonForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
            ConfigurarVentana();
        }

        private void ConfigurarVentana()
        {
            this.Text = "LaptopDeel - Menú Principal";
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorTranslator.FromHtml("#F8FAFC"); // Fondo claro del menú
        }
    }
}