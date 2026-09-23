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
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            panelSidebar = new Krypton.Toolkit.KryptonPanel();
            btnNavDashboard = new Krypton.Toolkit.KryptonButton();
            btnNavClientes = new Krypton.Toolkit.KryptonButton();
            btnNavReporteVentas = new Krypton.Toolkit.KryptonButton();
            btnNavReporteStock = new Krypton.Toolkit.KryptonButton();
            lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            panelCanvas = new Krypton.Toolkit.KryptonPanel();
            lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanelCards = new TableLayoutPanel();
            panelCardClientes = new Krypton.Toolkit.KryptonPanel();
            lblTituloClientes = new Krypton.Toolkit.KryptonLabel();
            btnAccionClientes = new Krypton.Toolkit.KryptonButton();
            panelCardVentas = new Krypton.Toolkit.KryptonPanel();
            lblTituloVentas = new Krypton.Toolkit.KryptonLabel();
            btnAccionVentas = new Krypton.Toolkit.KryptonButton();
            panelCardStock = new Krypton.Toolkit.KryptonPanel();
            lblTituloStock = new Krypton.Toolkit.KryptonLabel();
            btnAccionStock = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).BeginInit();
            panelCanvas.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardClientes).BeginInit();
            panelCardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardVentas).BeginInit();
            panelCardVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardStock).BeginInit();
            panelCardStock.SuspendLayout();
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
            lblTituloApp.Size = new Size(197, 36);
            lblTituloApp.StateCommon.ShortText.Color1 = Color.White;
            lblTituloApp.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Values.Text = "LaptopDeel CEO";
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
            panelSidebar.Controls.Add(btnNavDashboard);
            panelSidebar.Controls.Add(btnNavClientes);
            panelSidebar.Controls.Add(btnNavReporteVentas);
            panelSidebar.Controls.Add(btnNavReporteStock);
            panelSidebar.Controls.Add(lblUsuarioSidebar);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 660);
            panelSidebar.StateCommon.Color1 = Color.FromArgb(30, 41, 59);
            panelSidebar.StateCommon.Color2 = Color.FromArgb(30, 41, 59);
            panelSidebar.TabIndex = 1;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavDashboard.Location = new Point(15, 30);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new Size(210, 45);
            btnNavDashboard.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnNavDashboard.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnNavDashboard.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavDashboard.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Values.DropDownArrowColor = Color.Empty;
            btnNavDashboard.Values.Text = "📊 Inicio / Dashboard";
            // 
            // btnNavClientes
            // 
            btnNavClientes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavClientes.Location = new Point(15, 85);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new Size(210, 45);
            btnNavClientes.StateCommon.Back.Color1 = Color.Transparent;
            btnNavClientes.StateCommon.Back.Color2 = Color.Transparent;
            btnNavClientes.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavClientes.TabIndex = 1;
            btnNavClientes.Values.DropDownArrowColor = Color.Empty;
            btnNavClientes.Values.Text = "👥 CRUD Clientes";
            btnNavClientes.Click += btnNavClientes_Click;
            // 
            // btnNavReporteVentas
            // 
            btnNavReporteVentas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavReporteVentas.Location = new Point(15, 140);
            btnNavReporteVentas.Name = "btnNavReporteVentas";
            btnNavReporteVentas.Size = new Size(210, 45);
            btnNavReporteVentas.StateCommon.Back.Color1 = Color.Transparent;
            btnNavReporteVentas.StateCommon.Back.Color2 = Color.Transparent;
            btnNavReporteVentas.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavReporteVentas.TabIndex = 2;
            btnNavReporteVentas.Values.DropDownArrowColor = Color.Empty;
            btnNavReporteVentas.Values.Text = "📈 Reporte de Ventas";
            // 
            // btnNavReporteStock
            // 
            btnNavReporteStock.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavReporteStock.Location = new Point(15, 195);
            btnNavReporteStock.Name = "btnNavReporteStock";
            btnNavReporteStock.Size = new Size(210, 45);
            btnNavReporteStock.StateCommon.Back.Color1 = Color.Transparent;
            btnNavReporteStock.StateCommon.Back.Color2 = Color.Transparent;
            btnNavReporteStock.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavReporteStock.TabIndex = 3;
            btnNavReporteStock.Values.DropDownArrowColor = Color.Empty;
            btnNavReporteStock.Values.Text = "💻 Reporte de Stock";
            // 
            // lblUsuarioSidebar
            // 
            lblUsuarioSidebar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuarioSidebar.Location = new Point(15, 544);
            lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            lblUsuarioSidebar.Size = new Size(229, 27);
            lblUsuarioSidebar.StateCommon.ShortText.Color1 = Color.White;
            lblUsuarioSidebar.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioSidebar.TabIndex = 4;
            lblUsuarioSidebar.Values.Text = "👤 Guillermo (CEO/Gerente)";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCerrarSesion.Location = new Point(15, 585);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 45);
            btnCerrarSesion.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnCerrarSesion.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Values.DropDownArrowColor = Color.Empty;
            btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelCanvas
            // 
            panelCanvas.Controls.Add(lblSubtituloModulo);
            panelCanvas.Controls.Add(lblTituloModulo);
            panelCanvas.Controls.Add(tableLayoutPanelCards);
            panelCanvas.Dock = DockStyle.Fill;
            panelCanvas.Location = new Point(240, 60);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(1120, 660);
            panelCanvas.StateCommon.Color1 = Color.FromArgb(248, 250, 252);
            panelCanvas.StateCommon.Color2 = Color.FromArgb(248, 250, 252);
            panelCanvas.TabIndex = 2;
            // 
            // lblSubtituloModulo
            // 
            lblSubtituloModulo.Location = new Point(30, 20);
            lblSubtituloModulo.Name = "lblSubtituloModulo";
            lblSubtituloModulo.Size = new Size(183, 24);
            lblSubtituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblSubtituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtituloModulo.TabIndex = 0;
            lblSubtituloModulo.Values.Text = "MÓDULO DE GERENCIA";
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(30, 40);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(398, 46);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 1;
            lblTituloModulo.Values.Text = "Panel de Control Ejecutivo";
            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCards.BackColor = Color.Transparent;
            tableLayoutPanelCards.ColumnCount = 3;
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelCards.Controls.Add(panelCardClientes, 0, 0);
            tableLayoutPanelCards.Controls.Add(panelCardVentas, 1, 0);
            tableLayoutPanelCards.Controls.Add(panelCardStock, 2, 0);
            tableLayoutPanelCards.Location = new Point(25, 85);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowCount = 1;
            tableLayoutPanelCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCards.Size = new Size(1065, 160);
            tableLayoutPanelCards.TabIndex = 1;
            // 
            // panelCardClientes
            // 
            panelCardClientes.Controls.Add(lblTituloClientes);
            panelCardClientes.Controls.Add(btnAccionClientes);
            panelCardClientes.Dock = DockStyle.Fill;
            panelCardClientes.Location = new Point(5, 5);
            panelCardClientes.Margin = new Padding(5);
            panelCardClientes.Name = "panelCardClientes";
            panelCardClientes.Size = new Size(345, 150);
            panelCardClientes.StateCommon.Color1 = Color.White;
            panelCardClientes.StateCommon.Color2 = Color.White;
            panelCardClientes.TabIndex = 0;
            // 
            // lblTituloClientes
            // 
            lblTituloClientes.Location = new Point(20, 20);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new Size(199, 32);
            lblTituloClientes.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloClientes.TabIndex = 0;
            lblTituloClientes.Values.Text = "Gestión de Clientes";
            // 
            // btnAccionClientes
            // 
            btnAccionClientes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionClientes.Location = new Point(20, 80);
            btnAccionClientes.Name = "btnAccionClientes";
            btnAccionClientes.Size = new Size(305, 45);
            btnAccionClientes.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnAccionClientes.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnAccionClientes.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionClientes.TabIndex = 1;
            btnAccionClientes.Values.DropDownArrowColor = Color.Empty;
            btnAccionClientes.Values.Text = "👥 Administrar Clientes (CRUD)";
            // 
            // panelCardVentas
            // 
            panelCardVentas.Controls.Add(lblTituloVentas);
            panelCardVentas.Controls.Add(btnAccionVentas);
            panelCardVentas.Dock = DockStyle.Fill;
            panelCardVentas.Location = new Point(360, 5);
            panelCardVentas.Margin = new Padding(5);
            panelCardVentas.Name = "panelCardVentas";
            panelCardVentas.Size = new Size(345, 150);
            panelCardVentas.StateCommon.Color1 = Color.White;
            panelCardVentas.StateCommon.Color2 = Color.White;
            panelCardVentas.TabIndex = 1;
            // 
            // lblTituloVentas
            // 
            lblTituloVentas.Location = new Point(20, 20);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new Size(197, 32);
            lblTituloVentas.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloVentas.TabIndex = 0;
            lblTituloVentas.Values.Text = "Métricas de Ventas";
            // 
            // btnAccionVentas
            // 
            btnAccionVentas.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionVentas.Location = new Point(20, 80);
            btnAccionVentas.Name = "btnAccionVentas";
            btnAccionVentas.Size = new Size(305, 45);
            btnAccionVentas.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnAccionVentas.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnAccionVentas.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionVentas.TabIndex = 1;
            btnAccionVentas.Values.DropDownArrowColor = Color.Empty;
            btnAccionVentas.Values.Text = "📈 Ver Reporte de Ventas";
            // 
            // panelCardStock
            // 
            panelCardStock.Controls.Add(lblTituloStock);
            panelCardStock.Controls.Add(btnAccionStock);
            panelCardStock.Dock = DockStyle.Fill;
            panelCardStock.Location = new Point(715, 5);
            panelCardStock.Margin = new Padding(5);
            panelCardStock.Name = "panelCardStock";
            panelCardStock.Size = new Size(345, 150);
            panelCardStock.StateCommon.Color1 = Color.White;
            panelCardStock.StateCommon.Color2 = Color.White;
            panelCardStock.TabIndex = 2;
            // 
            // lblTituloStock
            // 
            lblTituloStock.Location = new Point(20, 20);
            lblTituloStock.Name = "lblTituloStock";
            lblTituloStock.Size = new Size(212, 32);
            lblTituloStock.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloStock.TabIndex = 0;
            lblTituloStock.Values.Text = "Estado de Inventario";
            // 
            // btnAccionStock
            // 
            btnAccionStock.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAccionStock.Location = new Point(20, 80);
            btnAccionStock.Name = "btnAccionStock";
            btnAccionStock.Size = new Size(305, 45);
            btnAccionStock.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnAccionStock.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnAccionStock.StateCommon.Content.ShortText.Color1 = Color.White;
            btnAccionStock.TabIndex = 1;
            btnAccionStock.Values.DropDownArrowColor = Color.Empty;
            btnAccionStock.Values.Text = "💻 Ver Reporte de Stock";
            // 
            // FormCeoPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Controls.Add(panelCanvas);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormCeoPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Panel Ejecutivo (CEO)";
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
            ((System.ComponentModel.ISupportInitialize)panelCardClientes).EndInit();
            panelCardClientes.ResumeLayout(false);
            panelCardClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardVentas).EndInit();
            panelCardVentas.ResumeLayout(false);
            panelCardVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardStock).EndInit();
            panelCardStock.ResumeLayout(false);
            panelCardStock.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
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