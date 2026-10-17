namespace LaptopDeel
{
    partial class FormDetalleNotebook
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
            this.lblMarcaModelo = new Krypton.Toolkit.KryptonLabel();
            this.lblPrecio = new Krypton.Toolkit.KryptonLabel();
            this.lblStockModal = new Krypton.Toolkit.KryptonLabel();
            this.panelBadges = new Krypton.Toolkit.KryptonPanel();
            this.lblProcesadorTit = new Krypton.Toolkit.KryptonLabel();
            this.lblProcesadorVal = new Krypton.Toolkit.KryptonLabel();
            this.lblRamTit = new Krypton.Toolkit.KryptonLabel();
            this.lblRamVal = new Krypton.Toolkit.KryptonLabel();
            this.lblAlmacenamientoTit = new Krypton.Toolkit.KryptonLabel();
            this.lblAlmacenamientoVal = new Krypton.Toolkit.KryptonLabel();
            this.lblPantallaTit = new Krypton.Toolkit.KryptonLabel();
            this.lblPantallaVal = new Krypton.Toolkit.KryptonLabel();
            this.lblGpuTit = new Krypton.Toolkit.KryptonLabel();
            this.lblGpuVal = new Krypton.Toolkit.KryptonLabel();
            this.btnSeleccionar = new Krypton.Toolkit.KryptonButton();
            this.btnCerrar = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelBadges)).BeginInit();
            this.panelBadges.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblMarcaModelo
            // 
            this.lblMarcaModelo.Location = new System.Drawing.Point(25, 20);
            this.lblMarcaModelo.Name = "lblMarcaModelo";
            this.lblMarcaModelo.Size = new System.Drawing.Size(350, 32);
            this.lblMarcaModelo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMarcaModelo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMarcaModelo.Values.Text = "Marca Modelo";

            // 
            // lblPrecio
            // 
            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Location = new System.Drawing.Point(400, 20);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(140, 35);
            this.lblPrecio.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.lblPrecio.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Values.Text = "$0";

            // 
            // lblStockModal
            // 
            this.lblStockModal.Location = new System.Drawing.Point(25, 58);
            this.lblStockModal.Name = "lblStockModal";
            this.lblStockModal.Size = new System.Drawing.Size(250, 22);
            this.lblStockModal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStockModal.Values.Text = "Stock: Verificando...";

            // 
            // panelBadges (Contenedor de Tarjetas de Hardware)
            // 
            this.panelBadges.Controls.Add(this.lblProcesadorTit);
            this.panelBadges.Controls.Add(this.lblProcesadorVal);
            this.panelBadges.Controls.Add(this.lblRamTit);
            this.panelBadges.Controls.Add(this.lblRamVal);
            this.panelBadges.Controls.Add(this.lblAlmacenamientoTit);
            this.panelBadges.Controls.Add(this.lblAlmacenamientoVal);
            this.panelBadges.Controls.Add(this.lblPantallaTit);
            this.panelBadges.Controls.Add(this.lblPantallaVal);
            this.panelBadges.Controls.Add(this.lblGpuTit);
            this.panelBadges.Controls.Add(this.lblGpuVal);
            this.panelBadges.Location = new System.Drawing.Point(25, 95);
            this.panelBadges.Name = "panelBadges";
            this.panelBadges.Size = new System.Drawing.Size(515, 260);
            this.panelBadges.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelBadges.StateCommon.Color2 = System.Drawing.Color.White;

            // Badges / Etiquetas internas
            this.lblProcesadorTit.Location = new System.Drawing.Point(20, 15);
            this.lblProcesadorTit.Values.Text = "PROCESADOR:";
            this.lblProcesadorTit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProcesadorVal.Location = new System.Drawing.Point(180, 15);

            this.lblRamTit.Location = new System.Drawing.Point(20, 60);
            this.lblRamTit.Values.Text = "MEMORIA RAM:";
            this.lblRamTit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRamVal.Location = new System.Drawing.Point(180, 60);

            this.lblAlmacenamientoTit.Location = new System.Drawing.Point(20, 105);
            this.lblAlmacenamientoTit.Values.Text = "ALMACENAMIENTO:";
            this.lblAlmacenamientoTit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlmacenamientoVal.Location = new System.Drawing.Point(180, 105);

            this.lblPantallaTit.Location = new System.Drawing.Point(20, 150);
            this.lblPantallaTit.Values.Text = "PANTALLA:";
            this.lblPantallaTit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPantallaVal.Location = new System.Drawing.Point(180, 150);

            this.lblGpuTit.Location = new System.Drawing.Point(20, 195);
            this.lblGpuTit.Values.Text = "GRÁFICOS / GPU:";
            this.lblGpuTit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGpuVal.Location = new System.Drawing.Point(180, 195);

            // 
            // btnSeleccionar (🛒 Seleccionar Laptop)
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(340, 380);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(200, 45);
            this.btnSeleccionar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSeleccionar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSeleccionar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSeleccionar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSeleccionar.Values.Text = "Seleccionar Laptop";
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);

            // 
            // btnCerrar (❌ Cerrar Modal)
            // 
            this.btnCerrar.Location = new System.Drawing.Point(180, 380);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(140, 45);
            this.btnCerrar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCerrar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnCerrar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnCerrar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Values.Text = "Cerrar";
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // 
            // FormDetalleNotebook
            // 
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.panelBadges);
            this.Controls.Add(this.lblStockModal);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblMarcaModelo);
            this.Name = "FormDetalleNotebook";

            ((System.ComponentModel.ISupportInitialize)(this.panelBadges)).EndInit();
            this.panelBadges.ResumeLayout(false);
            this.panelBadges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblMarcaModelo;
        private Krypton.Toolkit.KryptonLabel lblPrecio;
        private Krypton.Toolkit.KryptonLabel lblStockModal;
        private Krypton.Toolkit.KryptonPanel panelBadges;
        private Krypton.Toolkit.KryptonLabel lblProcesadorTit;
        private Krypton.Toolkit.KryptonLabel lblProcesadorVal;
        private Krypton.Toolkit.KryptonLabel lblRamTit;
        private Krypton.Toolkit.KryptonLabel lblRamVal;
        private Krypton.Toolkit.KryptonLabel lblAlmacenamientoTit;
        private Krypton.Toolkit.KryptonLabel lblAlmacenamientoVal;
        private Krypton.Toolkit.KryptonLabel lblPantallaTit;
        private Krypton.Toolkit.KryptonLabel lblPantallaVal;
        private Krypton.Toolkit.KryptonLabel lblGpuTit;
        private Krypton.Toolkit.KryptonLabel lblGpuVal;
        private Krypton.Toolkit.KryptonButton btnSeleccionar;
        private Krypton.Toolkit.KryptonButton btnCerrar;
    }
}