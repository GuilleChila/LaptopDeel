namespace LaptopDeel
{
    partial class ControlVentas
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
            tableLayoutPanelPOS = new TableLayoutPanel();
            panelCatalogo = new Krypton.Toolkit.KryptonPanel();
            lblTituloCatalogo = new Krypton.Toolkit.KryptonLabel();
            txtBuscarNotebook = new Krypton.Toolkit.KryptonTextBox();
            dgvCatalogo = new Krypton.Toolkit.KryptonDataGridView();
            panelCarrito = new Krypton.Toolkit.KryptonPanel();
            lblTituloCliente = new Krypton.Toolkit.KryptonLabel();
            txtDniCliente = new Krypton.Toolkit.KryptonTextBox();
            btnBuscarCliente = new Krypton.Toolkit.KryptonButton();
            flowClienteInfo = new FlowLayoutPanel();
            lblClienteNombre = new Krypton.Toolkit.KryptonLabel();
            lblClienteDni = new Krypton.Toolkit.KryptonLabel();
            btnRedirigirCrudCliente = new Krypton.Toolkit.KryptonButton();
            lblResumenCompra = new Krypton.Toolkit.KryptonLabel();
            dgvCarrito = new Krypton.Toolkit.KryptonDataGridView();
            tblSubtotal = new TableLayoutPanel();
            lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            lblSubtotalEstimado = new Krypton.Toolkit.KryptonLabel();
            btnPasarAFacturacion = new Krypton.Toolkit.KryptonButton();
            tableLayoutPanelPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCatalogo).BeginInit();
            panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelCarrito).BeginInit();
            panelCarrito.SuspendLayout();
            flowClienteInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            tblSubtotal.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanelPOS
            // 
            tableLayoutPanelPOS.ColumnCount = 2;
            tableLayoutPanelPOS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63F));
            tableLayoutPanelPOS.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37F));
            tableLayoutPanelPOS.Controls.Add(panelCatalogo, 0, 0);
            tableLayoutPanelPOS.Controls.Add(panelCarrito, 1, 0);
            tableLayoutPanelPOS.Dock = DockStyle.Fill;
            tableLayoutPanelPOS.Location = new Point(0, 0);
            tableLayoutPanelPOS.Name = "tableLayoutPanelPOS";
            tableLayoutPanelPOS.RowCount = 1;
            tableLayoutPanelPOS.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelPOS.Size = new Size(1120, 660);
            tableLayoutPanelPOS.TabIndex = 0;
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
            panelCatalogo.Size = new Size(695, 650);
            panelCatalogo.StateCommon.Color1 = Color.White;
            panelCatalogo.TabIndex = 0;
            // 
            // lblTituloCatalogo
            // 
            lblTituloCatalogo.Location = new Point(20, 15);
            lblTituloCatalogo.Name = "lblTituloCatalogo";
            lblTituloCatalogo.Size = new Size(278, 24);
            lblTituloCatalogo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloCatalogo.TabIndex = 0;
            lblTituloCatalogo.Values.Text = "CATÁLOGO RÁPIDO DE NOTEBOOKS";
            // 
            // txtBuscarNotebook
            // 
            txtBuscarNotebook.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscarNotebook.CueHint.CueHintText = "🔍 Buscar por marca, modelo o especificaciones...";
            txtBuscarNotebook.Location = new Point(20, 42);
            txtBuscarNotebook.Name = "txtBuscarNotebook";
            txtBuscarNotebook.Size = new Size(655, 27);
            txtBuscarNotebook.TabIndex = 1;
            txtBuscarNotebook.TextChanged += txtBuscarNotebook_TextChanged;
            // 
            // dgvCatalogo
            // 
            dgvCatalogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatalogo.BorderStyle = BorderStyle.None;
            dgvCatalogo.ColumnHeadersHeight = 36;
            dgvCatalogo.Location = new Point(20, 90);
            dgvCatalogo.Name = "dgvCatalogo";
            dgvCatalogo.RowHeadersWidth = 51;
            dgvCatalogo.Size = new Size(655, 540);
            dgvCatalogo.TabIndex = 2;
            dgvCatalogo.CellContentClick += dgvCatalogo_CellContentClick;
            // 
            // panelCarrito
            // 
            panelCarrito.Controls.Add(lblTituloCliente);
            panelCarrito.Controls.Add(txtDniCliente);
            panelCarrito.Controls.Add(btnBuscarCliente);
            panelCarrito.Controls.Add(flowClienteInfo);
            panelCarrito.Controls.Add(lblResumenCompra);
            panelCarrito.Controls.Add(dgvCarrito);
            panelCarrito.Controls.Add(tblSubtotal);
            panelCarrito.Controls.Add(btnPasarAFacturacion);
            panelCarrito.Dock = DockStyle.Fill;
            panelCarrito.Location = new Point(710, 5);
            panelCarrito.Margin = new Padding(5);
            panelCarrito.Name = "panelCarrito";
            panelCarrito.Size = new Size(405, 650);
            panelCarrito.StateCommon.Color1 = Color.White;
            panelCarrito.TabIndex = 1;
            // 
            // lblTituloCliente
            // 
            lblTituloCliente.Location = new Point(20, 15);
            lblTituloCliente.Name = "lblTituloCliente";
            lblTituloCliente.Size = new Size(156, 24);
            lblTituloCliente.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTituloCliente.TabIndex = 0;
            lblTituloCliente.Values.Text = "CLIENTE ASOCIADO";
            // 
            // txtDniCliente
            // 
            txtDniCliente.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDniCliente.Location = new Point(20, 40);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(240, 27);
            txtDniCliente.TabIndex = 1;
            
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuscarCliente.Location = new Point(270, 40);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(115, 30);
            btnBuscarCliente.TabIndex = 2;
            btnBuscarCliente.Values.DropDownArrowColor = Color.Empty;
            btnBuscarCliente.Values.Text = "Ingresar";
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // flowClienteInfo
            // 
            flowClienteInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowClienteInfo.AutoSize = true;
            flowClienteInfo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowClienteInfo.BackColor = Color.FromArgb(241, 245, 249);
            flowClienteInfo.Controls.Add(lblClienteNombre);
            flowClienteInfo.Controls.Add(lblClienteDni);
            flowClienteInfo.Controls.Add(btnRedirigirCrudCliente);
            flowClienteInfo.FlowDirection = FlowDirection.TopDown;
            flowClienteInfo.Location = new Point(20, 78);
            flowClienteInfo.Margin = new Padding(0);
            flowClienteInfo.Name = "flowClienteInfo";
            flowClienteInfo.Padding = new Padding(10);
            flowClienteInfo.Size = new Size(198, 120);
            flowClienteInfo.TabIndex = 3;
            // 
            // lblClienteNombre
            // 
            lblClienteNombre.Location = new Point(13, 13);
            lblClienteNombre.Name = "lblClienteNombre";
            lblClienteNombre.Size = new Size(172, 26);
            lblClienteNombre.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblClienteNombre.TabIndex = 0;
            lblClienteNombre.Values.Text = "Seleccione un cliente";
            // 
            // lblClienteDni
            // 
            lblClienteDni.Location = new Point(13, 45);
            lblClienteDni.Name = "lblClienteDni";
            lblClienteDni.Size = new Size(58, 24);
            lblClienteDni.TabIndex = 1;
            lblClienteDni.Values.Text = "DNI: --";
            // 
            // btnRedirigirCrudCliente
            // 
            btnRedirigirCrudCliente.Location = new Point(13, 75);
            btnRedirigirCrudCliente.Name = "btnRedirigirCrudCliente";
            btnRedirigirCrudCliente.Size = new Size(160, 32);
            btnRedirigirCrudCliente.TabIndex = 2;
            btnRedirigirCrudCliente.Values.DropDownArrowColor = Color.Empty;
            btnRedirigirCrudCliente.Values.Text = "➕ Registrar Cliente";
            btnRedirigirCrudCliente.Visible = false;
            btnRedirigirCrudCliente.Click += btnRedirigirCrudCliente_Click;
            // 
            // lblResumenCompra
            // 
            lblResumenCompra.Location = new Point(20, 182);
            lblResumenCompra.Name = "lblResumenCompra";
            lblResumenCompra.Size = new Size(268, 24);
            lblResumenCompra.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResumenCompra.TabIndex = 4;
            lblResumenCompra.Values.Text = "COMPUTADORAS SELECCIONADAS";
            // 
            // dgvCarrito
            // 
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.BorderStyle = BorderStyle.None;
            dgvCarrito.ColumnHeadersHeight = 36;
            dgvCarrito.Location = new Point(20, 208);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(365, 308);
            dgvCarrito.TabIndex = 5;
            // 
            // tblSubtotal
            // 
            tblSubtotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tblSubtotal.BackColor = Color.White;
            tblSubtotal.ColumnCount = 2;
            tblSubtotal.ColumnStyles.Add(new ColumnStyle());
            tblSubtotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSubtotal.Controls.Add(lblTotalPagar, 0, 0);
            tblSubtotal.Controls.Add(lblSubtotalEstimado, 1, 0);
            tblSubtotal.Location = new Point(20, 528);
            tblSubtotal.Name = "tblSubtotal";
            tblSubtotal.RowCount = 1;
            tblSubtotal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSubtotal.Size = new Size(365, 42);
            tblSubtotal.TabIndex = 4;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.Dock = DockStyle.Fill;
            lblTotalPagar.Location = new Point(3, 3);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(187, 36);
            lblTotalPagar.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalPagar.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblTotalPagar.TabIndex = 0;
            lblTotalPagar.Values.Text = "SUBTOTAL ESTIMADO:";
            // 
            // lblSubtotalEstimado
            // 
            lblSubtotalEstimado.Dock = DockStyle.Fill;
            lblSubtotalEstimado.Location = new Point(196, 3);
            lblSubtotalEstimado.Name = "lblSubtotalEstimado";
            lblSubtotalEstimado.Size = new Size(166, 36);
            lblSubtotalEstimado.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblSubtotalEstimado.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblSubtotalEstimado.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            lblSubtotalEstimado.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            lblSubtotalEstimado.TabIndex = 1;
            lblSubtotalEstimado.Values.Text = "$0";
            // 
            // btnPasarAFacturacion
            // 
            btnPasarAFacturacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnPasarAFacturacion.Location = new Point(20, 582);
            btnPasarAFacturacion.Name = "btnPasarAFacturacion";
            btnPasarAFacturacion.Size = new Size(365, 48);
            btnPasarAFacturacion.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnPasarAFacturacion.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnPasarAFacturacion.StateCommon.Content.ShortText.Color1 = Color.White;
            btnPasarAFacturacion.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnPasarAFacturacion.TabIndex = 6;
            btnPasarAFacturacion.Values.DropDownArrowColor = Color.Empty;
            btnPasarAFacturacion.Values.Text = "📄 Pasar a Facturación";
            btnPasarAFacturacion.Click += btnPasarAFacturacion_Click;
            // 
            // ControlVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanelPOS);
            Name = "ControlVentas";
            Size = new Size(1120, 660);
            tableLayoutPanelPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCatalogo).EndInit();
            panelCatalogo.ResumeLayout(false);
            panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCatalogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelCarrito).EndInit();
            panelCarrito.ResumeLayout(false);
            panelCarrito.PerformLayout();
            flowClienteInfo.ResumeLayout(false);
            flowClienteInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            tblSubtotal.ResumeLayout(false);
            tblSubtotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPOS;
        private Krypton.Toolkit.KryptonPanel panelCatalogo;
        private Krypton.Toolkit.KryptonLabel lblTituloCatalogo;
        private Krypton.Toolkit.KryptonTextBox txtBuscarNotebook;
        private Krypton.Toolkit.KryptonDataGridView dgvCatalogo;
        private Krypton.Toolkit.KryptonPanel panelCarrito;
        private Krypton.Toolkit.KryptonLabel lblTituloCliente;
        private Krypton.Toolkit.KryptonTextBox txtDniCliente;
        private Krypton.Toolkit.KryptonButton btnBuscarCliente;
        private System.Windows.Forms.FlowLayoutPanel flowClienteInfo;
        private Krypton.Toolkit.KryptonLabel lblClienteNombre;
        private Krypton.Toolkit.KryptonLabel lblClienteDni;
        private Krypton.Toolkit.KryptonButton btnRedirigirCrudCliente;
        private Krypton.Toolkit.KryptonLabel lblResumenCompra;
        private Krypton.Toolkit.KryptonDataGridView dgvCarrito;
        private System.Windows.Forms.TableLayoutPanel tblSubtotal;
        private Krypton.Toolkit.KryptonLabel lblTotalPagar;
        private Krypton.Toolkit.KryptonLabel lblSubtotalEstimado;
        private Krypton.Toolkit.KryptonButton btnPasarAFacturacion;
    }
}