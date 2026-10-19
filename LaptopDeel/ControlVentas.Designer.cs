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
            this.tableLayoutPanelPOS = new System.Windows.Forms.TableLayoutPanel();
            this.panelCatalogo = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloCatalogo = new Krypton.Toolkit.KryptonLabel();
            this.txtBuscarNotebook = new Krypton.Toolkit.KryptonTextBox();
            this.dgvCatalogo = new Krypton.Toolkit.KryptonDataGridView();
            this.panelCarrito = new Krypton.Toolkit.KryptonPanel();
            this.lblTituloCliente = new Krypton.Toolkit.KryptonLabel();
            this.txtDniCliente = new Krypton.Toolkit.KryptonTextBox();
            this.btnBuscarCliente = new Krypton.Toolkit.KryptonButton();
            this.flowClienteInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblClienteNombre = new Krypton.Toolkit.KryptonLabel();
            this.lblClienteDni = new Krypton.Toolkit.KryptonLabel();
            this.btnRedirigirCrudCliente = new Krypton.Toolkit.KryptonButton();
            this.lblResumenCompra = new Krypton.Toolkit.KryptonLabel();
            this.dgvCarrito = new Krypton.Toolkit.KryptonDataGridView();
            this.tblSubtotal = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            this.lblSubtotalEstimado = new Krypton.Toolkit.KryptonLabel();
            this.btnPasarAFacturacion = new Krypton.Toolkit.KryptonButton();

            this.tableLayoutPanelPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCatalogo)).BeginInit();
            this.panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCarrito)).BeginInit();
            this.panelCarrito.SuspendLayout();
            this.flowClienteInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.tblSubtotal.SuspendLayout();
            this.SuspendLayout();

            // 
            // tableLayoutPanelPOS
            // 
            this.tableLayoutPanelPOS.ColumnCount = 2;
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanelPOS.Controls.Add(this.panelCatalogo, 0, 0);
            this.tableLayoutPanelPOS.Controls.Add(this.panelCarrito, 1, 0);
            this.tableLayoutPanelPOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPOS.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPOS.Name = "tableLayoutPanelPOS";
            this.tableLayoutPanelPOS.RowCount = 1;
            this.tableLayoutPanelPOS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPOS.Size = new System.Drawing.Size(1120, 660);
            this.tableLayoutPanelPOS.TabIndex = 0;

            // 
            // panelCatalogo
            // 
            this.panelCatalogo.Controls.Add(this.lblTituloCatalogo);
            this.panelCatalogo.Controls.Add(this.txtBuscarNotebook);
            this.panelCatalogo.Controls.Add(this.dgvCatalogo);
            this.panelCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatalogo.Location = new System.Drawing.Point(5, 5);
            this.panelCatalogo.Margin = new System.Windows.Forms.Padding(5);
            this.panelCatalogo.Name = "panelCatalogo";
            this.panelCatalogo.Size = new System.Drawing.Size(695, 650);
            this.panelCatalogo.StateCommon.Color1 = System.Drawing.Color.White;

            this.lblTituloCatalogo.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCatalogo.Name = "lblTituloCatalogo";
            this.lblTituloCatalogo.Size = new System.Drawing.Size(240, 20);
            this.lblTituloCatalogo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCatalogo.Values.Text = "CATÁLOGO RÁPIDO DE NOTEBOOKS";

            this.txtBuscarNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarNotebook.Location = new System.Drawing.Point(20, 42);
            this.txtBuscarNotebook.Name = "txtBuscarNotebook";
            this.txtBuscarNotebook.Size = new System.Drawing.Size(655, 35);
            this.txtBuscarNotebook.Text = string.Empty;
            this.txtBuscarNotebook.CueHint.CueHintText = "🔍 Buscar por marca, modelo o especificaciones...";
            this.txtBuscarNotebook.TextChanged += new System.EventHandler(this.txtBuscarNotebook_TextChanged);

            this.dgvCatalogo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalogo.Location = new System.Drawing.Point(20, 90);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.Size = new System.Drawing.Size(655, 540);
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellContentClick);

            // 
            // panelCarrito
            // 
            this.panelCarrito.Controls.Add(this.lblTituloCliente);
            this.panelCarrito.Controls.Add(this.txtDniCliente);
            this.panelCarrito.Controls.Add(this.btnBuscarCliente);
            this.panelCarrito.Controls.Add(this.flowClienteInfo);
            this.panelCarrito.Controls.Add(this.lblResumenCompra);
            this.panelCarrito.Controls.Add(this.dgvCarrito);
            this.panelCarrito.Controls.Add(this.tblSubtotal);
            this.panelCarrito.Controls.Add(this.btnPasarAFacturacion);
            this.panelCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarrito.Location = new System.Drawing.Point(710, 5);
            this.panelCarrito.Margin = new System.Windows.Forms.Padding(5);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(405, 650);
            this.panelCarrito.StateCommon.Color1 = System.Drawing.Color.White;

            // Cliente
            this.lblTituloCliente.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCliente.Name = "lblTituloCliente";
            this.lblTituloCliente.Size = new System.Drawing.Size(150, 20);
            this.lblTituloCliente.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCliente.Values.Text = "CLIENTE ASOCIADO";

            this.txtDniCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDniCliente.Location = new System.Drawing.Point(20, 40);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(240, 30);

            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(270, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(115, 30);
            this.btnBuscarCliente.Values.Text = "🔍 Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);

            // FlowClienteInfo
            this.flowClienteInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowClienteInfo.AutoSize = true;
            this.flowClienteInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowClienteInfo.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.flowClienteInfo.Controls.Add(this.lblClienteNombre);
            this.flowClienteInfo.Controls.Add(this.lblClienteDni);
            this.flowClienteInfo.Controls.Add(this.btnRedirigirCrudCliente);
            this.flowClienteInfo.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowClienteInfo.Location = new System.Drawing.Point(20, 78);
            this.flowClienteInfo.Margin = new System.Windows.Forms.Padding(0);
            this.flowClienteInfo.Name = "flowClienteInfo";
            this.flowClienteInfo.Padding = new System.Windows.Forms.Padding(10);
            this.flowClienteInfo.Size = new System.Drawing.Size(365, 95);

            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(140, 20);
            this.lblClienteNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblClienteNombre.Values.Text = "Seleccione un cliente";

            this.lblClienteDni.AutoSize = true;
            this.lblClienteDni.Name = "lblClienteDni";
            this.lblClienteDni.Size = new System.Drawing.Size(60, 20);
            this.lblClienteDni.Values.Text = "DNI: --";

            this.btnRedirigirCrudCliente.Name = "btnRedirigirCrudCliente";
            this.btnRedirigirCrudCliente.Size = new System.Drawing.Size(160, 32);
            this.btnRedirigirCrudCliente.Values.Text = "➕ Registrar Cliente";
            this.btnRedirigirCrudCliente.Visible = false;
            this.btnRedirigirCrudCliente.Click += new System.EventHandler(this.btnRedirigirCrudCliente_Click);

            // Resumen de Carrito
            this.lblResumenCompra.Location = new System.Drawing.Point(20, 182);
            this.lblResumenCompra.Name = "lblResumenCompra";
            this.lblResumenCompra.Size = new System.Drawing.Size(250, 20);
            this.lblResumenCompra.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblResumenCompra.Values.Text = "COMPUTADORAS SELECCIONADAS";

            // dgvCarrito
            this.dgvCarrito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCarrito.Location = new System.Drawing.Point(20, 208);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(365, 308);

            // tblSubtotal (Cuadrícula Flexible de 1 fila x 2 columnas)
            this.tblSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblSubtotal.BackColor = System.Drawing.Color.White;
            this.tblSubtotal.ColumnCount = 2;
            this.tblSubtotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));
            this.tblSubtotal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubtotal.Controls.Add(this.lblTotalPagar, 0, 0);
            this.tblSubtotal.Controls.Add(this.lblSubtotalEstimado, 1, 0);
            this.tblSubtotal.Location = new System.Drawing.Point(20, 528);
            this.tblSubtotal.Name = "tblSubtotal";
            this.tblSubtotal.RowCount = 1;
            this.tblSubtotal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSubtotal.Size = new System.Drawing.Size(365, 42);
            this.tblSubtotal.TabIndex = 4;

            this.lblTotalPagar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(155, 36);
            this.lblTotalPagar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTotalPagar.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblTotalPagar.Values.Text = "SUBTOTAL ESTIMADO:";

            this.lblSubtotalEstimado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSubtotalEstimado.Name = "lblSubtotalEstimado";
            this.lblSubtotalEstimado.Size = new System.Drawing.Size(204, 36);
            this.lblSubtotalEstimado.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblSubtotalEstimado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalEstimado.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblSubtotalEstimado.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.lblSubtotalEstimado.Values.Text = "$0";

            // Botón Pasar a Facturación
            this.btnPasarAFacturacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasarAFacturacion.Location = new System.Drawing.Point(20, 582);
            this.btnPasarAFacturacion.Name = "btnPasarAFacturacion";
            this.btnPasarAFacturacion.Size = new System.Drawing.Size(365, 48);
            this.btnPasarAFacturacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPasarAFacturacion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPasarAFacturacion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPasarAFacturacion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPasarAFacturacion.Values.Text = "📄 Pasar a Facturación";
            this.btnPasarAFacturacion.Click += new System.EventHandler(this.btnPasarAFacturacion_Click);

            // ControlVentas Base Config
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelPOS);
            this.Name = "ControlVentas";
            this.Size = new System.Drawing.Size(1120, 660);

            this.tableLayoutPanelPOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelCatalogo)).EndInit();
            this.panelCatalogo.ResumeLayout(false);
            this.panelCatalogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCarrito)).EndInit();
            this.panelCarrito.ResumeLayout(false);
            this.panelCarrito.PerformLayout();
            this.flowClienteInfo.ResumeLayout(false);
            this.flowClienteInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            this.tblSubtotal.ResumeLayout(false);
            this.tblSubtotal.PerformLayout();
            this.ResumeLayout(false);
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