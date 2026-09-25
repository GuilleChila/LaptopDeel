using Krypton.Toolkit;
using LaptopDeel.Entidades;
using System;
using System.Drawing;
using System.Windows.Forms;

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

        // Este es el que recibe los datos desde Program.cs
        // El ": this()" hace que primero se ejecute el constructor de arriba para cargar el diseño
        public FormAdminPrincipal(Usuario usuarioLogueado) : this()
        {
            // Verificamos por seguridad que los datos no vengan nulos
            if (usuarioLogueado != null && usuarioLogueado.RolUsuario != null)
            {
                // Actualizamos la etiqueta del menú lateral
                lblUsuario.Values.Text = $"  👤 {usuarioLogueado.Nombre.Trim()} ({usuarioLogueado.RolUsuario.RolName.Trim()}) ) ";
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

        private void ResetearEstadosSidebar(KryptonButton botonActivo)
        {
            btnNavInicio.StateCommon.Back.Color1 = Color.Transparent;
            btnNavInicio.StateCommon.Back.Color2 = Color.Transparent;

            btnNavInventario.StateCommon.Back.Color1 = Color.Transparent;
            btnNavInventario.StateCommon.Back.Color2 = Color.Transparent;

            btnNavUsuarios.StateCommon.Back.Color1 = Color.Transparent;
            btnNavUsuarios.StateCommon.Back.Color2 = Color.Transparent;

            btnNavClientes.StateCommon.Back.Color1 = Color.Transparent;
            btnNavClientes.StateCommon.Back.Color2 = Color.Transparent;

            if (botonActivo != null)
            {
                botonActivo.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
                botonActivo.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
                botonActivo.StateCommon.Content.ShortText.Color1 = Color.White;
            }
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

        // --- RUTAS Y MANEJADORES DE EVENTOS CON FIRMA NULABLE (CS8622) ---

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