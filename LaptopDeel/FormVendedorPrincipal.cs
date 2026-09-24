using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades; // <-- IMPORTANTE: Agregamos esta línea

namespace LaptopDeel
{
    public partial class FormVendedorPrincipal : KryptonForm
    {
        // 1. Variable para guardar el usuario en esta pantalla
        private Usuario usuarioActual;

        // 3. EL CONSTRUCTOR NUEVO: La "puerta" para Program.cs
        // El constructor original (el vacío) ya se encarga de dibujar la ventana
        public FormVendedorPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
        }

        // Este constructor nuevo usa ": this()" para ejecutar primero el de arriba, 
        // y después se ocupa exclusivamente de los datos del usuario.
        public FormVendedorPrincipal(Usuario usuarioLogueado) : this()
        {
            usuarioActual = usuarioLogueado;

            // Actualizamos el nombre visualmente
            if (usuarioLogueado != null && usuarioLogueado.RolUsuario != null)
            {
                lblUsuarioSidebar.Values.Text = $"👤 {usuarioLogueado.Nombre.Trim()} ({usuarioLogueado.RolUsuario.RolName.Trim()})";
            }
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