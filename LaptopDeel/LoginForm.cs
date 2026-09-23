using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class LoginForm : KryptonForm
    {
        // Instancia del DAO para interactuar con la base de datos
        private readonly UsuarioDAO _usuarioDAO;

        // Propiedad pública para que Program.cs o los formularios principales tengan todos los datos del usuario logueado
        public Usuario? UsuarioAutenticado { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
            _usuarioDAO = new UsuarioDAO();
            ConfigurarEstiloVentana();
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Iniciar Sesión";
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);

            string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "fondo_login.jpg");

            if (File.Exists(rutaImagen))
            {
                PictureBox pbFondo = new PictureBox
                {
                    Image = Image.FromFile(rutaImagen),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill
                };

                this.Controls.Add(pbFondo);
                pbFondo.SendToBack();
            }

            if (panelTarjetaCentral != null)
            {
                panelTarjetaCentral.BringToFront();
            }
        }

        // Evento asociado al botón "btnIniciarSesion" conectado a MariaDB
        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                KryptonMessageBox.Show(
                    "Por favor, ingrese su correo y contraseña.",
                    "Atención",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Warning
                );
                return;
            }

            try
            {
                // Consulta real contra MariaDB pasando por UsuarioDAO
                Usuario? usuario = _usuarioDAO.IniciarSesion(email, password);

                if (usuario != null)
                {
                    // Guardamos el usuario autenticado en la propiedad pública
                    this.UsuarioAutenticado = usuario;

                    // Normalizamos el Tag según el nombre de rol obtenido de la BD (r.rol_nombre)
                    string nombreRol = usuario.RolUsuario?.RolName ?? "";


                    if (nombreRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase) ||
                        nombreRol.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Tag = "Admin";
                    }
                    else if (nombreRol.Equals("Ventas", StringComparison.OrdinalIgnoreCase) ||
                             nombreRol.Equals("Vendedor", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Tag = "Vendedor";
                    }
                    else if (nombreRol.Equals("Gerente", StringComparison.OrdinalIgnoreCase))
                    {
                        this.Tag = "Gerente";
                    }
                    else
                    {
                        this.Tag = nombreRol;
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    KryptonMessageBox.Show(
                        "Credenciales incorrectas o usuario inactivo.",
                        "Error de Autenticación",
                        KryptonMessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(
                    $"Ocurrió un error al conectar con la base de datos:\n{ex.Message}",
                    "Error de Conexión",
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