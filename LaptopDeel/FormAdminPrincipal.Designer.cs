namespace LaptopDeel
{
    partial class FormAdminPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            panelSidebar = new Krypton.Toolkit.KryptonPanel();
            btnNavInicio = new Krypton.Toolkit.KryptonButton();
            btnNavInventario = new Krypton.Toolkit.KryptonButton();
            btnNavUsuarios = new Krypton.Toolkit.KryptonButton();
            btnNavClientes = new Krypton.Toolkit.KryptonButton();
            lblUsuario = new Krypton.Toolkit.KryptonLabel();
            btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            panelCanvas = new Krypton.Toolkit.KryptonPanel();
            lblBienvenida = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanelCards = new TableLayoutPanel();
            panelCardNotebook = new Krypton.Toolkit.KryptonPanel();
            lblTituloNotebook = new Krypton.Toolkit.KryptonLabel();
            btnAccionNotebook = new Krypton.Toolkit.KryptonButton();
            panelCardUsuarios = new Krypton.Toolkit.KryptonPanel();
            lblTituloUsuarios = new Krypton.Toolkit.KryptonLabel();
            btnAccionUsuarios = new Krypton.Toolkit.KryptonButton();
            lblTituloPOS = new Krypton.Toolkit.KryptonLabel();
            btnAccionPOS = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).BeginInit();
            panelCanvas.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardNotebook).BeginInit();
            panelCardNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardUsuarios).BeginInit();
            panelCardUsuarios.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTituloApp);
            panelHeader.Controls.Add(lblStatusDB);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1360, 60);
            panelHeader.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelHeader.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelHeader.TabIndex = 0;
            // 
            // lblTituloApp
            // 
            lblTituloApp.Location = new Point(20, 15);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new Size(226, 36);
            lblTituloApp.StateCommon.ShortText.Color1 = Color.White;
            lblTituloApp.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Values.Text = "LaptopDeel Admin";
            // 
            // lblStatusDB
            // 
            lblStatusDB.Dock = DockStyle.Right;
            lblStatusDB.Location = new Point(1220, 0);
            lblStatusDB.Name = "lblStatusDB";
            lblStatusDB.Size = new Size(140, 60);
            lblStatusDB.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);
            lblStatusDB.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusDB.TabIndex = 1;
            lblStatusDB.Values.Text = "● Conectado (DB)";
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnNavInicio);
            panelSidebar.Controls.Add(btnNavInventario);
            panelSidebar.Controls.Add(btnNavUsuarios);
            panelSidebar.Controls.Add(btnNavClientes);
            panelSidebar.Controls.Add(lblUsuario);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 660);
            panelSidebar.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelSidebar.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelSidebar.TabIndex = 1;
            // 
            // btnNavInicio
            // 
            btnNavInicio.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavInicio.Location = new Point(15, 30);
            btnNavInicio.Name = "btnNavInicio";
            btnNavInicio.Size = new Size(210, 45);
            btnNavInicio.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnNavInicio.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnNavInicio.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavInicio.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavInicio.StateTracking.Back.ColorAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            btnNavInicio.TabIndex = 0;
            btnNavInicio.Values.DropDownArrowColor = Color.Empty;
            btnNavInicio.Values.Text = "🏠 Inicio / Dashboard";
            // 
            // btnNavInventario
            // 
            btnNavInventario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavInventario.Location = new Point(15, 85);
            btnNavInventario.Name = "btnNavInventario";
            btnNavInventario.Size = new Size(210, 45);
            btnNavInventario.StateCommon.Back.Color1 = Color.Transparent;
            btnNavInventario.StateCommon.Back.Color2 = Color.Transparent;
            btnNavInventario.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavInventario.TabIndex = 2;
            btnNavInventario.Values.DropDownArrowColor = Color.Empty;
            btnNavInventario.Values.Text = "💻 Inventario";
            btnNavInventario.Click += btnNavInventario_Click;
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavUsuarios.Location = new Point(15, 140);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(210, 45);
            btnNavUsuarios.StateCommon.Back.Color1 = Color.Transparent;
            btnNavUsuarios.StateCommon.Back.Color2 = Color.Transparent;
            btnNavUsuarios.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavUsuarios.TabIndex = 3;
            btnNavUsuarios.Values.DropDownArrowColor = Color.Empty;
            btnNavUsuarios.Values.Text = "👥 Usuarios";
            btnNavUsuarios.Click += btnNavUsuarios_Click;
            // 
            // btnNavClientes
            // 
            btnNavClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavClientes.Location = new Point(15, 195);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new Size(210, 45);
            btnNavClientes.StateCommon.Back.Color1 = Color.Transparent;
            btnNavClientes.StateCommon.Back.Color2 = Color.Transparent;
            btnNavClientes.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavClientes.TabIndex = 4;
            btnNavClientes.Values.DropDownArrowColor = Color.Empty;
            btnNavClientes.Values.Text = "📋 Clientes";
            btnNavClientes.Click += btnNavClientes_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblUsuario.Location = new Point(0, 531);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(180, 27);
            lblUsuario.StateCommon.ShortText.Color1 = Color.White;
            lblUsuario.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.TabIndex = 5;
            lblUsuario.Values.Text = "👤 Guillermo(Admin))";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(12, 585);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 45);
            btnCerrarSesion.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCerrarSesion.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Values.DropDownArrowColor = Color.Empty;
            btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelCanvas
            // 
            panelCanvas.Controls.Add(lblBienvenida);
            panelCanvas.Controls.Add(tableLayoutPanelCards);
            panelCanvas.Dock = DockStyle.Fill;
            panelCanvas.Location = new Point(240, 60);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(1120, 660);
            panelCanvas.StateCommon.Color1 = Color.FromArgb(248, 250, 252);
            panelCanvas.StateCommon.Color2 = Color.FromArgb(248, 250, 252);
            panelCanvas.TabIndex = 2;
            // 
            // lblBienvenida
            // 
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(407, 46);
            lblBienvenida.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblBienvenida.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Values.Text = "Bienvenido, Administrador";
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCards.BackColor = Color.Transparent;
            tableLayoutPanelCards.ColumnCount = 2;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCards.Controls.Add(panelCardNotebook, 0, 0);
            tableLayoutPanelCards.Controls.Add(panelCardUsuarios, 1, 0);
            tableLayoutPanelCards.Location = new Point(25, 80);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowCount = 1;
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCards.Size = new Size(1065, 160);
            tableLayoutPanelCards.TabIndex = 1;
            // 
            // panelCardNotebook
            // 
            panelCardNotebook.Controls.Add(lblTituloNotebook);
            panelCardNotebook.Controls.Add(btnAccionNotebook);
            panelCardNotebook.Dock = DockStyle.Fill;
            panelCardNotebook.Location = new Point(5, 5);
            panelCardNotebook.Margin = new Padding(5);
            panelCardNotebook.Name = "panelCardNotebook";
            panelCardNotebook.Size = new Size(522, 150);
            panelCardNotebook.StateCommon.Color1 = Color.White;
            panelCardNotebook.StateCommon.Color2 = Color.White;
            panelCardNotebook.TabIndex = 1;
            // 
            // lblTituloNotebook
            // 
            lblTituloNotebook.Location = new Point(20, 20);
            lblTituloNotebook.Name = "lblTituloNotebook";
            lblTituloNotebook.Size = new Size(181, 32);
            lblTituloNotebook.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloNotebook.TabIndex = 0;
            lblTituloNotebook.Values.Text = "Cargar Notebook";
            // 
            // btnAccionNotebook
            // 
            btnAccionNotebook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionNotebook.Location = new Point(20, 80);
            btnAccionNotebook.Name = "btnAccionNotebook";
            btnAccionNotebook.Size = new Size(482, 45);
            btnAccionNotebook.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnAccionNotebook.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnAccionNotebook.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionNotebook.TabIndex = 1;
            btnAccionNotebook.Values.DropDownArrowColor = Color.Empty;
            btnAccionNotebook.Values.Text = "Registrar nuevo equipo";
            // 
            // panelCardUsuarios
            // 
            panelCardUsuarios.Controls.Add(lblTituloUsuarios);
            panelCardUsuarios.Controls.Add(btnAccionUsuarios);
            panelCardUsuarios.Dock = DockStyle.Fill;
            panelCardUsuarios.Location = new Point(537, 5);
            panelCardUsuarios.Margin = new Padding(5);
            panelCardUsuarios.Name = "panelCardUsuarios";
            panelCardUsuarios.Size = new Size(523, 150);
            panelCardUsuarios.StateCommon.Color1 = Color.White;
            panelCardUsuarios.StateCommon.Color2 = Color.White;
            panelCardUsuarios.TabIndex = 2;
            // 
            // lblTituloUsuarios
            // 
            lblTituloUsuarios.Location = new Point(20, 20);
            lblTituloUsuarios.Name = "lblTituloUsuarios";
            lblTituloUsuarios.Size = new Size(144, 32);
            lblTituloUsuarios.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloUsuarios.TabIndex = 0;
            lblTituloUsuarios.Values.Text = "Crear Usuario";
            // 
            // btnAccionUsuarios
            // 
            btnAccionUsuarios.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionUsuarios.Location = new Point(20, 80);
            btnAccionUsuarios.Name = "btnAccionUsuarios";
            btnAccionUsuarios.Size = new Size(483, 45);
            btnAccionUsuarios.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnAccionUsuarios.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnAccionUsuarios.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionUsuarios.TabIndex = 1;
            btnAccionUsuarios.Values.DropDownArrowColor = Color.Empty;
            btnAccionUsuarios.Values.Text = "Agregar nuevo usuario";
            // 
            // lblTituloPOS
            // 
            lblTituloPOS.Location = new Point(20, 20);
            lblTituloPOS.Name = "lblTituloPOS";
            lblTituloPOS.Size = new Size(48, 24);
            lblTituloPOS.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloPOS.TabIndex = 0;
            lblTituloPOS.Values.Text = "Nueva Venta";
            // 
            // btnAccionPOS
            // 
            btnAccionPOS.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionPOS.Location = new Point(20, 80);
            btnAccionPOS.Name = "btnAccionPOS";
            btnAccionPOS.Size = new Size(305, 45);
            btnAccionPOS.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnAccionPOS.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnAccionPOS.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionPOS.TabIndex = 1;
            btnAccionPOS.Values.DropDownArrowColor = Color.Empty;
            btnAccionPOS.Values.Text = "Abrir Punto de Venta (POS)";
            // 
            // FormAdminPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Controls.Add(panelCanvas);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormAdminPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Panel de Administración";
            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).EndInit();
            panelCanvas.ResumeLayout(false);
            panelCanvas.PerformLayout();
            tableLayoutPanelCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardNotebook).EndInit();
            panelCardNotebook.ResumeLayout(false);
            panelCardNotebook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardUsuarios).EndInit();
            panelCardUsuarios.ResumeLayout(false);
            panelCardUsuarios.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavInicio;
        private Krypton.Toolkit.KryptonButton btnNavInventario;
        private Krypton.Toolkit.KryptonButton btnNavUsuarios;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonLabel lblUsuario;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private Krypton.Toolkit.KryptonPanel panelCanvas;
        private Krypton.Toolkit.KryptonLabel lblBienvenida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private Krypton.Toolkit.KryptonLabel lblTituloPOS;
        private Krypton.Toolkit.KryptonButton btnAccionPOS;
        private Krypton.Toolkit.KryptonPanel panelCardNotebook;
        private Krypton.Toolkit.KryptonLabel lblTituloNotebook;
        private Krypton.Toolkit.KryptonButton btnAccionNotebook;
        private Krypton.Toolkit.KryptonPanel panelCardUsuarios;
        private Krypton.Toolkit.KryptonLabel lblTituloUsuarios;
        private Krypton.Toolkit.KryptonButton btnAccionUsuarios;
    }
}