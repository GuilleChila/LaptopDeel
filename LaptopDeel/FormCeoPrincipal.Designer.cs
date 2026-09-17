namespace LaptopDeel
{
    partial class FormCeoPrincipal
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
            this.lblFechaHora = new Krypton.Toolkit.KryptonLabel();
            this.panelSidebar = new Krypton.Toolkit.KryptonPanel();
            this.btnNavDashboard = new Krypton.Toolkit.KryptonButton();
            this.btnNavClientes = new Krypton.Toolkit.KryptonButton();
            this.btnNavReporteVentas = new Krypton.Toolkit.KryptonButton();
            this.btnNavReporteStock = new Krypton.Toolkit.KryptonButton();
            this.lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            this.btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            this.panelCanvas = new Krypton.Toolkit.KryptonPanel();
            this.lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            this.panelCardClientes = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloClientes = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionClientes = new Krypton.Toolkit.KryptonButton();
            this.panelCardVentas = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloVentas = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionVentas = new Krypton.Toolkit.KryptonButton();
            this.panelCardStock = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloStock = new Krypton.Toolkit.KryptonLabel();
            this.btnAccionStock = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).BeginInit();
            this.panelCanvas.SuspendLayout();
            this.tableLayoutPanelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardClientes)).BeginInit();
            this.panelCardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardVentas)).BeginInit();
            this.panelCardVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardStock)).BeginInit();
            this.panelCardStock.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader (Color #1E293B)
            // 
            this.panelHeader.Controls.Add(this.lblTituloApp);
            this.panelHeader.Controls.Add(this.lblStatusDB);
            this.panelHeader.Controls.Add(this.lblFechaHora);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1360, 60);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelHeader.TabIndex = 0;

            // lblTituloApp
            this.lblTituloApp.Location = new System.Drawing.Point(20, 15);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(180, 30);
            this.lblTituloApp.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTituloApp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.Values.Text = "LaptopDeel CEO";

            // lblStatusDB (Anclado a la Derecha)
            this.lblStatusDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusDB.Location = new System.Drawing.Point(1020, 20);
            this.lblStatusDB.Name = "lblStatusDB";
            this.lblStatusDB.Size = new System.Drawing.Size(150, 20);
            this.lblStatusDB.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblStatusDB.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusDB.Values.Text = "● Conectado (DB)";

            // lblFechaHora (Anclado a la Derecha)
            this.lblFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaHora.Location = new System.Drawing.Point(1180, 20);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(160, 20);
            this.lblFechaHora.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFechaHora.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaHora.Values.Text = "14 Septiembre 2026";

            // 
            // panelSidebar (Menú Lateral de Gerencia)
            // 
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.btnNavClientes);
            this.panelSidebar.Controls.Add(this.btnNavReporteVentas);
            this.panelSidebar.Controls.Add(this.btnNavReporteStock);
            this.panelSidebar.Controls.Add(this.lblUsuarioSidebar);
            this.panelSidebar.Controls.Add(this.btnCerrarSesion);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 660);
            this.panelSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.TabIndex = 1;

            // btnNavDashboard
            this.btnNavDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavDashboard.Location = new System.Drawing.Point(15, 30);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(210, 45);
            this.btnNavDashboard.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavDashboard.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNavDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.Values.Text = "📊 Inicio / Dashboard";

            // btnNavClientes
            this.btnNavClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavClientes.Location = new System.Drawing.Point(15, 85);
            this.btnNavClientes.Name = "btnNavClientes";
            this.btnNavClientes.Size = new System.Drawing.Size(210, 45);
            this.btnNavClientes.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavClientes.Values.Text = "👥 CRUD Clientes";

            // btnNavReporteVentas
            this.btnNavReporteVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavReporteVentas.Location = new System.Drawing.Point(15, 140);
            this.btnNavReporteVentas.Name = "btnNavReporteVentas";
            this.btnNavReporteVentas.Size = new System.Drawing.Size(210, 45);
            this.btnNavReporteVentas.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavReporteVentas.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavReporteVentas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavReporteVentas.Values.Text = "📈 Reporte de Ventas";

            // btnNavReporteStock
            this.btnNavReporteStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavReporteStock.Location = new System.Drawing.Point(15, 195);
            this.btnNavReporteStock.Name = "btnNavReporteStock";
            this.btnNavReporteStock.Size = new System.Drawing.Size(210, 45);
            this.btnNavReporteStock.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavReporteStock.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavReporteStock.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavReporteStock.Values.Text = "💻 Reporte de Stock";

            // lblUsuarioSidebar
            this.lblUsuarioSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioSidebar.Location = new System.Drawing.Point(15, 550);
            this.lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            this.lblUsuarioSidebar.Size = new System.Drawing.Size(210, 25);
            this.lblUsuarioSidebar.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblUsuarioSidebar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioSidebar.Values.Text = "👤 Guillermo (CEO/Gerente)";

            // btnCerrarSesion
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
            // panelCanvas (#F8FAFC)
            // 
            this.panelCanvas.Controls.Add(this.lblSubtituloModulo);
            this.panelCanvas.Controls.Add(this.lblTituloModulo);
            this.panelCanvas.Controls.Add(this.tableLayoutPanelCards);
            this.panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCanvas.Location = new System.Drawing.Point(240, 60);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(1120, 660);
            this.panelCanvas.StateCommon.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelCanvas.StateCommon.Color2 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelCanvas.TabIndex = 2;

            // lblSubtituloModulo
            this.lblSubtituloModulo.Location = new System.Drawing.Point(30, 20);
            this.lblSubtituloModulo.Name = "lblSubtituloModulo";
            this.lblSubtituloModulo.Size = new System.Drawing.Size(180, 20);
            this.lblSubtituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSubtituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSubtituloModulo.Values.Text = "MÓDULO DE GERENCIA";

            // lblTituloModulo
            this.lblTituloModulo.Location = new System.Drawing.Point(30, 40);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(420, 35);
            this.lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.Values.Text = "Panel de Control Ejecutivo";

            // 
            // tableLayoutPanelCards (Cuadrícula 33.33% Responsiva)
            // 
            this.tableLayoutPanelCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelCards.ColumnCount = 3;
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelCards.Controls.Add(this.panelCardClientes, 0, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCardVentas, 1, 0);
            this.tableLayoutPanelCards.Controls.Add(this.panelCardStock, 2, 0);
            this.tableLayoutPanelCards.Location = new System.Drawing.Point(25, 85);
            this.tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            this.tableLayoutPanelCards.RowCount = 1;
            this.tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelCards.Size = new System.Drawing.Size(1065, 160);
            this.tableLayoutPanelCards.TabIndex = 1;

            // panelCardClientes (CRUD Clientes)
            this.panelCardClientes.Controls.Add(this.lblTituloClientes);
            this.panelCardClientes.Controls.Add(this.btnAccionClientes);
            this.panelCardClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardClientes.Location = new System.Drawing.Point(5, 5);
            this.panelCardClientes.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardClientes.Name = "panelCardClientes";
            this.panelCardClientes.Size = new System.Drawing.Size(345, 150);
            this.panelCardClientes.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardClientes.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloClientes.Location = new System.Drawing.Point(20, 20);
            this.lblTituloClientes.Name = "lblTituloClientes";
            this.lblTituloClientes.Size = new System.Drawing.Size(180, 25);
            this.lblTituloClientes.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloClientes.Values.Text = "Gestión de Clientes";

            this.btnAccionClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionClientes.Location = new System.Drawing.Point(20, 80);
            this.btnAccionClientes.Name = "btnAccionClientes";
            this.btnAccionClientes.Size = new System.Drawing.Size(305, 45);
            this.btnAccionClientes.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAccionClientes.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnAccionClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionClientes.Values.Text = "👥 Administrar Clientes (CRUD)";

            // panelCardVentas (Reporte Ventas)
            this.panelCardVentas.Controls.Add(this.lblTituloVentas);
            this.panelCardVentas.Controls.Add(this.btnAccionVentas);
            this.panelCardVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardVentas.Location = new System.Drawing.Point(360, 5);
            this.panelCardVentas.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardVentas.Name = "panelCardVentas";
            this.panelCardVentas.Size = new System.Drawing.Size(345, 150);
            this.panelCardVentas.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardVentas.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloVentas.Location = new System.Drawing.Point(20, 20);
            this.lblTituloVentas.Name = "lblTituloVentas";
            this.lblTituloVentas.Size = new System.Drawing.Size(180, 25);
            this.lblTituloVentas.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloVentas.Values.Text = "Métricas de Ventas";

            this.btnAccionVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionVentas.Location = new System.Drawing.Point(20, 80);
            this.btnAccionVentas.Name = "btnAccionVentas";
            this.btnAccionVentas.Size = new System.Drawing.Size(305, 45);
            this.btnAccionVentas.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionVentas.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionVentas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionVentas.Values.Text = "📈 Ver Reporte de Ventas";

            // panelCardStock (Reporte Stock)
            this.panelCardStock.Controls.Add(this.lblTituloStock);
            this.panelCardStock.Controls.Add(this.btnAccionStock);
            this.panelCardStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCardStock.Location = new System.Drawing.Point(715, 5);
            this.panelCardStock.Margin = new System.Windows.Forms.Padding(5);
            this.panelCardStock.Name = "panelCardStock";
            this.panelCardStock.Size = new System.Drawing.Size(345, 150);
            this.panelCardStock.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCardStock.StateCommon.Color2 = System.Drawing.Color.White;

            this.lblTituloStock.Location = new System.Drawing.Point(20, 20);
            this.lblTituloStock.Name = "lblTituloStock";
            this.lblTituloStock.Size = new System.Drawing.Size(180, 25);
            this.lblTituloStock.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloStock.Values.Text = "Estado de Inventario";

            this.btnAccionStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccionStock.Location = new System.Drawing.Point(20, 80);
            this.btnAccionStock.Name = "btnAccionStock";
            this.btnAccionStock.Size = new System.Drawing.Size(305, 45);
            this.btnAccionStock.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionStock.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnAccionStock.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnAccionStock.Values.Text = "💻 Ver Reporte de Stock";

            // FormCeoPrincipal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormCeoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaptopDeel - Panel Ejecutivo (CEO)";

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
            ((System.ComponentModel.ISupportInitialize)(this.panelCardClientes)).EndInit();
            this.panelCardClientes.ResumeLayout(false);
            this.panelCardClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardVentas)).EndInit();
            this.panelCardVentas.ResumeLayout(false);
            this.panelCardVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCardStock)).EndInit();
            this.panelCardStock.ResumeLayout(false);
            this.panelCardStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
        private Krypton.Toolkit.KryptonLabel lblFechaHora;
        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavDashboard;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonButton btnNavReporteVentas;
        private Krypton.Toolkit.KryptonButton btnNavReporteStock;
        private Krypton.Toolkit.KryptonLabel lblUsuarioSidebar;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private Krypton.Toolkit.KryptonPanel panelCanvas;
        private Krypton.Toolkit.KryptonLabel lblSubtituloModulo;
        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private Krypton.Toolkit.KryptonPanel panelCardClientes;
        private Krypton.Toolkit.KryptonLabel lblTituloClientes;
        private Krypton.Toolkit.KryptonButton btnAccionClientes;
        private Krypton.Toolkit.KryptonPanel panelCardVentas;
        private Krypton.Toolkit.KryptonLabel lblTituloVentas;
        private Krypton.Toolkit.KryptonButton btnAccionVentas;
        private Krypton.Toolkit.KryptonPanel panelCardStock;
        private Krypton.Toolkit.KryptonLabel lblTituloStock;
        private Krypton.Toolkit.KryptonButton btnAccionStock;
    }
}