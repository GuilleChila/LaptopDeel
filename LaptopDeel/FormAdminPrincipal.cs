using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormAdminPrincipal : KryptonForm
    {
        private System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        // Referencia a la sesión del usuario actualmente conectado
        private readonly Usuario? _usuarioActual;

        public FormAdminPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();
        }

        public FormAdminPrincipal(Usuario usuarioLogueado) : this()
        {
            _usuarioActual = usuarioLogueado;

            if (_usuarioActual != null && _usuarioActual.RolUsuario != null)
            {
                lblUsuario.Values.Text = $"  👤 {_usuarioActual.Nombre.Trim()} ({_usuarioActual.RolUsuario.RolName.Trim()})";
            }
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Panel de Administración";
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.ControlBox = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(1360, 720);
            this.MinimumSize = new Size(1360, 720);
        }

        private void ConfigurarOptimizacionesRender()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.AllPaintingInWmPaint |
                           ControlStyles.UserPaint, true);
            this.UpdateStyles();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, panelCanvas, new object[] { true });
        }

        private void ConfigurarTimerTransicion()
        {
            timerTransition.Interval = 15; // ~60 FPS
            timerTransition.Tick += TimerTransition_Tick;
        }

        private void VincularEventosNavegacion()
        {
            this.btnNavInicio.Click += new System.EventHandler(this.btnNavInicio_Click);
            this.btnNavInventario.Click += new System.EventHandler(this.btnNavInventario_Click);
            this.btnNavUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
            this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);
            this.btnNavLogs.Click += new System.EventHandler(this.btnNavLogs_Click);

            this.btnAccionNotebook.Click += new System.EventHandler(this.btnNavInventario_Click);
            this.btnAccionUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
        }

        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            KryptonButton[] botones = { btnNavInicio, btnNavInventario, btnNavUsuarios, btnNavClientes, btnNavLogs };

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
                btn.StateTracking.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
                btn.StatePressed.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
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

        private void CargarVistaConTransicion(UserControl nuevaVista)
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

        private void FinalizarSesionActual()
        {
            if (_usuarioActual != null && _usuarioActual.IdSesionActiva > 0)
            {
                try
                {
                    var sesionDao = new SesionDAO();
                    sesionDao.FinalizarSesionLog(_usuarioActual.IdSesionActiva);
                    _usuarioActual.IdSesionActiva = 0;
                }
                catch
                {
                    // Fallback silencioso en el cierre
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            FinalizarSesionActual();
            base.OnFormClosing(e);
        }

        // --- RUTAS DE NAVEGACIÓN ---

        private void btnNavInicio_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavInicio);

            panelCanvas.SuspendLayout();
            panelCanvas.Controls.Clear();

            panelCanvas.Controls.Add(this.lblBienvenida);
            panelCanvas.Controls.Add(this.tableLayoutPanelCards);
            panelCanvas.ResumeLayout(true);
        }

        private void btnNavInventario_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavInventario);
            CargarVistaConTransicion(new ControlInventario());
        }

        private void btnNavUsuarios_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavUsuarios);
            CargarVistaConTransicion(new ControlUsuarios());
        }

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);
            CargarVistaConTransicion(new ControlClientes());
        }

        private void btnNavLogs_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavLogs);
            CargarVistaConTransicion(new ControlLogs());
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            FinalizarSesionActual();
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}