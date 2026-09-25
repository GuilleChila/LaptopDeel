using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades; 

namespace LaptopDeel
{
    public partial class FormCeoPrincipal : KryptonForm
    {
        // Temporizador para la transición de entrada fluida (Fade-In)
        private System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();

        // Referencia a la vista que se está cargando dinámicamente en el canvas
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        // 1. Variable para guardar el usuario en esta pantalla
        private Usuario usuarioActual;

        // 2. Tu constructor original

        public FormCeoPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();
        }

        // 3. EL CONSTRUCTOR NUEVO: Esta es la "puerta" que Program.cs está buscando
        public FormCeoPrincipal(Usuario usuarioLogueado) : this()
        {
            usuarioActual = usuarioLogueado;
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Panel Ejecutivo (CEO)";

            // Habilita la barra de controles de ventana nativa de Windows
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);
        }

        /// <summary>
        /// Activa el Doble Búfer nativo a nivel de Formulario y Panel para eliminar el parpadeo de pantalla.
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
            // Evento para el botón de CRUD de Clientes
            if (this.btnNavClientes != null)
            {
                this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);
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
            nuevaVista.Visible = false; // Se oculta temporalmente durante el arranque del renderizado
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

        // --- MANEJADORES DE RUTAS Y NAVEGACIÓN ---

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);

            // Instancia y carga de manera fluida el control de clientes en el canvas
            ControlClientes vistaClientes = new ControlClientes();
            CargarVistaConTransicion(vistaClientes);
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            // Notifica a Program.cs que se cerró sesión para retornar a la pantalla de Login
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}