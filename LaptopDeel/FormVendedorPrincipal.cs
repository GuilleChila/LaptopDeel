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

        // Variable para almacenar los datos del usuario autenticado
        private Usuario? usuarioActual;

        public FormVendedorPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();

            // Cargar automáticamente el Punto de Venta (ControlVentas) al iniciar
            CargarPuntoDeVenta();
        }

        // Constructor sobrecargado para recibir el objeto Usuario desde Program.cs
        public FormVendedorPrincipal(Usuario usuarioLogueado) : this()
        {
            usuarioActual = usuarioLogueado;

            if (usuarioLogueado != null && usuarioLogueado.RolUsuario != null)
            {
                lblUsuarioSidebar.Values.Text = $"👤 {usuarioLogueado.Nombre.Trim()} ({usuarioLogueado.RolUsuario.RolName.Trim()})";
            }
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Selección y Punto de Venta (POS)";

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
            if (this.btnNavNuevaVenta != null)
            {
                this.btnNavNuevaVenta.Click += new System.EventHandler(this.btnNavNuevaVenta_Click);
            }

            if (this.btnNavClientes != null)
            {
                this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);
            }

            if (this.btnNavBuscarNotebooks != null)
            {
                this.btnNavBuscarNotebooks.Click += new System.EventHandler(this.btnNavNuevaVenta_Click);
            }

            if (this.btnCerrarSesion != null)
            {
                this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            }
        }

        /// <summary>
        /// Restablece el estado visual de los botones del menú lateral y resalta el botón seleccionado con Azul Royal (#2563EB).
        /// </summary>
        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            KryptonButton[] botones = { btnNavNuevaVenta, btnNavClientes, btnNavBuscarNotebooks };

            foreach (var btn in botones)
            {
                if (btn == null) continue;

                btn.StateCommon.Back.Color1 = Color.Transparent;
                btn.StateCommon.Back.Color2 = Color.Transparent;
                btn.StateTracking.Back.Color1 = Color.FromArgb(47, 58, 76);
                btn.StateTracking.Back.Color2 = Color.FromArgb(47, 58, 76);
                btn.StatePressed.Back.Color1 = Color.FromArgb(30, 41, 59);
                btn.StatePressed.Back.Color2 = Color.FromArgb(30, 41, 59);
                btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            }

            if (botonActivo != null)
            {
                Color azulActivo = Color.FromArgb(37, 99, 235);

                botonActivo.StateCommon.Back.Color1 = azulActivo;
                botonActivo.StateCommon.Back.Color2 = azulActivo;
                botonActivo.StateTracking.Back.Color1 = azulActivo;
                botonActivo.StateTracking.Back.Color2 = azulActivo;
                botonActivo.StatePressed.Back.Color1 = azulActivo;
                botonActivo.StatePressed.Back.Color2 = azulActivo;

                botonActivo.StateCommon.Content.ShortText.Color1 = Color.White;
                botonActivo.StateTracking.Content.ShortText.Color1 = Color.White;
                botonActivo.StatePressed.Content.ShortText.Color1 = Color.White;
            }

            this.ActiveControl = panelCanvas;
        }

        /// <summary>
        /// Inyecta una nueva vista (UserControl) en el lienzo central con efecto Fade-In.
        /// Es pública para permitir que ControlVentas ordene la redirección fluida a ControlClientes.
        /// </summary>
        public void CargarVistaConTransicion(UserControl nuevaVista)
        {
            panelCanvas.SuspendLayout();

            panelCanvas.Controls.Clear();
            nuevaVista.Dock = DockStyle.Fill;
            nuevaVista.Visible = false;
            panelCanvas.Controls.Add(nuevaVista);
            nuevaVista.BringToFront();

            panelCanvas.ResumeLayout(true);

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

        private void btnNavNuevaVenta_Click(object? sender, EventArgs e)
        {
            CargarPuntoDeVenta();
        }

        private void CargarPuntoDeVenta()
        {
            ResetearEstadosSidebar(btnNavNuevaVenta);
            ControlVentas vistaVentas = new ControlVentas();
            CargarVistaConTransicion(vistaVentas);
        }

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);
            ControlClientes vistaClientes = new ControlClientes();
            CargarVistaConTransicion(vistaClientes);
        }
        private void btnProcesarVenta_Click(object? sender, EventArgs e)
        {
            CargarPuntoDeVenta();
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}