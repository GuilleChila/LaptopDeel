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
            this.panelClienteInfo = new Krypton.Toolkit.KryptonPanel();
            this.lblClienteNombre = new Krypton.Toolkit.KryptonLabel();
            this.lblClienteDni = new Krypton.Toolkit.KryptonLabel();
            this.btnRedirigirCrudCliente = new Krypton.Toolkit.KryptonButton();
            this.lblResumenCompra = new Krypton.Toolkit.KryptonLabel();
            this.dgvCarrito = new Krypton.Toolkit.KryptonDataGridView();
            this.lblTotalPagar = new Krypton.Toolkit.KryptonLabel();
            this.lblSubtotalEstimado = new Krypton.Toolkit.KryptonLabel();
            this.btnPasarAFacturacion = new Krypton.Toolkit.KryptonButton();

            this.tableLayoutPanelPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelCatalogo)).BeginInit();
            this.panelCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCarrito)).BeginInit();
            this.panelCarrito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelClienteInfo)).BeginInit();
            this.panelClienteInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            this.SuspendLayout();

            // 
            // tableLayoutPanelPOS (División 65% Catálogo - 35% Carrito)
            // 
            this.tableLayoutPanelPOS.ColumnCount = 2;
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelPOS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
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
            // panelCatalogo (Tarjeta Izquierda)
            // 
            this.panelCatalogo.Controls.Add(this.lblTituloCatalogo);
            this.panelCatalogo.Controls.Add(this.txtBuscarNotebook);
            this.panelCatalogo.Controls.Add(this.dgvCatalogo);
            this.panelCatalogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCatalogo.Location = new System.Drawing.Point(5, 5);
            this.panelCatalogo.Margin = new System.Windows.Forms.Padding(5);
            this.panelCatalogo.Name = "panelCatalogo";
            this.panelCatalogo.Size = new System.Drawing.Size(718, 650);
            this.panelCatalogo.StateCommon.Color1 = System.Drawing.Color.White;

            this.lblTituloCatalogo.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCatalogo.Values.Text = "CATÁLOGO RÁPIDO DE NOTEBOOKS";
            this.lblTituloCatalogo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtBuscarNotebook.Location = new System.Drawing.Point(20, 45);
            this.txtBuscarNotebook.Name = "txtBuscarNotebook";
            this.txtBuscarNotebook.Size = new System.Drawing.Size(678, 35);
            this.txtBuscarNotebook.Text = "🔍 Buscar por marca, modelo o especificaciones...";
            this.txtBuscarNotebook.TextChanged += new System.EventHandler(this.txtBuscarNotebook_TextChanged);

            this.dgvCatalogo.Location = new System.Drawing.Point(20, 95);
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.Size = new System.Drawing.Size(678, 530);
            this.dgvCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogo_CellContentClick);

            // 
            // panelCarrito (Tarjeta Derecha)
            // 
            this.panelCarrito.Controls.Add(this.lblTituloCliente);
            this.panelCarrito.Controls.Add(this.txtDniCliente);
            this.panelCarrito.Controls.Add(this.btnBuscarCliente);
            this.panelCarrito.Controls.Add(this.panelClienteInfo);
            this.panelCarrito.Controls.Add(this.lblResumenCompra);
            this.panelCarrito.Controls.Add(this.dgvCarrito);
            this.panelCarrito.Controls.Add(this.lblTotalPagar);
            this.panelCarrito.Controls.Add(this.lblSubtotalEstimado);
            this.panelCarrito.Controls.Add(this.btnPasarAFacturacion);
            this.panelCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCarrito.Location = new System.Drawing.Point(733, 5);
            this.panelCarrito.Margin = new System.Windows.Forms.Padding(5);
            this.panelCarrito.Name = "panelCarrito";
            this.panelCarrito.Size = new System.Drawing.Size(382, 650);
            this.panelCarrito.StateCommon.Color1 = System.Drawing.Color.White;

            // Búsqueda de Cliente por DNI
            this.lblTituloCliente.Location = new System.Drawing.Point(20, 15);
            this.lblTituloCliente.Values.Text = "CLIENTE ASOCIADO";
            this.lblTituloCliente.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.txtDniCliente.Location = new System.Drawing.Point(20, 40);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(220, 30);

            this.btnBuscarCliente.Location = new System.Drawing.Point(250, 40);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(110, 30);
            this.btnBuscarCliente.Values.Text = "🔍 Buscar";
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);

            // Tarjeta Info Cliente / Redirección al CRUD
            this.panelClienteInfo.Controls.Add(this.lblClienteNombre);
            this.panelClienteInfo.Controls.Add(this.lblClienteDni);
            this.panelClienteInfo.Controls.Add(this.btnRedirigirCrudCliente);
            this.panelClienteInfo.Location = new System.Drawing.Point(20, 80);
            this.panelClienteInfo.Name = "panelClienteInfo";
            this.panelClienteInfo.Size = new System.Drawing.Size(340, 75);
            this.panelClienteInfo.StateCommon.Color1 = System.Drawing.Color.FromArgb(241, 245, 249);

            this.lblClienteNombre.Location = new System.Drawing.Point(10, 8);
            this.lblClienteNombre.Values.Text = "Seleccione un cliente";
            this.lblClienteNombre.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblClienteDni.Location = new System.Drawing.Point(10, 30);
            this.lblClienteDni.Values.Text = "DNI: --";

            this.btnRedirigirCrudCliente.Location = new System.Drawing.Point(180, 20);
            this.btnRedirigirCrudCliente.Name = "btnRedirigirCrudCliente";
            this.btnRedirigirCrudCliente.Size = new System.Drawing.Size(150, 35);
            this.btnRedirigirCrudCliente.Values.Text = "➕ Registrar Cliente";
            this.btnRedirigirCrudCliente.Visible = false;
            this.btnRedirigirCrudCliente.Click += new System.EventHandler(this.btnRedirigirCrudCliente_Click);

            // Resumen de Carrito
            this.lblResumenCompra.Location = new System.Drawing.Point(20, 170);
            this.lblResumenCompra.Values.Text = "COMPUTADORAS SELECCIONADAS";
            this.lblResumenCompra.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.dgvCarrito.Location = new System.Drawing.Point(20, 200);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.Size = new System.Drawing.Size(340, 320);

            // Subtotal y Botón Pasar a Facturación
            this.lblTotalPagar.Location = new System.Drawing.Point(20, 535);
            this.lblTotalPagar.Values.Text = "SUBTOTAL ESTIMADO:";
            this.lblTotalPagar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);

            this.lblSubtotalEstimado.Location = new System.Drawing.Point(200, 530);
            this.lblSubtotalEstimado.Values.Text = "$0";
            this.lblSubtotalEstimado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSubtotalEstimado.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);

            this.btnPasarAFacturacion.Location = new System.Drawing.Point(20, 575);
            this.btnPasarAFacturacion.Name = "btnPasarAFacturacion";
            this.btnPasarAFacturacion.Size = new System.Drawing.Size(340, 50);
            this.btnPasarAFacturacion.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPasarAFacturacion.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnPasarAFacturacion.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnPasarAFacturacion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPasarAFacturacion.Values.Text = "📄 Pasar a Facturación";
            this.btnPasarAFacturacion.Click += new System.EventHandler(this.btnPasarAFacturacion_Click);

            // 
            // ControlVentas
            // 
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
            ((System.ComponentModel.ISupportInitialize)(this.panelClienteInfo)).EndInit();
            this.panelClienteInfo.ResumeLayout(false);
            this.panelClienteInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
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
        private Krypton.Toolkit.KryptonPanel panelClienteInfo;
        private Krypton.Toolkit.KryptonLabel lblClienteNombre;
        private Krypton.Toolkit.KryptonLabel lblClienteDni;
        private Krypton.Toolkit.KryptonButton btnRedirigirCrudCliente;
        private Krypton.Toolkit.KryptonLabel lblResumenCompra;
        private Krypton.Toolkit.KryptonDataGridView dgvCarrito;
        private Krypton.Toolkit.KryptonLabel lblTotalPagar;
        private Krypton.Toolkit.KryptonLabel lblSubtotalEstimado;
        private Krypton.Toolkit.KryptonButton btnPasarAFacturacion;
    }
}