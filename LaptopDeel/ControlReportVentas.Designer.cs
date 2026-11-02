namespace LaptopDeel
{
    partial class ControlReportVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            dgvReporte = new DataGridView();
            btnGenerar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(34, 34);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 0;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(290, 34);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 1;
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(17, 98);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(768, 310);
            dgvReporte.TabIndex = 2;
            dgvReporte.CellContentClick += dgvReporte_CellContentClick;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(576, 34);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(112, 31);
            btnGenerar.TabIndex = 3;
            btnGenerar.Values.DropDownArrowColor = Color.Empty;
            btnGenerar.Values.Text = "Generar";
            btnGenerar.Click += btnGenerar_Click;
            // 
            // ControlReportVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnGenerar);
            Controls.Add(dgvReporte);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Name = "ControlReportVentas";
            Size = new Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private DataGridView dgvReporte;
        private Krypton.Toolkit.KryptonButton btnGenerar;
    }
}