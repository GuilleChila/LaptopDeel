using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormCeoPrincipal : KryptonForm
    {
        private readonly System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        private readonly Usuario? _usuarioActual;

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
            _usuarioActual = usuarioLogueado;

            if (_usuarioActual != null && !string.IsNullOrEmpty(_usuarioActual.Nombre))
            {
                string rol = _usuarioActual.RolUsuario?.RolName ?? "CEO/Gerente";
                lblUsuarioSidebar.Values.Text = $"👤 {_usuarioActual.Nombre.Trim()} ({rol})";
            }
        }

        private void ConfigurarEstiloVentana()
        {
            this.Text = "LaptopDeel - Panel Ejecutivo (CEO)";
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
                BindingFlags.SetProperty |
                BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, panelCanvas, new object[] { true });
        }

        private void ConfigurarTimerTransicion()
        {
            timerTransition.Interval = 15;
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

            if (this.btnNavRespaldo != null)
                this.btnNavRespaldo.Click += new EventHandler(this.btnNavRespaldo_Click);

            if (this.btnCerrarSesion != null)
                this.btnCerrarSesion.Click += new EventHandler(this.btnCerrarSesion_Click);
        }

        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            KryptonButton[] botones =
            {
                btnNavDashboard,
                btnNavClientes,
                btnNavReporteVentas,
                btnNavReporteStock,
                btnNavHistorialVentas,
                btnNavRespaldo
            };

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

        // --- MANEJADORES DE RUTAS Y NAVEGACIÓN ---

        private void btnNavDashboard_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavDashboard);

            panelCanvas.SuspendLayout();
            panelCanvas.Controls.Clear();

            panelCanvas.Controls.Add(this.lblSubtituloModulo);
            panelCanvas.Controls.Add(this.lblTituloModulo);
            panelCanvas.Controls.Add(this.tableLayoutPanelCards);
            panelCanvas.ResumeLayout(true);
        }

        private void btnNavClientes_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavClientes);
            ControlClientes vistaClientes = new ControlClientes();
            CargarVistaConTransicion(vistaClientes);
        }

        private void btnNavHistorialVentas_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavHistorialVentas);
            ControlHistorialVentas vistaHistorial = new ControlHistorialVentas(_usuarioActual ?? new Usuario());
            CargarVistaConTransicion(vistaHistorial);
        }

        private void btnNavRespaldo_Click(object? sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavRespaldo);
            ControlRespaldo vistaRespaldo = new ControlRespaldo();
            CargarVistaConTransicion(vistaRespaldo);
        }

        private void btnNavReporteVentas_Click(object sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavReporteVentas);
            panelCanvas.Controls.Clear();
            ControlReportVentas controlReporte = new ControlReportVentas();
            controlReporte.Dock = DockStyle.Fill;
            panelCanvas.Controls.Add(controlReporte);
        }

        private void btnNavReporteStock_Click(object sender, EventArgs e)
        {
            ResetearEstadosSidebar(btnNavReporteStock);
            panelCanvas.Controls.Clear();
            ControlStockNotebooks controlStock = new ControlStockNotebooks();
            controlStock.Dock = DockStyle.Fill;
            panelCanvas.Controls.Add(controlStock);
        }

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            FinalizarSesionActual();
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}