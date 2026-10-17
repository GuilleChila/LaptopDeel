using System;
using System.Drawing;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace LaptopDeel
{
    public partial class FormAdminPrincipal : KryptonForm
    {
        // Se especifica 'System.Windows.Forms.Timer' explícitamente para resolver el error CS0104
        private System.Windows.Forms.Timer timerTransition = new System.Windows.Forms.Timer();

        // Se declara como nulable (UserControl?) para corregir la advertencia CS8618
        private UserControl? vistaCargando;
        private double nivelOpacidad = 0.0;

        public FormAdminPrincipal()
        {
            InitializeComponent();
            ConfigurarEstiloVentana();
            ConfigurarOptimizacionesRender();
            ConfigurarTimerTransicion();
            VincularEventosNavegacion();
        }

        // Este constructor recibe el objeto Usuario desde Program.cs
        public FormAdminPrincipal(Entidades.Usuario usuarioLogueado) : this()
        {
            if (usuarioLogueado != null && usuarioLogueado.RolUsuario != null)
            {
                lblUsuario.Values.Text = $"  👤 {usuarioLogueado.Nombre.Trim()} ({usuarioLogueado.RolUsuario.RolName.Trim()}) ";
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
            timerTransition.Interval = 15; // ~60 FPS para suavidad
            timerTransition.Tick += TimerTransition_Tick;
        }

        private void VincularEventosNavegacion()
        {
            this.btnNavInicio.Click += new System.EventHandler(this.btnNavInicio_Click);
            this.btnNavInventario.Click += new System.EventHandler(this.btnNavInventario_Click);
            this.btnNavUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
            this.btnNavClientes.Click += new System.EventHandler(this.btnNavClientes_Click);

            this.btnAccionNotebook.Click += new System.EventHandler(this.btnNavInventario_Click);
            this.btnAccionUsuarios.Click += new System.EventHandler(this.btnNavUsuarios_Click);
        }

        /// <summary>
        /// Restablece el estado visual de los botones del menú lateral y aplica el color azul deseado al botón activo.
        /// Iguala StateTracking, StatePressed y limpia el foco visual.
        /// </summary>
        private void ResetearEstadosSidebar(KryptonButton? botonActivo)
        {
            KryptonButton[] botones = { btnNavInicio, btnNavInventario, btnNavUsuarios, btnNavClientes };

            foreach (var btn in botones)
            {
                if (btn == null) continue;

                // Estilo por defecto (Inactivo / Transparente)
                btn.StateCommon.Back.Color1 = Color.Transparent;
                btn.StateCommon.Back.Color2 = Color.Transparent;
                btn.StateTracking.Back.Color1 = Color.FromArgb(47, 58, 76); // Hover suave
                btn.StateTracking.Back.Color2 = Color.FromArgb(47, 58, 76);
                btn.StatePressed.Back.Color1 = Color.FromArgb(30, 41, 59);
                btn.StatePressed.Back.Color2 = Color.FromArgb(30, 41, 59);
                btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184); // Texto gris claro
            }

            // Aplicar estilo de botón SELECCIONADO (Azul)
            if (botonActivo != null)
            {
                Color azulActivo = Color.FromArgb(37, 99, 235); // Azul #2563EB

                // Asignar el mismo azul a todos los estados para evitar que vuelva al gris
                botonActivo.StateCommon.Back.Color1 = azulActivo;
                botonActivo.StateCommon.Back.Color2 = azulActivo;
                botonActivo.StateTracking.Back.Color1 = azulActivo;
                botonActivo.StateTracking.Back.Color2 = azulActivo;
                botonActivo.StatePressed.Back.Color1 = azulActivo;
                botonActivo.StatePressed.Back.Color2 = azulActivo;

                // Texto e ícono en blanco puro
                botonActivo.StateCommon.Content.ShortText.Color1 = Color.White;
                botonActivo.StateTracking.Content.ShortText.Color1 = Color.White;
                botonActivo.StatePressed.Content.ShortText.Color1 = Color.White;
            }

            // Mueve el foco al canvas para quitar el recuadro gris de foco de Windows
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

        // --- RUTAS Y MANEJADORES DE EVENTOS ---

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

        private void btnCerrarSesion_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }
    }
}