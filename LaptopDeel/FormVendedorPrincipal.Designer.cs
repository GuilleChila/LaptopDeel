namespace LaptopDeel
{
    partial class FormVendedorPrincipal
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
            this.lblVendedorHeader = new Krypton.Toolkit.KryptonLabel();
            this.lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            this.lblFechaHora = new Krypton.Toolkit.KryptonLabel();
            this.panelSidebar = new Krypton.Toolkit.KryptonPanel();
            this.btnNavNuevaVenta = new Krypton.Toolkit.KryptonButton();
            this.btnNavClientes = new Krypton.Toolkit.KryptonButton();
            this.btnNavBuscarNotebooks = new Krypton.Toolkit.KryptonButton();
            this.lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            this.btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            this.panelCanvas = new Krypton.Toolkit.KryptonPanel();
            this.lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.tableLayoutPanelPOS = new System.Windows.Forms.TableLayoutPanel();
            this.panelCatalogo = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloCatalogo = new Krypton.Toolkit.KryptonLabel();
            this.txtBuscarNotebook = new Krypton.Toolkit.KryptonTextBox();
            this.dgvCatalogo = new Krypton.Toolkit.KryptonDataGridView();
            this.panelCarrito = new Krypton.Toolkit.KryptonPanel();
            this.lblClienteSeleccionado = new Krypton.Toolkit.KryptonLabel();
            this.lblResumenCompra = new Krypton.Toolkit.KryptonLabel();
            this.lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            this.lblMontoTotal = new Krypton.Toolkit.KryptonLabel();
            this.btnProcesarVenta = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).BeginInit();
            this.panelCanvas.SuspendLayout();
            this.tableLayoutPanelPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCatalogo)).BeginInit();
            this.panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCarrito)).BeginInit();
            this.panelCarrito.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelHeader (Encabezado Superior #1E293B)
            // 
            this.panelHeader.Controls.Add(this.lblTituloApp);
            this.panelHeader.Controls.Add(this.lblVendedorHeader);
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
            this.lblTituloApp.Size = new System.Drawing.Size(160, 30);
            this.lblTituloApp.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblTituloApp.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.Values.Text = "LaptopDeel POS";

            // lblVendedorHeader
            this.lblVendedorHeader.Location = new System.Drawing.Point(190, 20);
            this.lblVendedorHeader.Name = "lblVendedorHeader";
            this.lblVendedorHeader.Size = new System.Drawing.Size(200, 20);
            this.lblVendedorHeader.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblVendedorHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVendedorHeader.Values.Text = "|   Vendedor: Guillermo Guerrero";

            // lblStatusDB (Anclado a la Derecha)
            this.lblStatusDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatusDB.Location = new System.Drawing.Point(1020, 20);
            this.lblStatusDB.Name = "lblStatusDB";
            this.lblStatusDB.Size = new System.Drawing.Size(150, 20);
            this.lblStatusDB.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblStatusDB.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatusDB.Values.Text = "● Status DB: Conectado";

            // lblFechaHora (Anclado a la Derecha)
            this.lblFechaHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFechaHora.Location = new System.Drawing.Point(1180, 20);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(160, 20);
            this.lblFechaHora.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblFechaHora.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFechaHora.Values.Text = "18 Octubre 2026 — 14:35";

            // 
            // panelSidebar (Menú Lateral Izquierdo)
            // 
            this.panelSidebar.Controls.Add(this.btnNavNuevaVenta);
            this.panelSidebar.Controls.Add(this.btnNavClientes);
            this.panelSidebar.Controls.Add(this.btnNavBuscarNotebooks);
            this.panelSidebar.Controls.Add(this.lblUsuarioSidebar);
            this.panelSidebar.Controls.Add(this.btnCerrarSesion);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 60);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(240, 660);
            this.panelSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.StateCommon.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.TabIndex = 1;

            // btnNavNuevaVenta (Sólido sin degradados)
            this.btnNavNuevaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavNuevaVenta.Location = new System.Drawing.Point(15, 30);
            this.btnNavNuevaVenta.Name = "btnNavNuevaVenta";
            this.btnNavNuevaVenta.Size = new System.Drawing.Size(210, 45);
            this.btnNavNuevaVenta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavNuevaVenta.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnNavNuevaVenta.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnNavNuevaVenta.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNavNuevaVenta.Values.Text = "🛒 Nueva Venta";

            // btnNavClientes
            this.btnNavClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavClientes.Location = new System.Drawing.Point(15, 85);
            this.btnNavClientes.Name = "btnNavClientes";
            this.btnNavClientes.Size = new System.Drawing.Size(210, 45);
            this.btnNavClientes.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavClientes.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavClientes.Values.Text = "👥 Clientes";

            // btnNavBuscarNotebooks
            this.btnNavBuscarNotebooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNavBuscarNotebooks.Location = new System.Drawing.Point(15, 140);
            this.btnNavBuscarNotebooks.Name = "btnNavBuscarNotebooks";
            this.btnNavBuscarNotebooks.Size = new System.Drawing.Size(210, 45);
            this.btnNavBuscarNotebooks.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnNavBuscarNotebooks.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnNavBuscarNotebooks.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnNavBuscarNotebooks.Values.Text = "🔍 Buscar Notebooks";

            // lblUsuarioSidebar (Pie del Menú Lateral)
            this.lblUsuarioSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioSidebar.Location = new System.Drawing.Point(15, 550);
            this.lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            this.lblUsuarioSidebar.Size = new System.Drawing.Size(210, 25);
            this.lblUsuarioSidebar.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblUsuarioSidebar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioSidebar.Values.Text = "👤 Guillermo (POS)";

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
            // panelCanvas (Lienzo Central #F8FAFC)
            // 
            this.panelCanvas.Controls.Add(this.lblSubtituloModulo);
            this.panelCanvas.Controls.Add(this.lblTituloModulo);
            this.panelCanvas.Controls.Add(this.tableLayoutPanelPOS);
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
            this.lblSubtituloModulo.Values.Text = "PROCESO DE VENTA ACTIVO";

            // lblTituloModulo
            this.lblTituloModulo.Location = new System.Drawing.Point(30, 40);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(420, 35);
            this.lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.Values.Text = "Módulo de Punto de Venta (POS)";

            // 
            // tableLayoutPanelPOS (65% Catálogo - 35% Resumen Elección)
            // 
            this.tableLayoutPanelPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelPOS.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelPOS.ColumnCount = 2;
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelPOS.Controls.Add(this.panelCatalogo, 0, 0);
            this.tableLayoutPanelPOS.Controls.Add(this.panelCarrito, 1, 0);
            this.tableLayoutPanelPOS.Location = new System.Drawing.Point(25, 85);
            this.tableLayoutPanelPOS.Name = "tableLayoutPanelPOS";
            this.tableLayoutPanelPOS.RowCount = 1;
            this.tableLayoutPanelPOS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPOS.Size = new System.Drawing.Size(1070, 550);
            this.tableLayoutPanelPOS.TabIndex = 1;

            // 
            // panelCatalogo (Consulta de Computadoras)
            // 
            this.panelCatalogo.Controls.Add(this.lblTituloCatalogo);
            this.panelCatalogo.Controls.Add(this.txtBuscarNotebook);
            this.panelCatalogo.Controls.Add(this.dgvCatalogo);
            this.panelCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatalogo.Location = new System.Drawing.Point(5, 5);
            this.panelCatalogo.Margin = new System.Windows.Forms.Padding(5);
            this.panelCatalogo.Name = "panelCatalogo";
            this.panelCatalogo.Size = new System.Drawing.Size(685, 540);
            this.panelCatalogo.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCatalogo.StateCommon.Color2 = System.Drawing.Color.White;

            // lblTituloCatalogo
            this.lblTituloCatalogo.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCatalogo.Name = "lblTituloCatalogo";
            this.lblTituloCatalogo.Size = new System.Drawing.Size(240, 20);
            this.lblTituloCatalogo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTituloCatalogo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCatalogo.Values.Text = "CATÁLOGO RÁPIDO DE NOTEBOOKS";

            // txtBuscarNotebook
            this.txtBuscarNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNotebook.Location = new System.Drawing.Point(20, 42);
            this.txtBuscarNotebook.Name = "txtBuscarNotebook";
            this.txtBuscarNotebook.Size = new System.Drawing.Size(645, 35);
            this.txtBuscarNotebook.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtBuscarNotebook.StateCommon.Border.Rounding = 8F;
            this.txtBuscarNotebook.Text = "🔍 Buscar por marca, modelo o especificaciones...";

            // dgvCatalogo
            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.Location = new System.Drawing.Point(20, 90);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.Size = new System.Drawing.Size(645, 430);
            this.dgvCatalogo.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.dgvCatalogo.StateCommon.Background.Color2 = System.Drawing.Color.White;

            // 
            // panelCarrito (Resumen de Computadoras Confirmadas por el Cliente)
            // 
            this.panelCarrito.Controls.Add(this.lblClienteSeleccionado);
            this.panelCarrito.Controls.Add(this.lblResumenCompra);
            this.panelCarrito.Controls.Add(this.lblTotalPagar);
            this.panelCarrito.Controls.Add(this.lblMontoTotal);
            this.panelCarrito.Controls.Add(this.btnProcesarVenta);
            this.panelCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarrito.Location = new System.Drawing.Point(700, 5);
            this.panelCarrito.Margin = new System.Windows.Forms.Padding(5);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(365, 540);
            this.panelCarrito.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelCarrito.StateCommon.Color2 = System.Drawing.Color.White;

            // lblClienteSeleccionado
            this.lblClienteSeleccionado.Location = new System.Drawing.Point(20, 15);
            this.lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            this.lblClienteSeleccionado.Size = new System.Drawing.Size(320, 25);
            this.lblClienteSeleccionado.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblClienteSeleccionado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblClienteSeleccionado.Values.Text = "👤 Juan Pérez - DNI 19.345.821-K";

            // lblResumenCompra (Aclaración: Resumen de Selección)
            this.lblResumenCompra.Location = new System.Drawing.Point(20, 55);
            this.lblResumenCompra.Name = "lblResumenCompra";
            this.lblResumenCompra.Size = new System.Drawing.Size(260, 20);
            this.lblResumenCompra.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblResumenCompra.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumenCompra.Values.Text = "COMPUTADORAS SELECCIONADAS";

            // lblTotalPagar
            this.lblTotalPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalPagar.Location = new System.Drawing.Point(20, 420);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(120, 25);
            this.lblTotalPagar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTotalPagar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.Values.Text = "SUBTOTAL ESTIMADO:";

            // lblMontoTotal
            this.lblMontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotal.Location = new System.Drawing.Point(180, 412);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(160, 40);
            this.lblMontoTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblMontoTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotal.Values.Text = "$1.849.800";

            // btnProcesarVenta (Puente hacia Facturación)
            this.btnProcesarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcesarVenta.Location = new System.Drawing.Point(20, 465);
            this.btnProcesarVenta.Name = "btnProcesarVenta";
            this.btnProcesarVenta.Size = new System.Drawing.Size(325, 50);
            this.btnProcesarVenta.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnProcesarVenta.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnProcesarVenta.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnProcesarVenta.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProcesarVenta.Values.Text = "📄 Pasar a Facturación";
            this.btnProcesarVenta.Click += new System.EventHandler(this.btnProcesarVenta_Click);

            // 
            // FormVendedorPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelHeader);
            this.Name = "FormVendedorPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaptopDeel - Selección y Punto de Venta (POS)";

            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCanvas)).EndInit();
            this.panelCanvas.ResumeLayout(false);
            this.panelCanvas.PerformLayout();
            this.tableLayoutPanelPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCatalogo)).EndInit();
            this.panelCatalogo.ResumeLayout(false);
            this.panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCarrito)).EndInit();
            this.panelCarrito.ResumeLayout(false);
            this.panelCarrito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblVendedorHeader;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
        private Krypton.Toolkit.KryptonLabel lblFechaHora;
        private Krypton.Toolkit.KryptonPanel panelSidebar;
        private Krypton.Toolkit.KryptonButton btnNavNuevaVenta;
        private Krypton.Toolkit.KryptonButton btnNavClientes;
        private Krypton.Toolkit.KryptonButton btnNavBuscarNotebooks;
        private Krypton.Toolkit.KryptonLabel lblUsuarioSidebar;
        private Krypton.Toolkit.KryptonButton btnCerrarSesion;
        private Krypton.Toolkit.KryptonPanel panelCanvas;
        private Krypton.Toolkit.KryptonLabel lblSubtituloModulo;
        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPOS;
        private Krypton.Toolkit.KryptonPanel panelCatalogo;
        private Krypton.Toolkit.KryptonLabel lblTituloCatalogo;
        private Krypton.Toolkit.KryptonTextBox txtBuscarNotebook;
        private Krypton.Toolkit.KryptonDataGridView dgvCatalogo;
        private Krypton.Toolkit.KryptonPanel panelCarrito;
        private Krypton.Toolkit.KryptonLabel lblClienteSeleccionado;
        private Krypton.Toolkit.KryptonLabel lblResumenCompra;
        private Krypton.Toolkit.KryptonLabel lblTotalPagar;
        private Krypton.Toolkit.KryptonLabel lblMontoTotal;
        private Krypton.Toolkit.KryptonButton btnProcesarVenta;
    }
}