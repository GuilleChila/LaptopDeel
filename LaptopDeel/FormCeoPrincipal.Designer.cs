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
            components = new System.ComponentModel.Container();
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            lblFechaHoraHeader = new Krypton.Toolkit.KryptonLabel();
            lblStatusDB = new Krypton.Toolkit.KryptonLabel();

            panelSidebar = new Krypton.Toolkit.KryptonPanel();
            btnNavDashboard = new Krypton.Toolkit.KryptonButton();
            btnNavClientes = new Krypton.Toolkit.KryptonButton();
            btnNavReporteVentas = new Krypton.Toolkit.KryptonButton();
            btnNavReporteStock = new Krypton.Toolkit.KryptonButton();
            btnNavHistorialVentas = new Krypton.Toolkit.KryptonButton();
            btnNavRespaldo = new Krypton.Toolkit.KryptonButton();
            lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            btnCerrarSesion = new Krypton.Toolkit.KryptonButton();

            panelCanvas = new Krypton.Toolkit.KryptonPanel();
            lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();

            // KPIs Superiores
            tableLayoutPanelKPIs = new System.Windows.Forms.TableLayoutPanel();
            panelKpiClientes = new Krypton.Toolkit.KryptonPanel();
            lblKpiClientesTitulo = new Krypton.Toolkit.KryptonLabel();
            lblKpiClientesValor = new Krypton.Toolkit.KryptonLabel();
            lblKpiClientesBadge = new Krypton.Toolkit.KryptonLabel();

            panelKpiVentas = new Krypton.Toolkit.KryptonPanel();
            lblKpiVentasTitulo = new Krypton.Toolkit.KryptonLabel();
            lblKpiVentasValor = new Krypton.Toolkit.KryptonLabel();
            lblKpiVentasBadge = new Krypton.Toolkit.KryptonLabel();

            panelKpiStock = new Krypton.Toolkit.KryptonPanel();
            lblKpiStockTitulo = new Krypton.Toolkit.KryptonLabel();
            lblKpiStockValor = new Krypton.Toolkit.KryptonLabel();
            lblKpiStockBadge = new Krypton.Toolkit.KryptonLabel();

            lblSeccionFuncionalidades = new Krypton.Toolkit.KryptonLabel();

            // Tarjetas Principales
            tableLayoutPanelCards = new System.Windows.Forms.TableLayoutPanel();
            panelCardClientes = new Krypton.Toolkit.KryptonPanel();
            lblTituloClientes = new Krypton.Toolkit.KryptonLabel();
            lblDescClientes = new Krypton.Toolkit.KryptonLabel();
            btnAccionClientes = new Krypton.Toolkit.KryptonButton();

            panelCardVentas = new Krypton.Toolkit.KryptonPanel();
            lblTituloVentas = new Krypton.Toolkit.KryptonLabel();
            lblDescVentas = new Krypton.Toolkit.KryptonLabel();
            btnAccionVentas = new Krypton.Toolkit.KryptonButton();

            panelCardStock = new Krypton.Toolkit.KryptonPanel();
            lblTituloStock = new Krypton.Toolkit.KryptonLabel();
            lblDescStock = new Krypton.Toolkit.KryptonLabel();
            btnAccionStock = new Krypton.Toolkit.KryptonButton();

            panelCardHistorial = new Krypton.Toolkit.KryptonPanel();
            lblTituloHistorial = new Krypton.Toolkit.KryptonLabel();
            lblDescHistorial = new Krypton.Toolkit.KryptonLabel();
            btnAccionHistorial = new Krypton.Toolkit.KryptonButton();

            panelCardRespaldo = new Krypton.Toolkit.KryptonPanel();
            lblTituloRespaldo = new Krypton.Toolkit.KryptonLabel();
            lblDescRespaldo = new Krypton.Toolkit.KryptonLabel();
            btnAccionRespaldo = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).BeginInit();
            panelCanvas.SuspendLayout();
            tableLayoutPanelKPIs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelKpiClientes).BeginInit();
            panelKpiClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelKpiVentas).BeginInit();
            panelKpiVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelKpiStock).BeginInit();
            panelKpiStock.SuspendLayout();
            tableLayoutPanelCards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardClientes).BeginInit();
            panelCardClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardVentas).BeginInit();
            panelCardVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardStock).BeginInit();
            panelCardStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardHistorial).BeginInit();
            panelCardHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardRespaldo).BeginInit();
            panelCardRespaldo.SuspendLayout();
            SuspendLayout();

            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblTituloApp);
            panelHeader.Controls.Add(lblFechaHoraHeader);
            panelHeader.Controls.Add(lblStatusDB);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(1360, 60);
            panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            panelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            panelHeader.TabIndex = 0;

            // lblTituloApp
            lblTituloApp.AutoSize = false;
            lblTituloApp.Location = new System.Drawing.Point(20, 15);
            lblTituloApp.Name = "lblTituloApp";
            lblTituloApp.Size = new System.Drawing.Size(300, 32);
            lblTituloApp.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            lblTituloApp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTituloApp.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloApp.TabIndex = 0;
            lblTituloApp.Values.Text = "LaptopDeel CEO";

            // lblFechaHoraHeader
            lblFechaHoraHeader.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            lblFechaHoraHeader.AutoSize = false;
            lblFechaHoraHeader.Location = new System.Drawing.Point(700, 18);
            lblFechaHoraHeader.Name = "lblFechaHoraHeader";
            lblFechaHoraHeader.Size = new System.Drawing.Size(430, 28);
            lblFechaHoraHeader.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(226, 232, 240);
            lblFechaHoraHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblFechaHoraHeader.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            lblFechaHoraHeader.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblFechaHoraHeader.TabIndex = 2;
            lblFechaHoraHeader.Values.Text = "📅 Cargando fecha... | 🕒 00:00:00  ";

            // lblStatusDB
            lblStatusDB.Dock = System.Windows.Forms.DockStyle.Right;
            lblStatusDB.AutoSize = false;
            lblStatusDB.Location = new System.Drawing.Point(1140, 0);
            lblStatusDB.Name = "lblStatusDB";
            lblStatusDB.Size = new System.Drawing.Size(220, 60);
            lblStatusDB.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            lblStatusDB.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblStatusDB.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblStatusDB.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblStatusDB.TabIndex = 1;
            lblStatusDB.Values.Text = "🟢 Conectado (MariaDB)  ";

            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnNavDashboard);
            panelSidebar.Controls.Add(btnNavClientes);
            panelSidebar.Controls.Add(btnNavReporteVentas);
            panelSidebar.Controls.Add(btnNavReporteStock);
            panelSidebar.Controls.Add(btnNavHistorialVentas);
            panelSidebar.Controls.Add(btnNavRespaldo);
            panelSidebar.Controls.Add(lblUsuarioSidebar);
            panelSidebar.Controls.Add(btnCerrarSesion);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(240, 660);
            panelSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            panelSidebar.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            panelSidebar.TabIndex = 1;

            // btnNavDashboard
            btnNavDashboard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavDashboard.Location = new System.Drawing.Point(15, 20);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Size = new System.Drawing.Size(210, 45);
            btnNavDashboard.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNavDashboard.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnNavDashboard.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnNavDashboard.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnNavDashboard.TabIndex = 0;
            btnNavDashboard.Values.Text = "📊 Inicio / Dashboard";

            // btnNavClientes
            btnNavClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavClientes.Location = new System.Drawing.Point(15, 75);
            btnNavClientes.Name = "btnNavClientes";
            btnNavClientes.Size = new System.Drawing.Size(210, 45);
            btnNavClientes.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            btnNavClientes.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            btnNavClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavClientes.TabIndex = 1;
            btnNavClientes.Values.Text = "👥 CRUD Clientes";

            // btnNavReporteVentas
            btnNavReporteVentas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavReporteVentas.Location = new System.Drawing.Point(15, 130);
            btnNavReporteVentas.Name = "btnNavReporteVentas";
            btnNavReporteVentas.Size = new System.Drawing.Size(210, 45);
            btnNavReporteVentas.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            btnNavReporteVentas.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            btnNavReporteVentas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavReporteVentas.TabIndex = 2;
            btnNavReporteVentas.Values.Text = "📈 Reporte de Ventas";

            // btnNavReporteStock
            btnNavReporteStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavReporteStock.Location = new System.Drawing.Point(15, 185);
            btnNavReporteStock.Name = "btnNavReporteStock";
            btnNavReporteStock.Size = new System.Drawing.Size(210, 45);
            btnNavReporteStock.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            btnNavReporteStock.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            btnNavReporteStock.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavReporteStock.TabIndex = 3;
            btnNavReporteStock.Values.Text = "💻 Reporte de Stock";

            // btnNavHistorialVentas
            btnNavHistorialVentas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavHistorialVentas.Location = new System.Drawing.Point(15, 240);
            btnNavHistorialVentas.Name = "btnNavHistorialVentas";
            btnNavHistorialVentas.Size = new System.Drawing.Size(210, 45);
            btnNavHistorialVentas.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            btnNavHistorialVentas.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            btnNavHistorialVentas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavHistorialVentas.TabIndex = 4;
            btnNavHistorialVentas.Values.Text = "📋 Historial Ventas";

            // btnNavRespaldo
            btnNavRespaldo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnNavRespaldo.Location = new System.Drawing.Point(15, 295);
            btnNavRespaldo.Name = "btnNavRespaldo";
            btnNavRespaldo.Size = new System.Drawing.Size(210, 45);
            btnNavRespaldo.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            btnNavRespaldo.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            btnNavRespaldo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            btnNavRespaldo.TabIndex = 5;
            btnNavRespaldo.Values.Text = "💾 Respaldo BD";

            // lblUsuarioSidebar
            lblUsuarioSidebar.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblUsuarioSidebar.AutoSize = false;
            lblUsuarioSidebar.Location = new System.Drawing.Point(15, 544);
            lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            lblUsuarioSidebar.Size = new System.Drawing.Size(210, 30);
            lblUsuarioSidebar.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            lblUsuarioSidebar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblUsuarioSidebar.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblUsuarioSidebar.TabIndex = 6;
            lblUsuarioSidebar.Values.Text = "👤 Gerente (CEO)  ";

            // btnCerrarSesion
            btnCerrarSesion.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnCerrarSesion.Location = new System.Drawing.Point(15, 585);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new System.Drawing.Size(210, 45);
            btnCerrarSesion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(239, 68, 68);
            btnCerrarSesion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnCerrarSesion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCerrarSesion.TabIndex = 7;
            btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";

            // 
            // panelCanvas
            // 
            panelCanvas.Controls.Add(lblSubtituloModulo);
            panelCanvas.Controls.Add(lblTituloModulo);
            panelCanvas.Controls.Add(tableLayoutPanelKPIs);
            panelCanvas.Controls.Add(lblSeccionFuncionalidades);
            panelCanvas.Controls.Add(tableLayoutPanelCards);
            panelCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCanvas.Location = new System.Drawing.Point(240, 60);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new System.Drawing.Size(1120, 660);
            panelCanvas.StateCommon.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            panelCanvas.StateCommon.Color2 = System.Drawing.Color.FromArgb(248, 250, 252);
            panelCanvas.TabIndex = 2;

            // lblSubtituloModulo
            lblSubtituloModulo.AutoSize = false;
            lblSubtituloModulo.Location = new System.Drawing.Point(25, 10);
            lblSubtituloModulo.Name = "lblSubtituloModulo";
            lblSubtituloModulo.Size = new System.Drawing.Size(400, 20);
            lblSubtituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            lblSubtituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblSubtituloModulo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblSubtituloModulo.TabIndex = 0;
            lblSubtituloModulo.Values.Text = "🏢 MÓDULO DE GERENCIA";

            // lblTituloModulo
            lblTituloModulo.AutoSize = false;
            lblTituloModulo.Location = new System.Drawing.Point(25, 28);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new System.Drawing.Size(500, 38);
            lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTituloModulo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloModulo.TabIndex = 1;
            lblTituloModulo.Values.Text = "Panel de Control Ejecutivo";

            // 
            // tableLayoutPanelKPIs
            // 
            tableLayoutPanelKPIs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelKPIs.ColumnCount = 3;
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.Controls.Add(panelKpiClientes, 0, 0);
            tableLayoutPanelKPIs.Controls.Add(panelKpiVentas, 1, 0);
            tableLayoutPanelKPIs.Controls.Add(panelKpiStock, 2, 0);
            tableLayoutPanelKPIs.Location = new System.Drawing.Point(25, 72);
            tableLayoutPanelKPIs.Name = "tableLayoutPanelKPIs";
            tableLayoutPanelKPIs.RowCount = 1;
            tableLayoutPanelKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelKPIs.Size = new System.Drawing.Size(1065, 82);
            tableLayoutPanelKPIs.TabIndex = 2;

            // panelKpiClientes
            panelKpiClientes.Controls.Add(lblKpiClientesTitulo);
            panelKpiClientes.Controls.Add(lblKpiClientesValor);
            panelKpiClientes.Controls.Add(lblKpiClientesBadge);
            panelKpiClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            panelKpiClientes.Location = new System.Drawing.Point(4, 4);
            panelKpiClientes.Margin = new System.Windows.Forms.Padding(4);
            panelKpiClientes.Name = "panelKpiClientes";
            panelKpiClientes.Size = new System.Drawing.Size(347, 74);
            panelKpiClientes.StateCommon.Color1 = System.Drawing.Color.White;
            panelKpiClientes.StateCommon.Color2 = System.Drawing.Color.White;

            lblKpiClientesTitulo.AutoSize = false;
            lblKpiClientesTitulo.Location = new System.Drawing.Point(10, 4);
            lblKpiClientesTitulo.Name = "lblKpiClientesTitulo";
            lblKpiClientesTitulo.Size = new System.Drawing.Size(330, 20);
            lblKpiClientesTitulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiClientesTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblKpiClientesTitulo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiClientesTitulo.Values.Text = "👥 CLIENTES REGISTRADOS";

            lblKpiClientesValor.AutoSize = false;
            lblKpiClientesValor.Location = new System.Drawing.Point(10, 24);
            lblKpiClientesValor.Name = "lblKpiClientesValor";
            lblKpiClientesValor.Size = new System.Drawing.Size(330, 26);
            lblKpiClientesValor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblKpiClientesValor.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiClientesValor.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiClientesValor.Values.Text = "148 Clientes Activos";

            lblKpiClientesBadge.AutoSize = false;
            lblKpiClientesBadge.Location = new System.Drawing.Point(10, 50);
            lblKpiClientesBadge.Name = "lblKpiClientesBadge";
            lblKpiClientesBadge.Size = new System.Drawing.Size(330, 20);
            lblKpiClientesBadge.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            lblKpiClientesBadge.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblKpiClientesBadge.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiClientesBadge.Values.Text = "🟢 Estado: OK  ";

            // panelKpiVentas
            panelKpiVentas.Controls.Add(lblKpiVentasTitulo);
            panelKpiVentas.Controls.Add(lblKpiVentasValor);
            panelKpiVentas.Controls.Add(lblKpiVentasBadge);
            panelKpiVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            panelKpiVentas.Location = new System.Drawing.Point(359, 4);
            panelKpiVentas.Margin = new System.Windows.Forms.Padding(4);
            panelKpiVentas.Name = "panelKpiVentas";
            panelKpiVentas.Size = new System.Drawing.Size(347, 74);
            panelKpiVentas.StateCommon.Color1 = System.Drawing.Color.White;
            panelKpiVentas.StateCommon.Color2 = System.Drawing.Color.White;

            lblKpiVentasTitulo.AutoSize = false;
            lblKpiVentasTitulo.Location = new System.Drawing.Point(10, 4);
            lblKpiVentasTitulo.Name = "lblKpiVentasTitulo";
            lblKpiVentasTitulo.Size = new System.Drawing.Size(330, 20);
            lblKpiVentasTitulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiVentasTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblKpiVentasTitulo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiVentasTitulo.Values.Text = "📈 VENTAS REGISTRADAS";

            lblKpiVentasValor.AutoSize = false;
            lblKpiVentasValor.Location = new System.Drawing.Point(10, 24);
            lblKpiVentasValor.Name = "lblKpiVentasValor";
            lblKpiVentasValor.Size = new System.Drawing.Size(330, 26);
            lblKpiVentasValor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblKpiVentasValor.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiVentasValor.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiVentasValor.Values.Text = "$ 4.850.000 Total del Mes";

            lblKpiVentasBadge.AutoSize = false;
            lblKpiVentasBadge.Location = new System.Drawing.Point(10, 50);
            lblKpiVentasBadge.Name = "lblKpiVentasBadge";
            lblKpiVentasBadge.Size = new System.Drawing.Size(330, 20);
            lblKpiVentasBadge.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            lblKpiVentasBadge.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblKpiVentasBadge.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiVentasBadge.Values.Text = "↗️ +12% vs mes anterior  ";

            // panelKpiStock
            panelKpiStock.Controls.Add(lblKpiStockTitulo);
            panelKpiStock.Controls.Add(lblKpiStockValor);
            panelKpiStock.Controls.Add(lblKpiStockBadge);
            panelKpiStock.Dock = System.Windows.Forms.DockStyle.Fill;
            panelKpiStock.Location = new System.Drawing.Point(714, 4);
            panelKpiStock.Margin = new System.Windows.Forms.Padding(4);
            panelKpiStock.Name = "panelKpiStock";
            panelKpiStock.Size = new System.Drawing.Size(347, 74);
            panelKpiStock.StateCommon.Color1 = System.Drawing.Color.White;
            panelKpiStock.StateCommon.Color2 = System.Drawing.Color.White;

            lblKpiStockTitulo.AutoSize = false;
            lblKpiStockTitulo.Location = new System.Drawing.Point(10, 4);
            lblKpiStockTitulo.Name = "lblKpiStockTitulo";
            lblKpiStockTitulo.Size = new System.Drawing.Size(330, 20);
            lblKpiStockTitulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblKpiStockTitulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            lblKpiStockTitulo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiStockTitulo.Values.Text = "⚠️ NOTEBOOKS EN STOCK CRÍTICO";

            lblKpiStockValor.AutoSize = false;
            lblKpiStockValor.Location = new System.Drawing.Point(10, 24);
            lblKpiStockValor.Name = "lblKpiStockValor";
            lblKpiStockValor.Size = new System.Drawing.Size(330, 26);
            lblKpiStockValor.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblKpiStockValor.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblKpiStockValor.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiStockValor.Values.Text = "3 Modelos con <= 2 Unidades";

            lblKpiStockBadge.AutoSize = false;
            lblKpiStockBadge.Location = new System.Drawing.Point(10, 50);
            lblKpiStockBadge.Name = "lblKpiStockBadge";
            lblKpiStockBadge.Size = new System.Drawing.Size(330, 20);
            lblKpiStockBadge.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(239, 68, 68);
            lblKpiStockBadge.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblKpiStockBadge.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblKpiStockBadge.Values.Text = "🔴 Requiere Atención  ";

            // lblSeccionFuncionalidades
            lblSeccionFuncionalidades.AutoSize = false;
            lblSeccionFuncionalidades.Location = new System.Drawing.Point(25, 160);
            lblSeccionFuncionalidades.Name = "lblSeccionFuncionalidades";
            lblSeccionFuncionalidades.Size = new System.Drawing.Size(700, 24);
            lblSeccionFuncionalidades.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(71, 85, 105);
            lblSeccionFuncionalidades.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            lblSeccionFuncionalidades.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblSeccionFuncionalidades.TabIndex = 3;
            lblSeccionFuncionalidades.Values.Text = "📌 FUNCIONALIDADES PRINCIPALES Y ACCESOS RÁPIDOS";

            // 
            // tableLayoutPanelCards
            // 
            tableLayoutPanelCards.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelCards.BackColor = System.Drawing.Color.Transparent;
            tableLayoutPanelCards.ColumnCount = 2;
            tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelCards.Controls.Add(panelCardClientes, 0, 0);
            tableLayoutPanelCards.Controls.Add(panelCardVentas, 1, 0);
            tableLayoutPanelCards.Controls.Add(panelCardStock, 0, 1);
            tableLayoutPanelCards.Controls.Add(panelCardHistorial, 1, 1);
            tableLayoutPanelCards.Controls.Add(panelCardRespaldo, 0, 2);
            tableLayoutPanelCards.SetColumnSpan(panelCardRespaldo, 2);
            tableLayoutPanelCards.Location = new System.Drawing.Point(25, 188);
            tableLayoutPanelCards.Name = "tableLayoutPanelCards";
            tableLayoutPanelCards.RowCount = 3;
            tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            tableLayoutPanelCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanelCards.Size = new System.Drawing.Size(1065, 457);
            tableLayoutPanelCards.TabIndex = 4;

            // 
            // panelCardClientes
            // 
            panelCardClientes.Controls.Add(lblTituloClientes);
            panelCardClientes.Controls.Add(lblDescClientes);
            panelCardClientes.Controls.Add(btnAccionClientes);
            panelCardClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardClientes.Location = new System.Drawing.Point(5, 5);
            panelCardClientes.Margin = new System.Windows.Forms.Padding(5);
            panelCardClientes.Name = "panelCardClientes";
            panelCardClientes.Size = new System.Drawing.Size(522, 161);
            panelCardClientes.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardClientes.StateCommon.Color2 = System.Drawing.Color.White;

            lblTituloClientes.AutoSize = false;
            lblTituloClientes.Location = new System.Drawing.Point(15, 8);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new System.Drawing.Size(480, 26);
            lblTituloClientes.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloClientes.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloClientes.Values.Text = "👥 GESTIÓN DE CLIENTES";

            lblDescClientes.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescClientes.AutoSize = false;
            lblDescClientes.Location = new System.Drawing.Point(15, 36);
            lblDescClientes.Name = "lblDescClientes";
            lblDescClientes.Size = new System.Drawing.Size(490, 55);
            lblDescClientes.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDescClientes.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescClientes.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            lblDescClientes.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            lblDescClientes.Values.Text = "Directorio integral de clientes, registro de datos fiscales (CUIT/IVA), teléfonos y direcciones.";

            btnAccionClientes.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAccionClientes.Location = new System.Drawing.Point(15, 105);
            btnAccionClientes.Name = "btnAccionClientes";
            btnAccionClientes.Size = new System.Drawing.Size(492, 42);
            btnAccionClientes.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionClientes.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionClientes.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnAccionClientes.StateCommon.Border.Rounding = 8F;
            btnAccionClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnAccionClientes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAccionClientes.Values.Text = "👥 Administrar Clientes (CRUD)";

            // 
            // panelCardVentas
            // 
            panelCardVentas.Controls.Add(lblTituloVentas);
            panelCardVentas.Controls.Add(lblDescVentas);
            panelCardVentas.Controls.Add(btnAccionVentas);
            panelCardVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardVentas.Location = new System.Drawing.Point(537, 5);
            panelCardVentas.Margin = new System.Windows.Forms.Padding(5);
            panelCardVentas.Name = "panelCardVentas";
            panelCardVentas.Size = new System.Drawing.Size(523, 161);
            panelCardVentas.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardVentas.StateCommon.Color2 = System.Drawing.Color.White;

            lblTituloVentas.AutoSize = false;
            lblTituloVentas.Location = new System.Drawing.Point(15, 8);
            lblTituloVentas.Name = "lblTituloVentas";
            lblTituloVentas.Size = new System.Drawing.Size(480, 26);
            lblTituloVentas.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloVentas.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloVentas.Values.Text = "📊 MÉTRICAS Y REPORTE DE VENTAS";

            lblDescVentas.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescVentas.AutoSize = false;
            lblDescVentas.Location = new System.Drawing.Point(15, 36);
            lblDescVentas.Name = "lblDescVentas";
            lblDescVentas.Size = new System.Drawing.Size(490, 55);
            lblDescVentas.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDescVentas.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescVentas.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            lblDescVentas.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            lblDescVentas.Values.Text = "Análisis estadístico de ingresos, gráficos comparativos y balance comercial por períodos.";

            btnAccionVentas.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAccionVentas.Location = new System.Drawing.Point(15, 105);
            btnAccionVentas.Name = "btnAccionVentas";
            btnAccionVentas.Size = new System.Drawing.Size(493, 42);
            btnAccionVentas.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionVentas.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionVentas.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnAccionVentas.StateCommon.Border.Rounding = 8F;
            btnAccionVentas.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnAccionVentas.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAccionVentas.Values.Text = "📈 Ver Reporte de Ventas";

            // 
            // panelCardStock
            // 
            panelCardStock.Controls.Add(lblTituloStock);
            panelCardStock.Controls.Add(lblDescStock);
            panelCardStock.Controls.Add(btnAccionStock);
            panelCardStock.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardStock.Location = new System.Drawing.Point(5, 176);
            panelCardStock.Margin = new System.Windows.Forms.Padding(5);
            panelCardStock.Name = "panelCardStock";
            panelCardStock.Size = new System.Drawing.Size(522, 161);
            panelCardStock.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardStock.StateCommon.Color2 = System.Drawing.Color.White;

            lblTituloStock.AutoSize = false;
            lblTituloStock.Location = new System.Drawing.Point(15, 8);
            lblTituloStock.Name = "lblTituloStock";
            lblTituloStock.Size = new System.Drawing.Size(480, 26);
            lblTituloStock.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloStock.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloStock.Values.Text = "💻 ESTADO DE INVENTARIO Y STOCK";

            lblDescStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescStock.AutoSize = false;
            lblDescStock.Location = new System.Drawing.Point(15, 36);
            lblDescStock.Name = "lblDescStock";
            lblDescStock.Size = new System.Drawing.Size(490, 55);
            lblDescStock.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDescStock.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescStock.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            lblDescStock.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            lblDescStock.Values.Text = "Auditoría de stock en tiempo real, alertas de unidades agotadas y valorización del catálogo.";

            btnAccionStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAccionStock.Location = new System.Drawing.Point(15, 105);
            btnAccionStock.Name = "btnAccionStock";
            btnAccionStock.Size = new System.Drawing.Size(492, 42);
            btnAccionStock.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            btnAccionStock.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            btnAccionStock.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnAccionStock.StateCommon.Border.Rounding = 8F;
            btnAccionStock.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnAccionStock.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAccionStock.Values.Text = "📦 Ver Reporte de Stock";

            // 
            // panelCardHistorial
            // 
            panelCardHistorial.Controls.Add(lblTituloHistorial);
            panelCardHistorial.Controls.Add(lblDescHistorial);
            panelCardHistorial.Controls.Add(btnAccionHistorial);
            panelCardHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardHistorial.Location = new System.Drawing.Point(537, 176);
            panelCardHistorial.Margin = new System.Windows.Forms.Padding(5);
            panelCardHistorial.Name = "panelCardHistorial";
            panelCardHistorial.Size = new System.Drawing.Size(523, 161);
            panelCardHistorial.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardHistorial.StateCommon.Color2 = System.Drawing.Color.White;

            lblTituloHistorial.AutoSize = false;
            lblTituloHistorial.Location = new System.Drawing.Point(15, 8);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new System.Drawing.Size(480, 26);
            lblTituloHistorial.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloHistorial.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloHistorial.Values.Text = "📄 HISTORIAL DE VENTAS Y AUDITORÍA";

            lblDescHistorial.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescHistorial.AutoSize = false;
            lblDescHistorial.Location = new System.Drawing.Point(15, 36);
            lblDescHistorial.Name = "lblDescHistorial";
            lblDescHistorial.Size = new System.Drawing.Size(490, 55);
            lblDescHistorial.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDescHistorial.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescHistorial.StateCommon.ShortText.MultiLine = Krypton.Toolkit.InheritBool.True;
            lblDescHistorial.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Word;
            lblDescHistorial.Values.Text = "Consulta de transacciones por vendedor/fechas y reimpresión de comprobantes en formato PDF.";

            btnAccionHistorial.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAccionHistorial.Location = new System.Drawing.Point(15, 105);
            btnAccionHistorial.Name = "btnAccionHistorial";
            btnAccionHistorial.Size = new System.Drawing.Size(493, 42);
            btnAccionHistorial.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionHistorial.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionHistorial.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnAccionHistorial.StateCommon.Border.Rounding = 8F;
            btnAccionHistorial.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnAccionHistorial.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAccionHistorial.Values.Text = "📜 Consultar Historial";

            // 
            // panelCardRespaldo
            // 
            panelCardRespaldo.Controls.Add(lblTituloRespaldo);
            panelCardRespaldo.Controls.Add(lblDescRespaldo);
            panelCardRespaldo.Controls.Add(btnAccionRespaldo);
            panelCardRespaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardRespaldo.Location = new System.Drawing.Point(5, 347);
            panelCardRespaldo.Margin = new System.Windows.Forms.Padding(5);
            panelCardRespaldo.Name = "panelCardRespaldo";
            panelCardRespaldo.Size = new System.Drawing.Size(1055, 105);
            panelCardRespaldo.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardRespaldo.StateCommon.Color2 = System.Drawing.Color.White;

            lblTituloRespaldo.AutoSize = false;
            lblTituloRespaldo.Location = new System.Drawing.Point(15, 6);
            lblTituloRespaldo.Name = "lblTituloRespaldo";
            lblTituloRespaldo.Size = new System.Drawing.Size(600, 26);
            lblTituloRespaldo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblTituloRespaldo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblTituloRespaldo.Values.Text = "💾 RESPALDO Y COPIAS DE SEGURIDAD";

            lblDescRespaldo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDescRespaldo.AutoSize = false;
            lblDescRespaldo.Location = new System.Drawing.Point(15, 30);
            lblDescRespaldo.Name = "lblDescRespaldo";
            lblDescRespaldo.Size = new System.Drawing.Size(1020, 24);
            lblDescRespaldo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblDescRespaldo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblDescRespaldo.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Hide;
            lblDescRespaldo.Values.Text = "Gestión de copias de seguridad de la base de datos MariaDB en unidades locales/USB y sincronización automática en la nube con Google Drive.";

            btnAccionRespaldo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnAccionRespaldo.Location = new System.Drawing.Point(15, 56);
            btnAccionRespaldo.Name = "btnAccionRespaldo";
            btnAccionRespaldo.Size = new System.Drawing.Size(1025, 40);
            btnAccionRespaldo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionRespaldo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnAccionRespaldo.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnAccionRespaldo.StateCommon.Border.Rounding = 8F;
            btnAccionRespaldo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnAccionRespaldo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnAccionRespaldo.Values.Text = "☁️ Gestionar Respaldos y Copias de BD";

            // 
            // FormCeoPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1360, 720);
            Controls.Add(panelCanvas);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormCeoPrincipal";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Panel Ejecutivo (CEO)";

            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelSidebar).EndInit();
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCanvas).EndInit();
            panelCanvas.ResumeLayout(false);
            tableLayoutPanelKPIs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelKpiClientes).EndInit();
            panelKpiClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelKpiVentas).EndInit();
            panelKpiVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelKpiStock).EndInit();
            panelKpiStock.ResumeLayout(false);
            tableLayoutPanelCards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardClientes).EndInit();
            panelCardClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardVentas).EndInit();
            panelCardVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardStock).EndInit();
            panelCardStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardHistorial).EndInit();
            panelCardHistorial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardRespaldo).EndInit();
            panelCardRespaldo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblFechaHoraHeader;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;

        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavDashboard;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonButton btnNavReporteVentas;
        private Krypton.Toolkit.KryptonButton btnNavReporteStock;
        private Krypton.Toolkit.KryptonButton btnNavHistorialVentas;
        private Krypton.Toolkit.KryptonButton btnNavRespaldo;
        private Krypton.Toolkit.KryptonLabel lblUsuarioSidebar;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;

        private Krypton.Toolkit.KryptonPanel panelCanvas;
        private Krypton.Toolkit.KryptonLabel lblSubtituloModulo;
        private Krypton.Toolkit.KryptonLabel lblTituloModulo;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKPIs;
        private Krypton.Toolkit.KryptonPanel panelKpiClientes;
        private Krypton.Toolkit.KryptonLabel lblKpiClientesTitulo;
        private Krypton.Toolkit.KryptonLabel lblKpiClientesValor;
        private Krypton.Toolkit.KryptonLabel lblKpiClientesBadge;

        private Krypton.Toolkit.KryptonPanel panelKpiVentas;
        private Krypton.Toolkit.KryptonLabel lblKpiVentasTitulo;
        private Krypton.Toolkit.KryptonLabel lblKpiVentasValor;
        private Krypton.Toolkit.KryptonLabel lblKpiVentasBadge;

        private Krypton.Toolkit.KryptonPanel panelKpiStock;
        private Krypton.Toolkit.KryptonLabel lblKpiStockTitulo;
        private Krypton.Toolkit.KryptonLabel lblKpiStockValor;
        private Krypton.Toolkit.KryptonLabel lblKpiStockBadge;

        private Krypton.Toolkit.KryptonLabel lblSeccionFuncionalidades;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCards;
        private Krypton.Toolkit.KryptonPanel panelCardClientes;
        private Krypton.Toolkit.KryptonLabel lblTituloClientes;
        private Krypton.Toolkit.KryptonLabel lblDescClientes;
        private Krypton.Toolkit.KryptonButton btnAccionClientes;

        private Krypton.Toolkit.KryptonPanel panelCardVentas;
        private Krypton.Toolkit.KryptonLabel lblTituloVentas;
        private Krypton.Toolkit.KryptonLabel lblDescVentas;
        private Krypton.Toolkit.KryptonButton btnAccionVentas;

        private Krypton.Toolkit.KryptonPanel panelCardStock;
        private Krypton.Toolkit.KryptonLabel lblTituloStock;
        private Krypton.Toolkit.KryptonLabel lblDescStock;
        private Krypton.Toolkit.KryptonButton btnAccionStock;

        private Krypton.Toolkit.KryptonPanel panelCardHistorial;
        private Krypton.Toolkit.KryptonLabel lblTituloHistorial;
        private Krypton.Toolkit.KryptonLabel lblDescHistorial;
        private Krypton.Toolkit.KryptonButton btnAccionHistorial;

        private Krypton.Toolkit.KryptonPanel panelCardRespaldo;
        private Krypton.Toolkit.KryptonLabel lblTituloRespaldo;
        private Krypton.Toolkit.KryptonLabel lblDescRespaldo;
        private Krypton.Toolkit.KryptonButton btnAccionRespaldo;
    }
}