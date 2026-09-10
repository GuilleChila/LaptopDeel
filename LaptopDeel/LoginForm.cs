using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
        }

        private void ConfigurarEstiloVentana()
        {
            // Configuración de dimensiones fijas del formulario
            this.Text = "LaptopDeel - Iniciar Sesión";
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);

            // 1. Obtener la ruta dinámica del archivo dentro de la carpeta Assets del ejecutable
            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "fondo_login.jpg");

            if (File.Exists(rutaImagen))
            {
                // Instanciar el PictureBox para que funcione como lienzo de fondo
                PictureBox pbFondo = new PictureBox
                {
                    Image = Image.FromFile(rutaImagen),
                    SizeMode = PictureBoxSizeMode.StretchImage, // Fuerza a estirar la imagen exacto a 1360x720 px
                    Dock = DockStyle.Fill
                };

                // Agregar el PictureBox a los controles del formulario y enviarlo al fondo
                this.Controls.Add(pbFondo);
                pbFondo.SendToBack();
            }

            // 2. Traer la tarjeta central al frente de la jerarquía visual
            if (panelTarjetaCentral != null)
            {
                panelTarjetaCentral.BringToFront();
            }
        }
           
        // Evento asociado al botón "btnIniciarSesion"
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Directo sin validaciones: notifica que se presionó el botón y cierra el login
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtEmail_Paint(object sender, PaintEventArgs e) { }
        private void L_contraseñaLogin_Click(object sender, EventArgs e) { }
        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}