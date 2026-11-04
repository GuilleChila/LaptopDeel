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
            components = new System.ComponentModel.Container();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            panel1 = new Panel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            dtpDesde = new DateTimePicker();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            dtpHasta = new DateTimePicker();
            btnGenerar = new Button();
            panelGrafico = new Panel();
            dgvReporte = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Dock = DockStyle.Top;
            kryptonLabel1.Location = new Point(0, 0);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(941, 41);
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonLabel1.TabIndex = 0;
            kryptonLabel1.Values.Text = " Dashboard de Ingresos por Categorías";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(kryptonLabel2);
            panel1.Controls.Add(dtpDesde);
            panel1.Controls.Add(kryptonLabel3);
            panel1.Controls.Add(dtpHasta);
            panel1.Controls.Add(btnGenerar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 70);
            panel1.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(20, 22);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(57, 24);
            kryptonLabel2.TabIndex = 0;
            kryptonLabel2.Values.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(80, 21);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(230, 27);
            dtpDesde.TabIndex = 1;
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new Point(330, 22);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new Size(53, 24);
            kryptonLabel3.TabIndex = 2;
            kryptonLabel3.Values.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(386, 21);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(230, 27);
            dtpHasta.TabIndex = 3;
            // 
            // btnGenerar
            // 
            btnGenerar.BackColor = Color.FromArgb(41, 128, 185);
            btnGenerar.Cursor = Cursors.Hand;
            btnGenerar.FlatAppearance.BorderSize = 0;
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(640, 19);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(110, 31);
            btnGenerar.TabIndex = 4;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // panelGrafico
            // 
            panelGrafico.BackColor = Color.White;
            panelGrafico.Dock = DockStyle.Top;
            panelGrafico.Location = new Point(0, 111);
            panelGrafico.Name = "panelGrafico";
            panelGrafico.Size = new Size(941, 350);
            panelGrafico.TabIndex = 2;
            // 
            // dgvReporte
            // 
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = SystemColors.ButtonHighlight;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Dock = DockStyle.Top;
            dgvReporte.Location = new Point(0, 461);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(941, 250);
            dgvReporte.TabIndex = 3;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Font = new Font("Segoe UI", 9F);
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new Point(0, 0);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new Size(48, 24);
            kryptonLabel4.TabIndex = 4;
            // 
            // ControlReportVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(dgvReporte);
            Controls.Add(panelGrafico);
            Controls.Add(panel1);
            Controls.Add(kryptonLabel1);
            Name = "ControlReportVentas";
            Size = new Size(941, 800);
            Load += ControlReporteVentas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Panel panel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private DateTimePicker dtpDesde;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private DateTimePicker dtpHasta;
        private Button btnGenerar;
        private Panel panelGrafico;
        private DataGridView dgvReporte;
        private ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}