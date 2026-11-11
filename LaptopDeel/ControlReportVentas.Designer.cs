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

            panelFiltro = new System.Windows.Forms.Panel();
            exportarReporte = new Krypton.Toolkit.KryptonButton();
            dtpHasta = new Krypton.Toolkit.KryptonDateTimePicker();
            dtpDesde = new Krypton.Toolkit.KryptonDateTimePicker();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            btnGenerar = new System.Windows.Forms.Button();
            panelGrafico = new System.Windows.Forms.Panel();
            dgvReporteGrilla = new System.Windows.Forms.DataGridView();
            Top3Vendidas = new System.Windows.Forms.Panel();

            // NUEVO CONTENEDOR TOP 5 CLIENTES
            panelTop5Clientes = new System.Windows.Forms.Panel();
            lblTituloTop5 = new Krypton.Toolkit.KryptonLabel();
            dgvTop5Clientes = new System.Windows.Forms.DataGridView();

            panelGraficoAnual = new System.Windows.Forms.Panel();
            btnAlternarAnual = new Krypton.Toolkit.KryptonButton();

            panelFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).BeginInit();
            panelTop5Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTop5Clientes).BeginInit();
            SuspendLayout();

            // 
            // panelFiltro (Tarjeta 1: Filtro de Fechas y Acciones)
            // 
            panelFiltro.BackColor = System.Drawing.Color.White;
            panelFiltro.Controls.Add(exportarReporte);
            panelFiltro.Controls.Add(dtpHasta);
            panelFiltro.Controls.Add(dtpDesde);
            panelFiltro.Controls.Add(kryptonLabel2);
            panelFiltro.Controls.Add(kryptonLabel3);
            panelFiltro.Controls.Add(btnGenerar);
            panelFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            panelFiltro.Location = new System.Drawing.Point(0, 0);
            panelFiltro.Name = "panelFiltro";
            panelFiltro.Size = new System.Drawing.Size(800, 95);
            panelFiltro.TabIndex = 1;

            // exportarReporte
            exportarReporte.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            exportarReporte.Location = new System.Drawing.Point(620, 15);
            exportarReporte.Name = "exportarReporte";
            exportarReporte.Size = new System.Drawing.Size(160, 32);
            exportarReporte.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            exportarReporte.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(16, 185, 129);
            exportarReporte.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            exportarReporte.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            exportarReporte.TabIndex = 8;
            exportarReporte.Values.Text = "📊 Exportar Excel";
            exportarReporte.Click += exportarReporte_Click;

            // dtpDesde
            dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpDesde.Location = new System.Drawing.Point(85, 45);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new System.Drawing.Size(130, 31);
            dtpDesde.StateCommon.Border.Rounding = 8F;
            dtpDesde.TabIndex = 6;

            // dtpHasta
            dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpHasta.Location = new System.Drawing.Point(295, 45);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new System.Drawing.Size(130, 31);
            dtpHasta.StateCommon.Border.Rounding = 8F;
            dtpHasta.TabIndex = 7;

            // kryptonLabel2 (Desde)
            kryptonLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel2.Location = new System.Drawing.Point(20, 48);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new System.Drawing.Size(57, 24);
            kryptonLabel2.Values.Text = "Desde:";

            // kryptonLabel3 (Hasta)
            kryptonLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            kryptonLabel3.Location = new System.Drawing.Point(235, 48);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new System.Drawing.Size(53, 24);
            kryptonLabel3.Values.Text = "Hasta:";

            // btnGenerar
            btnGenerar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            btnGenerar.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            btnGenerar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerar.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnGenerar.ForeColor = System.Drawing.Color.White;
            btnGenerar.Location = new System.Drawing.Point(445, 44);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new System.Drawing.Size(130, 32);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "🔍 Filtrar Fechas";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;

            // 
            // panelGrafico (Tarjeta 2: Gráfico de Categorías)
            // 
            panelGrafico.BackColor = System.Drawing.Color.White;
            panelGrafico.Dock = System.Windows.Forms.DockStyle.Top;
            panelGrafico.Location = new System.Drawing.Point(0, 95);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new System.Drawing.Size(800, 400);
            panelGrafico.TabIndex = 2;

            // 
            // dgvReporteGrilla (Tarjeta 3: Grilla de Categorías)
            // 
            dgvReporteGrilla.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvReporteGrilla.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReporteGrilla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteGrilla.BackgroundColor = System.Drawing.Color.White;
            dgvReporteGrilla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvReporteGrilla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteGrilla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dgvReporteGrilla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvReporteGrilla.ColumnHeadersHeight = 40;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dgvReporteGrilla.DefaultCellStyle = dataGridViewCellStyle3;
            dgvReporteGrilla.Dock = System.Windows.Forms.DockStyle.Top;
            dgvReporteGrilla.EnableHeadersVisualStyles = false;
            dgvReporteGrilla.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvReporteGrilla.Location = new System.Drawing.Point(0, 495);
            dgvReporteGrilla.Name = "dgvReporteGrilla";
            dgvReporteGrilla.RowHeadersWidth = 51;
            dgvReporteGrilla.RowTemplate.Height = 35;
            dgvReporteGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvReporteGrilla.Size = new System.Drawing.Size(800, 220);
            dgvReporteGrilla.TabIndex = 6;
            dgvReporteGrilla.CellContentClick += dgvReporte_CellContentClick;

            // 
            // Top3Vendidas (Tarjeta 4: Pie Chart Top 3 Notebooks)
            // 
            Top3Vendidas.BackColor = System.Drawing.Color.White;
            Top3Vendidas.Dock = System.Windows.Forms.DockStyle.Top;
            Top3Vendidas.Location = new System.Drawing.Point(0, 715);
            Top3Vendidas.Name = "Top3Vendidas";
            Top3Vendidas.Size = new System.Drawing.Size(800, 420);
            Top3Vendidas.TabIndex = 4;

            // 
            // panelTop5Clientes (Tarjeta 5: Ranking 5 Clientes Más Laptops)
            // 
            panelTop5Clientes.BackColor = System.Drawing.Color.White;
            panelTop5Clientes.Controls.Add(dgvTop5Clientes);
            panelTop5Clientes.Controls.Add(lblTituloTop5);
            panelTop5Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            panelTop5Clientes.Location = new System.Drawing.Point(0, 1135);
            panelTop5Clientes.Name = "panelTop5Clientes";
            panelTop5Clientes.Padding = new System.Windows.Forms.Padding(15);
            panelTop5Clientes.Size = new System.Drawing.Size(800, 280);
            panelTop5Clientes.TabIndex = 7;

            // lblTituloTop5
            lblTituloTop5.Dock = System.Windows.Forms.DockStyle.Top;
            lblTituloTop5.Location = new System.Drawing.Point(15, 15);
            lblTituloTop5.Name = "lblTituloTop5";
            lblTituloTop5.Size = new System.Drawing.Size(770, 30);
            lblTituloTop5.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTituloTop5.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTituloTop5.Values.Text = "🏆 Top 5 Clientes que Más Laptops Compraron";

            // dgvTop5Clientes
            dgvTop5Clientes.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvTop5Clientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTop5Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5Clientes.BackgroundColor = System.Drawing.Color.White;
            dgvTop5Clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dgvTop5Clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTop5Clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            dgvTop5Clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTop5Clientes.ColumnHeadersHeight = 38;

            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dgvTop5Clientes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTop5Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvTop5Clientes.EnableHeadersVisualStyles = false;
            dgvTop5Clientes.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            dgvTop5Clientes.Location = new System.Drawing.Point(15, 45);
            dgvTop5Clientes.Name = "dgvTop5Clientes";
            dgvTop5Clientes.RowHeadersWidth = 51;
            dgvTop5Clientes.RowTemplate.Height = 35;
            dgvTop5Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvTop5Clientes.Size = new System.Drawing.Size(770, 220);
            dgvTop5Clientes.TabIndex = 1;

            // 
            // btnAlternarAnual (Botón Alternar Métrica)
            // 
            btnAlternarAnual.Dock = System.Windows.Forms.DockStyle.Top;
            btnAlternarAnual.Location = new System.Drawing.Point(0, 1415);
            btnAlternarAnual.Name = "btnAlternarAnual";
            btnAlternarAnual.Size = new System.Drawing.Size(800, 45);
            btnAlternarAnual.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(241, 245, 249);
            btnAlternarAnual.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(241, 245, 249);
            btnAlternarAnual.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            btnAlternarAnual.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnAlternarAnual.TabIndex = 0;
            btnAlternarAnual.Values.Text = "🔄 Alternar Métrica Anual";
            btnAlternarAnual.Click += btnAlternarAnual_Click;

            // 
            // panelGraficoAnual (Tarjeta 6: Gráfico Anual Mensual)
            // 
            panelGraficoAnual.BackColor = System.Drawing.Color.White;
            panelGraficoAnual.Dock = System.Windows.Forms.DockStyle.Top;
            panelGraficoAnual.Location = new System.Drawing.Point(0, 1460);
            panelGraficoAnual.Name = "panelGraficoAnual";
            panelGraficoAnual.Size = new System.Drawing.Size(800, 450);
            panelGraficoAnual.TabIndex = 5;

            // 
            // ControlReportVentas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            Controls.Add(panelGraficoAnual);
            Controls.Add(btnAlternarAnual);
            Controls.Add(panelTop5Clientes);
            Controls.Add(Top3Vendidas);
            Controls.Add(dgvReporteGrilla);
            Controls.Add(panelGrafico);
            Controls.Add(panelFiltro);
            Name = "ControlReportVentas";
            Size = new System.Drawing.Size(800, 900);
            Load += ControlReporteVentas_Load;

            panelFiltro.ResumeLayout(false);
            panelFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteGrilla).EndInit();
            panelTop5Clientes.ResumeLayout(false);
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