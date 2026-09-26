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
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            lblTituloApp = new Krypton.Toolkit.KryptonLabel();
            lblStatusDB = new Krypton.Toolkit.KryptonLabel();
            panelSidebar = new Krypton.Toolkit.KryptonPanel();
            btnNavNuevaVenta = new Krypton.Toolkit.KryptonButton();
            btnNavClientes = new Krypton.Toolkit.KryptonButton();
            btnNavBuscarNotebooks = new Krypton.Toolkit.KryptonButton();
            lblUsuarioSidebar = new Krypton.Toolkit.KryptonLabel();
            btnCerrarSesion = new Krypton.Toolkit.KryptonButton();
            panelCanvas = new Krypton.Toolkit.KryptonPanel();
            lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanelPOS = new TableLayoutPanel();
            panelCatalogo = new Krypton.Toolkit.KryptonPanel();
            lblTituloCatalogo = new Krypton.Toolkit.KryptonLabel();
            txtBuscarNotebook = new Krypton.Toolkit.KryptonTextBox();
            dgvCatalogo = new Krypton.Toolkit.KryptonDataGridView();
            panelCarrito = new Krypton.Toolkit.KryptonPanel();
            lblClienteSeleccionado = new Krypton.Toolkit.KryptonLabel();
            lblResumenCompra = new Krypton.Toolkit.KryptonLabel();
            lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            lblMontoTotal = new Krypton.Toolkit.KryptonLabel();
            btnProcesarVenta = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelHeader).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).BeginInit();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).BeginInit();
            panelCanvas.SuspendLayout();
            tableLayoutPanelPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCatalogo).BeginInit();
            panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelCarrito).BeginInit();
            panelCarrito.SuspendLayout();
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
            lblTituloApp.Values.Text = "LaptopDeel POS";
            // 
            // lblStatusDB
            // 
            lblStatusDB.Dock = DockStyle.Right;
            lblStatusDB.Location = new Point(1232, 0);
            lblStatusDB.Name = "lblStatusDB";
            lblStatusDB.Size = new Size(128, 60);
            lblStatusDB.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);
            lblStatusDB.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatusDB.TabIndex = 2;
            lblStatusDB.Values.Text = "●DB: Conectado";
            // 
            // panelSidebar
            // 
            panelSidebar.Controls.Add(btnNavNuevaVenta);
            panelSidebar.Controls.Add(btnNavClientes);
            panelSidebar.Controls.Add(btnNavBuscarNotebooks);
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
            // btnNavNuevaVenta
            // 
            btnNavNuevaVenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavNuevaVenta.Location = new Point(15, 30);
            btnNavNuevaVenta.Name = "btnNavNuevaVenta";
            btnNavNuevaVenta.Size = new Size(210, 45);
            btnNavNuevaVenta.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnNavNuevaVenta.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnNavNuevaVenta.StateCommon.Content.ShortText.Color1 = Color.White;
            btnNavNuevaVenta.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavNuevaVenta.TabIndex = 0;
            btnNavNuevaVenta.Values.DropDownArrowColor = Color.Empty;
            btnNavNuevaVenta.Values.Text = "\U0001f6d2 Nueva Venta";
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
            btnNavClientes.Values.Text = "👥 Clientes";
            btnNavClientes.Click += btnNavClientes_Click;
            // 
            // btnNavBuscarNotebooks
            // 
            btnNavBuscarNotebooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavBuscarNotebooks.Location = new Point(15, 140);
            btnNavBuscarNotebooks.Name = "btnNavBuscarNotebooks";
            btnNavBuscarNotebooks.Size = new Size(210, 45);
            btnNavBuscarNotebooks.StateCommon.Back.Color1 = Color.Transparent;
            btnNavBuscarNotebooks.StateCommon.Back.Color2 = Color.Transparent;
            btnNavBuscarNotebooks.StateCommon.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnNavBuscarNotebooks.TabIndex = 2;
            btnNavBuscarNotebooks.Values.DropDownArrowColor = Color.Empty;
            btnNavBuscarNotebooks.Values.Text = "🔍 Buscar Notebooks";
            // 
            // lblUsuarioSidebar
            // 
            lblUsuarioSidebar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUsuarioSidebar.Location = new Point(15, 544);
            lblUsuarioSidebar.Name = "lblUsuarioSidebar";
            lblUsuarioSidebar.Size = new Size(158, 27);
            lblUsuarioSidebar.StateCommon.ShortText.Color1 = Color.White;
            lblUsuarioSidebar.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioSidebar.TabIndex = 3;
            lblUsuarioSidebar.Values.Text = "👤 Guillermo (POS)";
          
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
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Values.DropDownArrowColor = Color.Empty;
            btnCerrarSesion.Values.Text = "🔴 Cerrar Sesión";
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelCanvas
            // 
            panelCanvas.Controls.Add(lblSubtituloModulo);
            panelCanvas.Controls.Add(lblTituloModulo);
            panelCanvas.Controls.Add(tableLayoutPanelPOS);
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
            lblSubtituloModulo.Size = new Size(221, 24);
            lblSubtituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblSubtituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubtituloModulo.TabIndex = 0;
            lblSubtituloModulo.Values.Text = "PROCESO DE VENTA ACTIVO";
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(30, 40);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(499, 46);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 1;
            lblTituloModulo.Values.Text = "Módulo de Punto de Venta (POS)";
            // 
            // tableLayoutPanelPOS
            // 
            tableLayoutPanelPOS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelPOS.BackColor = Color.Transparent;
            tableLayoutPanelPOS.ColumnCount = 2;
            tableLayoutPanelPOS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            tableLayoutPanelPOS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelPOS.Controls.Add(panelCatalogo, 0, 0);
            tableLayoutPanelPOS.Controls.Add(panelCarrito, 1, 0);
            tableLayoutPanelPOS.Location = new Point(25, 85);
            tableLayoutPanelPOS.Name = "tableLayoutPanelPOS";
            tableLayoutPanelPOS.RowCount = 1;
            tableLayoutPanelPOS.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPOS.Size = new Size(1070, 550);
            tableLayoutPanelPOS.TabIndex = 1;
            // 
            // panelCatalogo
            // 
            panelCatalogo.Controls.Add(lblTituloCatalogo);
            panelCatalogo.Controls.Add(txtBuscarNotebook);
            panelCatalogo.Controls.Add(dgvCatalogo);
            panelCatalogo.Dock = DockStyle.Fill;
            panelCatalogo.Location = new Point(5, 5);
            panelCatalogo.Margin = new Padding(5);
            panelCatalogo.Name = "panelCatalogo";
            panelCatalogo.Size = new Size(685, 540);
            panelCatalogo.StateCommon.Color1 = Color.White;
            panelCatalogo.StateCommon.Color2 = Color.White;
            panelCatalogo.TabIndex = 0;
            // 
            // lblTituloCatalogo
            // 
            lblTituloCatalogo.Location = new Point(20, 15);
            lblTituloCatalogo.Name = "lblTituloCatalogo";
            lblTituloCatalogo.Size = new Size(278, 24);
            lblTituloCatalogo.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblTituloCatalogo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloCatalogo.TabIndex = 0;
            lblTituloCatalogo.Values.Text = "CATÁLOGO RÁPIDO DE NOTEBOOKS";
            // 
            // txtBuscarNotebook
            // 
            txtBuscarNotebook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarNotebook.Location = new Point(20, 42);
            txtBuscarNotebook.Name = "txtBuscarNotebook";
            txtBuscarNotebook.Size = new Size(645, 33);
            txtBuscarNotebook.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtBuscarNotebook.StateCommon.Border.Rounding = 8F;
            txtBuscarNotebook.TabIndex = 1;
            txtBuscarNotebook.Text = "🔍 Buscar por marca, modelo o especificaciones...";
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatalogo.BorderStyle = BorderStyle.None;
            dgvCatalogo.ColumnHeadersHeight = 36;
            dgvCatalogo.Location = new Point(20, 90);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersWidth = 51;
            dgvCatalogo.Size = new Size(645, 430);
            dgvCatalogo.StateCommon.Background.Color1 = Color.White;
            dgvCatalogo.StateCommon.Background.Color2 = Color.White;
            dgvCatalogo.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvCatalogo.TabIndex = 2;
            // 
            // panelCarrito
            // 
            panelCarrito.Controls.Add(lblClienteSeleccionado);
            panelCarrito.Controls.Add(lblResumenCompra);
            panelCarrito.Controls.Add(lblTotalPagar);
            panelCarrito.Controls.Add(lblMontoTotal);
            panelCarrito.Controls.Add(btnProcesarVenta);
            panelCarrito.Dock = DockStyle.Fill;
            panelCarrito.Location = new Point(700, 5);
            panelCarrito.Margin = new Padding(5);
            panelCarrito.Name = "panelCarrito";
            panelCarrito.Size = new Size(365, 540);
            panelCarrito.StateCommon.Color1 = Color.White;
            panelCarrito.StateCommon.Color2 = Color.White;
            panelCarrito.TabIndex = 1;
            // 
            // lblClienteSeleccionado
            // 
            lblClienteSeleccionado.Location = new Point(20, 15);
            lblClienteSeleccionado.Name = "lblClienteSeleccionado";
            lblClienteSeleccionado.Size = new Size(273, 27);
            lblClienteSeleccionado.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblClienteSeleccionado.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClienteSeleccionado.TabIndex = 0;
            lblClienteSeleccionado.Values.Text = "👤 Juan Pérez - DNI 19.345.821-K";
            // 
            // lblResumenCompra
            // 
            lblResumenCompra.Location = new Point(20, 55);
            lblResumenCompra.Name = "lblResumenCompra";
            lblResumenCompra.Size = new Size(268, 24);
            lblResumenCompra.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblResumenCompra.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResumenCompra.TabIndex = 1;
            lblResumenCompra.Values.Text = "COMPUTADORAS SELECCIONADAS";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalPagar.Location = new Point(20, 414);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(197, 27);
            lblTotalPagar.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblTotalPagar.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalPagar.TabIndex = 2;
            lblTotalPagar.Values.Text = "SUBTOTAL ESTIMADO:";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblMontoTotal.Location = new Point(-113, 333);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(194, 51);
            lblMontoTotal.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblMontoTotal.StateCommon.ShortText.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMontoTotal.TabIndex = 3;
            lblMontoTotal.Values.Text = "$1.849.800";
            // 
            // btnProcesarVenta
            // 
            btnProcesarVenta.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnProcesarVenta.Location = new Point(20, 465);
            btnProcesarVenta.Name = "btnProcesarVenta";
            btnProcesarVenta.Size = new Size(325, 50);
            btnProcesarVenta.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnProcesarVenta.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnProcesarVenta.StateCommon.Content.ShortText.Color1 = Color.White;
            btnProcesarVenta.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProcesarVenta.TabIndex = 4;
            btnProcesarVenta.Values.DropDownArrowColor = Color.Empty;
            btnProcesarVenta.Values.Text = "📄 Pasar a Facturación";
            btnProcesarVenta.Click += btnProcesarVenta_Click;
            // 
            // FormVendedorPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 720);
            Controls.Add(panelCanvas);
            Controls.Add(panelSidebar);
            Controls.Add(panelHeader);
            Name = "FormVendedorPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopDeel - Selección y Punto de Venta (POS)";
            ((System.ComponentModel.ISupportInitialize)panelHeader).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelSidebar).EndInit();
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCanvas).EndInit();
            panelCanvas.ResumeLayout(false);
            panelCanvas.PerformLayout();
            tableLayoutPanelPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCatalogo).EndInit();
            panelCatalogo.ResumeLayout(false);
            panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelCarrito).EndInit();
            panelCarrito.ResumeLayout(false);
            panelCarrito.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel lblTituloApp;
        private Krypton.Toolkit.KryptonLabel lblStatusDB;
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