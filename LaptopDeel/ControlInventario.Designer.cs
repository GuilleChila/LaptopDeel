namespace LaptopDeel
{
    partial class ControlInventario
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
            this.btnVerNotebooks = new Krypton.Toolkit.KryptonButton();
            this.btnVerComponentes = new Krypton.Toolkit.KryptonButton();
            this.pnlContenedor = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenedor)).BeginInit();
            this.SuspendLayout();

            // 
            // btnVerNotebooks
            // 
            this.btnVerNotebooks.Location = new System.Drawing.Point(20, 15);
            this.btnVerNotebooks.Name = "btnVerNotebooks";
            this.btnVerNotebooks.Size = new System.Drawing.Size(160, 40);
            this.btnVerNotebooks.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerNotebooks.TabIndex = 0;
            this.btnVerNotebooks.Values.Text = "💻 Ver Notebooks";
            this.btnVerNotebooks.Click += new System.EventHandler(this.btnVerNotebooks_Click);

            // 
            // btnVerComponentes
            // 
            this.btnVerComponentes.Location = new System.Drawing.Point(190, 15);
            this.btnVerComponentes.Name = "btnVerComponentes";
            this.btnVerComponentes.Size = new System.Drawing.Size(180, 40);
            this.btnVerComponentes.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerComponentes.TabIndex = 1;
            this.btnVerComponentes.Values.Text = "⚙️ Ver Componentes";
            this.btnVerComponentes.Click += new System.EventHandler(this.btnVerComponentes_Click);

            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.Location = new System.Drawing.Point(20, 70);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1040, 550);
            this.pnlContenedor.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.pnlContenedor.TabIndex = 2;

            // 
            // ControlInventario (Padre)
            // 
            this.BackColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.btnVerComponentes);
            this.Controls.Add(this.btnVerNotebooks);
            this.Name = "ControlInventario";
            this.Size = new System.Drawing.Size(1080, 640);
            this.Load += new System.EventHandler(this.ControlInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pnlContenedor)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnVerNotebooks;
        private Krypton.Toolkit.KryptonButton btnVerComponentes;
        private Krypton.Toolkit.KryptonPanel pnlContenedor;
    }
}