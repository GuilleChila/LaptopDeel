namespace LaptopDeel
{
    partial class ControlReportVentas
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelFiltro = new Panel();
            exportarReporte = new Krypton.Toolkit.KryptonButton();
            dtpHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnGenerar = new Button();
            panelGrafico = new Panel();
            dgvReporteGrilla = new DataGridView();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            Top3Vendidas = new Panel();
            panelGraficoAnual = new Panel();
            btnAlternarAnual = new Krypton.Toolkit.KryptonButton();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).BeginInit();
            SuspendLayout();
            // 
            // panelFiltro
            // 
            panelFiltro.BackColor = Color.White;
            panelFiltro.Controls.Add(exportarReporte);
            panelFiltro.Controls.Add(dtpHasta);
            panelFiltro.Controls.Add(dtpDesde);
            panelFiltro.Controls.Add(kryptonLabel2);
            panelFiltro.Controls.Add(kryptonLabel3);
            panelFiltro.Controls.Add(btnGenerar);
            panelFiltro.Dock = DockStyle.Top;
            panelFiltro.Location = new Point(0, 0);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Size = new Size(789, 103);
            panelFiltro.TabIndex = 1;
            // 
            // exportarReporte
            // 
            exportarReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportarReporte.Location = new Point(321, 3);
            exportarReporte.Name = "exportarReporte";
            exportarReporte.Size = new Size(135, 24);
            exportarReporte.TabIndex = 8;
            exportarReporte.Values.DropDownArrowColor = Color.Empty;
            exportarReporte.Values.Text = "Exportar reporte";
            exportarReporte.Click += exportarReporte_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.Left;
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(495, 43);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(152, 31);
            dtpHasta.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpHasta.StateCommon.Border.Rounding = 8F;
            dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.Left;
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(290, 42);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(121, 31);
            dtpDesde.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            dtpDesde.StateCommon.Border.Rounding = 8F;
            dtpDesde.TabIndex = 6;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Left;
            kryptonLabel2.Location = new Point(214, 50);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(57, 24);
            kryptonLabel2.TabIndex = 0;
            kryptonLabel2.Values.Text = "Desde:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Left;
            kryptonLabel3.Location = new Point(426, 49);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(53, 24);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Hasta:";
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Left;
            btnGenerar.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(653, 43);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(97, 30);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Filtrar Fechas";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.White;
            panelGrafico.Dock = DockStyle.Top;
            panelGrafico.Location = new Point(0, 103);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(789, 502);
            panelGrafico.TabIndex = 2;
            // 
            // dgvReporteGrilla
            // 
            dgvReporteGrilla.AllowDrop = true;
            dgvReporteGrilla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 249, 249);
            dgvReporteGrilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteGrilla.BackgroundColor = Color.White;
            dgvReporteGrilla.BorderStyle = BorderStyle.None;
            dgvReporteGrilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteGrilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(41, 128, 185);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReporteGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReporteGrilla.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 245, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReporteGrilla.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReporteGrilla.Dock = DockStyle.Top;
            dgvReporteGrilla.Enabled = false;
            dgvReporteGrilla.EnableHeadersVisualStyles = false;
            dgvReporteGrilla.GridColor = Color.FromArgb(224, 224, 224);
            dgvReporteGrilla.Location = new Point(0, 605);
            dgvReporteGrilla.Name = "dgvReporteGrilla";
            dgvReporteGrilla.RowHeadersWidth = 51;
            dgvReporteGrilla.RowTemplate.Height = 35;
            dgvReporteGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteGrilla.Size = new Size(789, 268);
            dgvReporteGrilla.TabIndex = 6;
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(0, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(48, 24);
            kryptonLabel4.TabIndex = 4;
            // 
            // Top3Vendidas
            // 
            Top3Vendidas.Dock = DockStyle.Top;
            Top3Vendidas.Location = new Point(0, 873);
            Top3Vendidas.Name = "Top3Vendidas";
            Top3Vendidas.Size = new Size(789, 507);
            Top3Vendidas.TabIndex = 4;
            // 
            // panelGraficoAnual
            // 
            panelGraficoAnual.Dock = DockStyle.Top;
            panelGraficoAnual.Location = new Point(0, 1428);
            panelGraficoAnual.Name = "panelGraficoAnual";
            panelGraficoAnual.Size = new Size(789, 489);
            panelGraficoAnual.TabIndex = 5;
            // 
            // btnAlternarAnual
            // 
            btnAlternarAnual.Dock = DockStyle.Top;
            btnAlternarAnual.Location = new Point(0, 1380);
            btnAlternarAnual.Name = "btnAlternarAnual";
            btnAlternarAnual.Size = new Size(789, 48);
            btnAlternarAnual.TabIndex = 0;
            btnAlternarAnual.Values.DropDownArrowColor = Color.Empty;
            btnAlternarAnual.Values.Text = "kryptonButton1";
            btnAlternarAnual.Click += btnAlternarAnual_Click;
            // 
            // ControlReportVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(panelGraficoAnual);
            Controls.Add(btnAlternarAnual);
            Controls.Add(Top3Vendidas);
            Controls.Add(dgvReporteGrilla);
            Controls.Add(panelGrafico);
            Controls.Add(panelFiltro);
            Name = "ControlReportVentas";
            Size = new Size(789, 907);
            Load += ControlReporteVentas_Load;
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelFiltro;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Button btnGenerar;
        private Panel panelGrafico;
        private DataGridView dgvReporteGrilla;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Panel Top3Vendidas;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton exportarReporte;
        private Panel panelGraficoAnual;
        private Krypton.Toolkit.KryptonButton btnAlternarAnual;
    }
}