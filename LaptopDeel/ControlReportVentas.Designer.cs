namespace LaptopDeel
{
    partial class ControlReportVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            panelFiltro = new Panel();
            exportarReporte = new Krypton.Toolkit.KryptonButton();
            dtpHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnGenerar = new Button();
            panelGrafico = new Panel();
            dgvReporteGrilla = new DataGridView();
            Top3Vendidas = new Panel();
            panelTop5Clientes = new Panel();
            dgvTop5Clientes = new DataGridView();
            lblTituloTop5 = new Krypton.Toolkit.KryptonLabel();
            panelGraficoAnual = new Panel();
            btnAlternarAnual = new Krypton.Toolkit.KryptonButton();
            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).BeginInit();
            panelTop5Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5Clientes).BeginInit();
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
            panelFiltro.Size = new Size(758, 95);
            panelFiltro.TabIndex = 1;
            // 
            // exportarReporte
            // 
            exportarReporte.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportarReporte.Location = new Point(578, 15);
            exportarReporte.Name = "exportarReporte";
            exportarReporte.Size = new Size(160, 32);
            exportarReporte.StateCommon.Back.Color1 = Color.FromArgb(16, 185, 129);
            exportarReporte.StateCommon.Back.Color2 = Color.FromArgb(16, 185, 129);
            exportarReporte.StateCommon.Content.ShortText.Color1 = Color.White;
            exportarReporte.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            exportarReporte.TabIndex = 8;
            exportarReporte.Values.DropDownArrowColor = Color.Empty;
            exportarReporte.Values.Text = "📊 Exportar Excel";
            exportarReporte.Click += exportarReporte_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Anchor = AnchorStyles.Left;
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(295, 45);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(130, 31);
            dtpHasta.StateCommon.Border.Rounding = 8F;
            dtpHasta.TabIndex = 7;
            // 
            // dtpDesde
            // 
            dtpDesde.Anchor = AnchorStyles.Left;
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(85, 45);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(130, 31);
            dtpDesde.StateCommon.Border.Rounding = 8F;
            dtpDesde.TabIndex = 6;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Anchor = AnchorStyles.Left;
            kryptonLabel2.Location = new Point(20, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(57, 24);
            kryptonLabel2.TabIndex = 9;
            kryptonLabel2.Values.Text = "Desde:";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Anchor = AnchorStyles.Left;
            kryptonLabel3.Location = new Point(235, 48);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(53, 24);
            kryptonLabel3.TabIndex = 10;
            kryptonLabel3.Values.Text = "Hasta:";
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Left;
            btnGenerar.BackColor = Color.FromArgb(37, 99, 235);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(445, 44);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(130, 32);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "🔍 Filtrar Fechas";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.White;
            panelGrafico.Dock = DockStyle.Top;
            panelGrafico.Location = new Point(0, 95);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(758, 400);
            panelGrafico.TabIndex = 2;
            // 
            // dgvReporteGrilla
            // 
            dgvReporteGrilla.AllowUserToAddRows = false;
            dgvReporteGrilla.AllowUserToDeleteRows = false; // 🔒 Bloquea eliminación de filas
            dgvReporteGrilla.ReadOnly = true; // 🔒 Bloquea edición de celdas
            dataGridViewCellStyle1.BackColor = Color.FromArgb(248, 250, 252);
            dgvReporteGrilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteGrilla.BackgroundColor = Color.White;
            dgvReporteGrilla.BorderStyle = BorderStyle.None;
            dgvReporteGrilla.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteGrilla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvReporteGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReporteGrilla.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvReporteGrilla.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReporteGrilla.Dock = DockStyle.Top;
            dgvReporteGrilla.EnableHeadersVisualStyles = false;
            dgvReporteGrilla.GridColor = Color.FromArgb(226, 232, 240);
            dgvReporteGrilla.Location = new Point(0, 495);
            dgvReporteGrilla.Name = "dgvReporteGrilla";
            dgvReporteGrilla.RowHeadersWidth = 51;
            dgvReporteGrilla.RowTemplate.Height = 35;
            dgvReporteGrilla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteGrilla.Size = new Size(758, 220);
            dgvReporteGrilla.TabIndex = 6;
            dgvReporteGrilla.CellContentClick += dgvReporte_CellContentClick;
            // 
            // Top3Vendidas
            // 
            Top3Vendidas.BackColor = Color.White;
            Top3Vendidas.Dock = DockStyle.Top;
            Top3Vendidas.Enabled = false;
            Top3Vendidas.Location = new Point(0, 715);
            Top3Vendidas.Name = "Top3Vendidas";
            Top3Vendidas.Size = new Size(758, 420);
            Top3Vendidas.TabIndex = 4;
            // 
            // panelTop5Clientes
            // 
            panelTop5Clientes.BackColor = Color.White;
            panelTop5Clientes.Controls.Add(dgvTop5Clientes);
            panelTop5Clientes.Controls.Add(lblTituloTop5);
            panelTop5Clientes.Dock = DockStyle.Top;
            panelTop5Clientes.Location = new Point(0, 1135);
            panelTop5Clientes.Name = "panelTop5Clientes";
            panelTop5Clientes.Padding = new Padding(15);
            panelTop5Clientes.Size = new Size(758, 280);
            panelTop5Clientes.TabIndex = 7;
            // 
            // dgvTop5Clientes
            // 
            dgvTop5Clientes.AllowUserToAddRows = false;
            dgvTop5Clientes.AllowUserToDeleteRows = false;
            dgvTop5Clientes.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            dgvTop5Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTop5Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5Clientes.BackgroundColor = Color.White;
            dgvTop5Clientes.BorderStyle = BorderStyle.None;
            dgvTop5Clientes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTop5Clientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(37, 99, 235);
            dgvTop5Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTop5Clientes.ColumnHeadersHeight = 38;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTop5Clientes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTop5Clientes.Dock = DockStyle.Fill;
            dgvTop5Clientes.Enabled = false;
            dgvTop5Clientes.EnableHeadersVisualStyles = false;
            dgvTop5Clientes.GridColor = Color.FromArgb(226, 232, 240);
            dgvTop5Clientes.Location = new Point(15, 47);
            dgvTop5Clientes.Name = "dgvTop5Clientes";
            dgvTop5Clientes.RowHeadersWidth = 51;
            dgvTop5Clientes.RowTemplate.Height = 35;
            dgvTop5Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTop5Clientes.Size = new Size(728, 218);
            dgvTop5Clientes.TabIndex = 1;
            // 
            // lblTituloTop5
            // 
            lblTituloTop5.Dock = DockStyle.Top;
            lblTituloTop5.Location = new Point(15, 15);
            lblTituloTop5.Name = "lblTituloTop5";
            lblTituloTop5.Size = new Size(728, 32);
            lblTituloTop5.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblTituloTop5.StateCommon.ShortText.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloTop5.TabIndex = 2;
            lblTituloTop5.Values.Text = "🏆 Top 5 Clientes que Más Laptops Compraron";
            // 
            // panelGraficoAnual
            // 
            panelGraficoAnual.BackColor = Color.White;
            panelGraficoAnual.Dock = DockStyle.Top;
            panelGraficoAnual.Location = new Point(0, 1460);
            panelGraficoAnual.Name = "panelGraficoAnual";
            panelGraficoAnual.Size = new Size(758, 450);
            panelGraficoAnual.TabIndex = 5;
            // 
            // btnAlternarAnual
            // 
            btnAlternarAnual.Dock = DockStyle.Top;
            btnAlternarAnual.Location = new Point(0, 1415);
            btnAlternarAnual.Name = "btnAlternarAnual";
            btnAlternarAnual.Size = new Size(758, 45);
            btnAlternarAnual.StateCommon.Back.Color1 = Color.FromArgb(241, 245, 249);
            btnAlternarAnual.StateCommon.Back.Color2 = Color.FromArgb(241, 245, 249);
            btnAlternarAnual.StateCommon.Content.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            btnAlternarAnual.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAlternarAnual.TabIndex = 0;
            btnAlternarAnual.Values.DropDownArrowColor = Color.Empty;
            btnAlternarAnual.Values.Text = "🔄 Alternar Métrica Anual";
            btnAlternarAnual.Click += btnAlternarAnual_Click;
            // 
            // ControlReportVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(241, 245, 249);
            Controls.Add(panelGraficoAnual);
            Controls.Add(btnAlternarAnual);
            Controls.Add(panelTop5Clientes);
            Controls.Add(Top3Vendidas);
            Controls.Add(dgvReporteGrilla);
            Controls.Add(panelGrafico);
            Controls.Add(panelFiltro);
            Name = "ControlReportVentas";
            Size = new Size(758, 900);
            Load += ControlReporteVentas_Load;
            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).EndInit();
            panelTop5Clientes.ResumeLayout(false);
            panelTop5Clientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelFiltro;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Panel panelGrafico;
        private System.Windows.Forms.DataGridView dgvReporteGrilla;
        private System.Windows.Forms.Panel Top3Vendidas;
        private Krypton.Toolkit.KryptonDateTimePicker dtpHasta;
        private Krypton.Toolkit.KryptonDateTimePicker dtpDesde;
        private Krypton.Toolkit.KryptonButton exportarReporte;

        // NUEVO REPORTE TOP 5 CLIENTES
        private System.Windows.Forms.Panel panelTop5Clientes;
        private Krypton.Toolkit.KryptonLabel lblTituloTop5;
        private System.Windows.Forms.DataGridView dgvTop5Clientes;

        private System.Windows.Forms.Panel panelGraficoAnual;
        private Krypton.Toolkit.KryptonButton btnAlternarAnual;
    }
}