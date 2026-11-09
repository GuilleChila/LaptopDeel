namespace LaptopDeel
{
    partial class ControlStockNotebooks
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

        #region Código generado por el Diseñador de componentes

        private void InitializeComponent()
        {
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            panelFiltros = new Krypton.Toolkit.KryptonPanel();
            lblBuscar = new Krypton.Toolkit.KryptonLabel();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblFiltroStock = new Krypton.Toolkit.KryptonLabel();
            cmbFiltroStock = new Krypton.Toolkit.KryptonComboBox();
            panelContenedorGrilla = new Krypton.Toolkit.KryptonPanel();
            dgvStock = new Krypton.Toolkit.KryptonDataGridView();
            panelInferiorAcciones = new Krypton.Toolkit.KryptonPanel();
            lblMontoTotalExistencias = new Krypton.Toolkit.KryptonLabel();
            btnExportarPdf = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelFiltros).BeginInit();
            panelFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelContenedorGrilla).BeginInit();
            panelContenedorGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelInferiorAcciones).BeginInit();
            panelInferiorAcciones.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(15, 12);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(374, 36);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Reporte de Stock de Notebooks";
            // 
            // panelFiltros
            // 
            panelFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFiltros.Controls.Add(lblBuscar);
            panelFiltros.Controls.Add(txtBuscar);
            panelFiltros.Controls.Add(lblFiltroStock);
            panelFiltros.Controls.Add(cmbFiltroStock);
            panelFiltros.Location = new Point(15, 48);
            panelFiltros.Name = "panelFiltros";
            panelFiltros.Size = new Size(870, 65);
            panelFiltros.StateCommon.Color1 = Color.White;
            panelFiltros.StateCommon.Color2 = Color.White;
            panelFiltros.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(15, 8);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(205, 23);
            lblBuscar.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblBuscar.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblBuscar.TabIndex = 0;
            lblBuscar.Values.Text = "Buscar por Marca o Modelo:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.CueHint.CueHintText = "🔍 Escriba marca o modelo...";
            txtBuscar.Location = new Point(15, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(530, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblFiltroStock
            // 
            lblFiltroStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltroStock.Location = new Point(454, 8);
            lblFiltroStock.Name = "lblFiltroStock";
            lblFiltroStock.Size = new Size(159, 23);
            lblFiltroStock.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblFiltroStock.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFiltroStock.TabIndex = 2;
            lblFiltroStock.Values.Text = "Filtrar Nivel de Stock:";
            // 
            // cmbFiltroStock
            // 
            cmbFiltroStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroStock.Location = new Point(565, 28);
            cmbFiltroStock.Name = "cmbFiltroStock";
            cmbFiltroStock.Size = new Size(290, 26);
            cmbFiltroStock.TabIndex = 3;
            cmbFiltroStock.SelectedIndexChanged += cmbFiltroStock_SelectedIndexChanged;
            // 
            // panelContenedorGrilla
            // 
            panelContenedorGrilla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContenedorGrilla.Controls.Add(dgvStock);
            panelContenedorGrilla.Location = new Point(15, 120);
            panelContenedorGrilla.Name = "panelContenedorGrilla";
            panelContenedorGrilla.Size = new Size(870, 365);
            panelContenedorGrilla.StateCommon.Color1 = Color.White;
            panelContenedorGrilla.StateCommon.Color2 = Color.White;
            panelContenedorGrilla.TabIndex = 0;
            // 
            // dgvStock
            // 
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.BorderStyle = BorderStyle.None;
            dgvStock.ColumnHeadersHeight = 36;
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(0, 0);
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.RowHeadersWidth = 30;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(870, 365);
            dgvStock.StateCommon.Background.Color1 = Color.FromArgb(248, 250, 252);
            dgvStock.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvStock.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(30, 41, 59);
            dgvStock.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(30, 41, 59);
            dgvStock.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvStock.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvStock.TabIndex = 0;
            dgvStock.CellFormatting += dgvStock_CellFormatting;
            // 
            // panelInferiorAcciones
            // 
            panelInferiorAcciones.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelInferiorAcciones.Controls.Add(lblMontoTotalExistencias);
            panelInferiorAcciones.Controls.Add(btnExportarPdf);
            panelInferiorAcciones.Location = new Point(15, 492);
            panelInferiorAcciones.Name = "panelInferiorAcciones";
            panelInferiorAcciones.Size = new Size(870, 95);
            panelInferiorAcciones.StateCommon.Color1 = Color.White;
            panelInferiorAcciones.StateCommon.Color2 = Color.White;
            panelInferiorAcciones.TabIndex = 1;
            // 
            // lblMontoTotalExistencias
            this.lblMontoTotalExistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMontoTotalExistencias.Location = new System.Drawing.Point(400, 10);
            this.lblMontoTotalExistencias.Name = "lblMontoTotalExistencias";
            this.lblMontoTotalExistencias.Size = new System.Drawing.Size(450, 28);
            this.lblMontoTotalExistencias.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMontoTotalExistencias.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            this.lblMontoTotalExistencias.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            this.lblMontoTotalExistencias.Values.Text = "Monto Total de Existencias: $ 0,00 ";
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportarPdf.Location = new Point(625, 42);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(230, 40);
            btnExportarPdf.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnExportarPdf.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnExportarPdf.StateCommon.Border.Rounding = 6F;
            btnExportarPdf.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExportarPdf.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnExportarPdf.TabIndex = 1;
            btnExportarPdf.Values.DropDownArrowColor = Color.Empty;
            btnExportarPdf.Values.Text = "📄 Exportar a PDF";
            btnExportarPdf.Click += btnExportarPdf_Click;
            // 
            // ControlStockNotebooks
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(203, 213, 225);
            Controls.Add(panelContenedorGrilla);
            Controls.Add(panelInferiorAcciones);
            Controls.Add(panelFiltros);
            Controls.Add(lblTituloModulo);
            Name = "ControlStockNotebooks";
            Size = new Size(900, 600);
            Load += ControlStockNotebooks_Load;
            ((System.ComponentModel.ISupportInitialize)panelFiltros).EndInit();
            panelFiltros.ResumeLayout(false);
            panelFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelContenedorGrilla).EndInit();
            panelContenedorGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelInferiorAcciones).EndInit();
            panelInferiorAcciones.ResumeLayout(false);
            panelInferiorAcciones.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonPanel panelFiltros;
        private Krypton.Toolkit.KryptonLabel lblBuscar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonLabel lblFiltroStock;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroStock;

        private Krypton.Toolkit.KryptonPanel panelContenedorGrilla;
        private Krypton.Toolkit.KryptonDataGridView dgvStock;

        private Krypton.Toolkit.KryptonPanel panelInferiorAcciones;
        private Krypton.Toolkit.KryptonLabel lblMontoTotalExistencias;
        private Krypton.Toolkit.KryptonButton btnExportarPdf;
    }
}