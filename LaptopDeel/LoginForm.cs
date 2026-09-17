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
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                // Se utilizan los tipos nativos de Krypton para botones e íconos
                KryptonMessageBox.Show(
                    "Por favor, ingrese su correo y contraseña.",
                    "Atención",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Warning
                );
                return;
            }

            // Validación temporal previa a la conexión con SQL Server
            if (email == "admin@laptopdeel.com" && password == "admin123")
            {
                this.Tag = "Admin";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (email == "vendedor@laptopdeel.com" && password == "vendedor123")
            {
                this.Tag = "Vendedor";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else if (email == "gerente@laptopdeel.com" && password == "gerente123")
            {
                this.Tag = "Gerente";
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                KryptonMessageBox.Show(
                    "Credenciales incorrectas. Verifique el usuario y la clave.",
                    "Error de Autenticación",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error
                );
            }
        }

        private void txtEmail_Paint(object sender, PaintEventArgs e) { }
        private void L_contraseñaLogin_Click(object sender, EventArgs e) { }
        private void LoginForm_Load(object sender, EventArgs e) { }
    }
}