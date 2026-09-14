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
            this.panelHeader = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            this.lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            this.panelSidebar = new Krypton.Toolkit.KryptonPanel();
            this.btnNavInicio = new Krypton.Toolkit.KryptonButton();
            this.btnNavPOS = new Krypton.Toolkit.KryptonButton();
            this.btnNavInventario = new Krypton.Toolkit.KryptonButton();
            this.btnNavUsuarios = new Krypton.Toolkit.KryptonButton();
            this.btnNavClientes = new Krypton.Toolkit.KryptonButton();
            this.lblUsuario = new Krypton.Toolkit.KryptonLabel();
            this.btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            this.panelCanvas = new Krypton.Toolkit.KryptonPanel();
            this.lblBienvenida = new Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelCardPOS = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloPOS = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionPOS = new Krypton.Toolkit.KryptonButton();
            this.panelCardNotebook = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloNotebook = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionNotebook = new Krypton.Toolkit.KryptonButton();
            this.panelCardUsuarios = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloUsuarios = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionUsuarios = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).BeginInit();
            this.panelCanvas.SuspendLayout();
            this.tableLayoutPanelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardPOS)).BeginInit();
            this.panelCardPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardNotebook)).BeginInit();
            this.panelCardNotebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardUsuarios)).BeginInit();
            this.panelCardUsuarios.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader (Se estira automáticamente al 100% de ancho)
            // 
            this.panelHeader.Controls.Add(this.lblTituloApp);
            this.panelHeader.Controls.Add(this.lblStatusDB);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.TabIndex = 0;

            // lblTituloApp (Anclado a la izquierda)
            this.lblTituloApp.Location = new System.Drawing.Point(20, 15);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(180, 30);
            this.lblTituloApp.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTituloApp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.Values.Text = "LaptopDeel Admin";

            // lblStatusDB (Anclado a la DERECHA para mantenerse en la esquina superior)
            this.lblStatusDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusDB.Location = new System.Drawing.Point(1180, 20);
            this.lblStatusDB.Name = "lblStatusDB";
            this.lblStatusDB.Size = new System.Drawing.Size(150, 20);
            this.lblStatusDB.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblStatusDB.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusDB.Values.Text = "● Conectado (DB)";

            // 
            // panelSidebar (Barra lateral izquierda)
            // 
            this.panelSidebar.Controls.Add(this.btnNavInicio);
            this.panelSidebar.Controls.Add(this.btnNavPOS);
            this.panelSidebar.Controls.Add(this.btnNavInventario);
            this.panelSidebar.Controls.Add(this.btnNavUsuarios);
            this.panelSidebar.Controls.Add(this.btnNavClientes);
            this.panelSidebar.Controls.Add(this.lblUsuario);
            this.panelSidebar.Controls.Add(this.btnCerrarSesion);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 660);
            this.panelSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.TabIndex = 1;

            // Botones de navegación con anclaje horizontal
            this.btnNavInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavInicio.Location = new System.Drawing.Point(15, 30);
            this.btnNavInicio.Name = "btnNavInicio";
            this.btnNavInicio.Size = new System.Drawing.Size(210, 45);
            this.btnNavInicio.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavInicio.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavInicio.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNavInicio.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavInicio.Values.Text = "🏠 Inicio / Dashboard";

            this.btnNavPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavPOS.Location = new System.Drawing.Point(15, 85);
            this.btnNavPOS.Name = "btnNavPOS";
            this.btnNavPOS.Size = new System.Drawing.Size(210, 45);
            this.btnNavPOS.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavPOS.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavPOS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavPOS.Values.Text = "🛒 Punto de Venta (POS)";

            this.btnNavInventario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavInventario.Location = new System.Drawing.Point(15, 140);
            this.btnNavInventario.Name = "btnNavInventario";
            this.btnNavInventario.Size = new System.Drawing.Size(210, 45);
            this.btnNavInventario.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavInventario.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavInventario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavInventario.Values.Text = "💻 Inventario";

            this.btnNavUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavUsuarios.Location = new System.Drawing.Point(15, 195);
            this.btnNavUsuarios.Name = "btnNavUsuarios";
            this.btnNavUsuarios.Size = new System.Drawing.Size(210, 45);
            this.btnNavUsuarios.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavUsuarios.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavUsuarios.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavUsuarios.Values.Text = "👥 Usuarios";

            this.btnNavClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavClientes.Location = new System.Drawing.Point(15, 250);
            this.btnNavClientes.Name = "btnNavClientes";
            this.btnNavClientes.Size = new System.Drawing.Size(210, 45);
            this.btnNavClientes.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavClientes.Values.Text = "📋 Clientes";

            // lblUsuario y btnCerrarSesion (Anclados a la parte INFERIOR para mantenerse abajo en 1080p)
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Location = new System.Drawing.Point(15, 550);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(210, 25);
            this.lblUsuario.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblUsuario.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.Values.Text = "👤 Guillermo (Admin)";

            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(15, 585);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(210, 45);
            this.btnCerrarSesion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCerrarSesion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCerrarSesion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCerrarSesion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);

            // 
            // panelCanvas (Lienzo principal responsivo)
            // 
            this.panelCanvas.Controls.Add(this.lblBienvenida);
            this.panelCanvas.Controls.Add(this.tableLayoutPanelCards);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(240, 60);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1120, 660);
            this.panelCanvas.StateCommon.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelCanvas.StateCommon.Color2 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelCanvas.TabIndex = 2;

            // lblBienvenida
            this.lblBienvenida.Location = new System.Drawing.Point(30, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(350, 35);
            this.lblBienvenida.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblBienvenida.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Values.Text = "Bienvenido, Administrador";

            // 
            // tableLayoutPanelCards (Cuadrícula Porcentual Responsiva)
            // 
            this.tableLayoutPanelCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCards.ColumnCount = 3;
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.Controls.Add(this.panelCardPOS, 0, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCardNotebook, 1, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCardUsuarios, 2, 0);
            this.tableLayoutPanelCards.Location = new System.Drawing.Point(25, 80);
            this.tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            this.tableLayoutPanelCards.RowCount = 1;
            this.tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCards.Size = new System.Drawing.Size(1065, 160);
            this.tableLayoutPanelCards.TabIndex = 1;

            // 
            // panelCardPOS (Tarjeta 1: Se redimensiona automáticamente)
            // 
            this.panelCardPOS.Controls.Add(this.lblTituloPOS);
            this.panelCardPOS.Controls.Add(this.btnAccionPOS);
            this.panelCardPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardPOS.Location = new System.Drawing.Point(5, 5);
            this.panelCardPOS.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardPOS.Name = "panelCardPOS";
            this.panelCardPOS.Size = new System.Drawing.Size(345, 150);
            this.panelCardPOS.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardPOS.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloPOS.Location = new System.Drawing.Point(20, 20);
            this.lblTituloPOS.Name = "lblTituloPOS";
            this.lblTituloPOS.Size = new System.Drawing.Size(120, 25);
            this.lblTituloPOS.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloPOS.Values.Text = "Nueva Venta";

            this.btnAccionPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionPOS.Location = new System.Drawing.Point(20, 80);
            this.btnAccionPOS.Name = "btnAccionPOS";
            this.btnAccionPOS.Size = new System.Drawing.Size(305, 45);
            this.btnAccionPOS.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAccionPOS.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAccionPOS.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionPOS.Values.Text = "Abrir Punto de Venta (POS)";

            // 
            // panelCardNotebook (Tarjeta 2: Se redimensiona automáticamente)
            // 
            this.panelCardNotebook.Controls.Add(this.lblTituloNotebook);
            this.panelCardNotebook.Controls.Add(this.btnAccionNotebook);
            this.panelCardNotebook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardNotebook.Location = new System.Drawing.Point(360, 5);
            this.panelCardNotebook.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardNotebook.Name = "panelCardNotebook";
            this.panelCardNotebook.Size = new System.Drawing.Size(345, 150);
            this.panelCardNotebook.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardNotebook.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloNotebook.Location = new System.Drawing.Point(20, 20);
            this.lblTituloNotebook.Name = "lblTituloNotebook";
            this.lblTituloNotebook.Size = new System.Drawing.Size(150, 25);
            this.lblTituloNotebook.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloNotebook.Values.Text = "Cargar Notebook";

            this.btnAccionNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionNotebook.Location = new System.Drawing.Point(20, 80);
            this.btnAccionNotebook.Name = "btnAccionNotebook";
            this.btnAccionNotebook.Size = new System.Drawing.Size(305, 45);
            this.btnAccionNotebook.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionNotebook.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionNotebook.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionNotebook.Values.Text = "Registrar nuevo equipo";

            // 
            // panelCardUsuarios (Tarjeta 3: Se redimensiona automáticamente)
            // 
            this.panelCardUsuarios.Controls.Add(this.lblTituloUsuarios);
            this.panelCardUsuarios.Controls.Add(this.btnAccionUsuarios);
            this.panelCardUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardUsuarios.Location = new System.Drawing.Point(715, 5);
            this.panelCardUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardUsuarios.Name = "panelCardUsuarios";
            this.panelCardUsuarios.Size = new System.Drawing.Size(345, 150);
            this.panelCardUsuarios.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardUsuarios.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloUsuarios.Location = new System.Drawing.Point(20, 20);
            this.lblTituloUsuarios.Name = "lblTituloUsuarios";
            this.lblTituloUsuarios.Size = new System.Drawing.Size(130, 25);
            this.lblTituloUsuarios.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloUsuarios.Values.Text = "Crear Usuario";

            this.btnAccionUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionUsuarios.Location = new System.Drawing.Point(20, 80);
            this.btnAccionUsuarios.Name = "btnAccionUsuarios";
            this.btnAccionUsuarios.Size = new System.Drawing.Size(305, 45);
            this.btnAccionUsuarios.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionUsuarios.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionUsuarios.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionUsuarios.Values.Text = "Agregar nuevo usuario";

            // 
            // FormAdminPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormAdminPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaptopDeel - Panel de Administración";

            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.tableLayoutPanelCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCardPOS)).EndInit();
            this.panelCardPOS.ResumeLayout(false);
            this.panelCardPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardNotebook)).EndInit();
            this.panelCardNotebook.ResumeLayout(false);
            this.panelCardNotebook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardUsuarios)).EndInit();
            this.panelCardUsuarios.ResumeLayout(false);
            this.panelCardUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavInicio;
        private Krypton.Toolkit.KryptonButton btnNavPOS;
        private Krypton.Toolkit.KryptonButton btnNavInventario;
        private Krypton.Toolkit.KryptonButton btnNavUsuarios;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonLabel lblUsuario;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private Krypton.Toolkit.KryptonPanel panelCanvas;
        private Krypton.Toolkit.KryptonLabel lblBienvenida;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private Krypton.Toolkit.KryptonPanel panelCardPOS;
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