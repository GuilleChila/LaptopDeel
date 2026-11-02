using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace LaptopDeel
{
    public partial class FormCeoPrincipal : KryptonForm
    {
        // Temporizador para la transición de entrada fluida (Fade-In)
        private readonly System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();

        // Referencia a la vista que se está cargando dinámicamente en el canvas
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        // Variable para guardar la sesión activa del usuario
        private Usuario usuarioActual;

        public FormCeoPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();
        }

        public FormCeoPrincipal(Usuario usuarioLogueado) : this()
        {
            usuarioActual = usuarioLogueado ?? new Usuario();

            if (usuarioLogueado != null && !string.IsNullOrEmpty(usuarioLogueado.Nombre))
            {
                string rol = usuarioLogueado.RolUsuario?.RolName ?? "CEO/Gerente";
                lblUsuarioSidebar.Values.Text = $"👤 {usuarioLogueado.Nombre.Trim()} ({rol})";
            }
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
            if (this.btnNavDashboard != null)
                this.btnNavDashboard.Click += new EventHandler(this.btnNavDashboard_Click);

            if (this.btnNavClientes != null)
                this.btnNavClientes.Click += new EventHandler(this.btnNavClientes_Click);

            if (this.btnAccionClientes != null)
                this.btnAccionClientes.Click += new EventHandler(this.btnNavClientes_Click);

            if (this.btnNavHistorialVentas != null)
                this.btnNavHistorialVentas.Click += new EventHandler(this.btnNavHistorialVentas_Click);

            if (this.btnCerrarSesion != null)
                this.btnCerrarSesion.Click += new EventHandler(this.btnCerrarSesion_Click);
        }

        /// <summary>
        /// Restablece el estado visual de los botones del menú lateral y resalta el seleccionado en Azul.
        /// Sincroniza StateTracking, StatePressed y remueve el foco directo para prevenir el color gris de selección.
        /// </summary>
        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            KryptonButton[] botones =
            {
                btnNavDashboard,
                btnNavClientes,
                btnNavReporteVentas,
                btnNavReporteStock,
                btnNavHistorialVentas
            };

            foreach (var btn in botones)
            {
                if (btn == null) continue;

                // Estado inactivo / transparente
                btn.StateCommon.Back.Color1 = Color.Transparent;
                btn.StateCommon.Back.Color2 = Color.Transparent;
                btn.StateTracking.Back.Color1 = Color.FromArgb(47, 58, 76); // Hover suave
                btn.StateTracking.Back.Color2 = Color.FromArgb(47, 58, 76);
                btn.StatePressed.Back.Color1 = Color.FromArgb(30, 41, 59);
                btn.StatePressed.Back.Color2 = Color.FromArgb(30, 41, 59);
                btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184); // Texto gris slate
            }

            // Estado activo / seleccionado (Azul Royal #2563EB)
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

            // Remueve el foco visual activo del botón para impedir que Windows Forms dibuje el borde o parche gris[cite: 8]
            this.ActiveControl = panelCanvas;
        }

        /// <summary>
        /// Inyecta una nueva vista (UserControl) en el lienzo central con congelamiento de layout y efecto Fade-In[cite: 5].
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

        private void btnNavDashboard_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavDashboard);

            panelCanvas.SuspendLayout();
            panelCanvas.Controls.Clear();

            // Restaura la vista inicial del Dashboard Ejecutivo
            panelCanvas.Controls.Add(this.lblSubtituloModulo);
            panelCanvas.Controls.Add(this.lblTituloModulo);
            panelCanvas.Controls.Add(this.tableLayoutPanelCards);
            panelCanvas.ResumeLayout(true);
        }

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);

            // Instancia y carga de manera fluida el control de clientes en el canvas
            ControlClientes vistaClientes = new ControlClientes();
            CargarVistaConTransicion(vistaClientes);
        }

        private void btnNavHistorialVentas_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavHistorialVentas);

            // Carga el módulo pasando el usuario activo (Rol Gerente/CEO)
            ControlHistorialVentas vistaHistorial = new ControlHistorialVentas(usuarioActual ?? new Usuario());
            CargarVistaConTransicion(vistaHistorial);
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            // Notifica a Program.cs que se cerró sesión para retornar a la pantalla de Login
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }



        private void btnNavReporteVentas_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos cualquier otra pantalla que esté abierta actualmente
            panelCanvas.Controls.Clear();

            // 2. Creamos el nuevo control del reporte que armaste recién
            ControlReportVentas controlReporte = new ControlReportVentas();

            // 3. Le decimos que se estire para ocupar todo el espacio del panel
            controlReporte.Dock = DockStyle.Fill;

            // 4. Lo agregamos visualmente al panel
            panelCanvas.Controls.Add(controlReporte);
        }

      
       private void btnNavReporteStock_Click(object sender, EventArgs e)
        {
            // 1. Limpiamos el panel
            panelCanvas.Controls.Clear();

            // 2. Usamos el NUEVO control
            ControlStockNotebooks controlStock = new ControlStockNotebooks();
            controlStock.Dock = DockStyle.Fill;

            // 3. Lo agregamos al panel
            panelCanvas.Controls.Add(controlStock);
        }
    }
    
}