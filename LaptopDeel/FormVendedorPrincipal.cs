using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormVendedorPrincipal : KryptonForm
    {
        // Temporizador para la transición de entrada fluida (Fade-In)
        private System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();

        // Referencia a la vista que se está cargando dinámicamente en el canvas
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        // 1. Variable para guardar el usuario en esta pantalla
        private Usuario usuarioActual;

        // 3. EL CONSTRUCTOR NUEVO: La "puerta" para Program.cs
        // El constructor original (el vacío) ya se encarga de dibujar la ventana
        public FormVendedorPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();
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

        /// <summary>
        /// Activa el Doble Búfer nativo a nivel de Formulario y Panel para eliminar el parpadeo de pantalla (Flicker-Free).
        /// </summary>
        private void ConfigurarOptimizacionesRender()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.UserPaint, true);
            this.UpdateStyles();

            // Forzamos DoubleBuffer vía Reflection en el panelCanvas
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panelCanvas, new object[] { true });
        }

        private void ConfigurarTimerTransicion()
        {
            timerTransition.Interval = 15; // ~60 FPS para suavidad visual
            timerTransition.Tick += TimerTransition_Tick;
        }

        private void VincularEventosNavegacion()
        {
            // Vinculación del evento para la gestión de clientes
            if (this.btnNavClientes != null)
            {
                this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);
            }

            // Vinculación del evento para procesar venta
            if (this.btnProcesarVenta != null)
            {
                this.btnProcesarVenta.Click += new System.EventHandler(this.btnProcesarVenta_Click);
            }
        }

        /// <summary>
        /// Restablece el estado visual de los botones del menú lateral y resalta el seleccionado.
        /// </summary>
        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            if (btnNavClientes != null)
            {
                btnNavClientes.StateCommon.Back.Color1 = Color.Transparent;
                btnNavClientes.StateCommon.Back.Color2 = Color.Transparent;
            }

            // Resalta el botón seleccionado con Azul Royal sólido #2563EB
            if (botonActivo != null)
            {
                botonActivo.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
                botonActivo.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
                botonActivo.StateCommon.Content.ShortText.Color1 = Color.White;
            }
        }

        /// <summary>
        /// Inyecta una nueva vista (UserControl) en el lienzo central con congelamiento de layout y efecto Fade-In.
        /// </summary>
        private void CargarVistaConTransicion(UserControl nuevaVista)
        {
            panelCanvas.SuspendLayout();

            panelCanvas.Controls.Clear();
            nuevaVista.Dock = DockStyle.Fill;
            nuevaVista.Visible = false; // Oculto temporalmente mientras se prepara el renderizado
            panelCanvas.Controls.Add(nuevaVista);
            nuevaVista.BringToFront();

            panelCanvas.ResumeLayout(true);

            // Iniciar animación de entrada (Fade In)
            vistaCargando = nuevaVista;
            nivelOpacidad = 0.0;
            vistaCargando.Visible = true;
            timerTransition.Start();
        }

        private void TimerTransition_Tick(object? sender, EventArgs e)
        {
            nivelOpacidad += 0.15;
            if (nivelOpacidad >= 1.0)
            {
                timerTransition.Stop();
                if (vistaCargando != null)
                {
                    vistaCargando.Refresh();
                }
            }
        }

        // --- MANEJADORES DE ACCIONES Y NAVEGACIÓN ---

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);

            // Instancia y carga de manera fluida el control CRUD de clientes en el lienzo central
            ControlClientes vistaClientes = new ControlClientes();
            CargarVistaConTransicion(vistaClientes);
        }

        private void btnProcesarVenta_Click(object? sender, EventArgs e)
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

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            // Notifica a Program.cs que se cerró sesión para retornar al Login
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

     
    }
}