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
            pnlContenedorPrincipal = new Krypton.Toolkit.KryptonPanel();
            lblMarcaModelo = new Krypton.Toolkit.KryptonLabel();
            pnlHeaderPrecios = new Krypton.Toolkit.KryptonPanel();
            lblPrecio = new Krypton.Toolkit.KryptonLabel();
            lblStockModal = new Krypton.Toolkit.KryptonLabel();
            pnlCardHardware = new Krypton.Toolkit.KryptonPanel();
            tblSpecs = new TableLayoutPanel();
            lblProcesadorTag = new Krypton.Toolkit.KryptonLabel();
            lblProcesadorVal = new Krypton.Toolkit.KryptonLabel();
            lblRamTag = new Krypton.Toolkit.KryptonLabel();
            lblRamVal = new Krypton.Toolkit.KryptonLabel();
            lblAlmacenamientoTag = new Krypton.Toolkit.KryptonLabel();
            lblAlmacenamientoVal = new Krypton.Toolkit.KryptonLabel();
            lblPantallaTag = new Krypton.Toolkit.KryptonLabel();
            lblPantallaVal = new Krypton.Toolkit.KryptonLabel();
            lblGpuTag = new Krypton.Toolkit.KryptonLabel();
            lblGpuVal = new Krypton.Toolkit.KryptonLabel();
            pnlCantidadContainer = new Krypton.Toolkit.KryptonPanel();
            lblCantidadTag = new Krypton.Toolkit.KryptonLabel();
            numCantidad = new Krypton.Toolkit.KryptonNumericUpDown();
            btnSeleccionar = new Krypton.Toolkit.KryptonButton();
            btnCerrar = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)pnlContenedorPrincipal).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeaderPrecios).BeginInit();
            pnlHeaderPrecios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCardHardware).BeginInit();
            pnlCardHardware.SuspendLayout();
            tblSpecs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCantidadContainer).BeginInit();
            pnlCantidadContainer.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Controls.Add(lblMarcaModelo);
            pnlContenedorPrincipal.Controls.Add(pnlHeaderPrecios);
            pnlContenedorPrincipal.Controls.Add(pnlCardHardware);
            pnlContenedorPrincipal.Controls.Add(pnlCantidadContainer);
            pnlContenedorPrincipal.Controls.Add(btnSeleccionar);
            pnlContenedorPrincipal.Controls.Add(btnCerrar);
            pnlContenedorPrincipal.Dock = DockStyle.Fill;
            pnlContenedorPrincipal.Location = new Point(0, 0);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(648, 529);
            pnlContenedorPrincipal.StateCommon.Color1 = Color.FromArgb(248, 250, 252);
            pnlContenedorPrincipal.StateCommon.Color2 = Color.FromArgb(248, 250, 252);
            pnlContenedorPrincipal.TabIndex = 0;
            // 
            // lblMarcaModelo
            // 
            lblMarcaModelo.Location = new Point(25, 18);
            lblMarcaModelo.Name = "lblMarcaModelo";
            lblMarcaModelo.Size = new Size(360, 41);
            lblMarcaModelo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblMarcaModelo.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMarcaModelo.TabIndex = 0;
            lblMarcaModelo.Values.Text = "Marca / Modelo Notebook";
            // 
            // pnlHeaderPrecios
            // 
            pnlHeaderPrecios.Controls.Add(lblPrecio);
            pnlHeaderPrecios.Controls.Add(lblStockModal);
            pnlHeaderPrecios.Location = new Point(25, 55);
            pnlHeaderPrecios.Name = "pnlHeaderPrecios";
            pnlHeaderPrecios.Size = new Size(590, 35);
            pnlHeaderPrecios.StateCommon.Color1 = Color.FromArgb(248, 250, 252);
            pnlHeaderPrecios.StateCommon.Color2 = Color.FromArgb(248, 250, 252);
            pnlHeaderPrecios.TabIndex = 1;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(0, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(44, 39);
            lblPrecio.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblPrecio.StateCommon.ShortText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPrecio.TabIndex = 0;
            lblPrecio.Values.Text = "$0";
            // 
            // lblStockModal
            // 
            lblStockModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStockModal.Location = new Point(-3969, 4);
            lblStockModal.Name = "lblStockModal";
            lblStockModal.Size = new Size(231, 28);
            lblStockModal.StateCommon.ShortText.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblStockModal.StateCommon.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Far;
            lblStockModal.TabIndex = 1;
            lblStockModal.Values.Text = "\U0001f7e2 Unidades Disponibles: 0";
            // 
            // pnlCardHardware
            // 
            pnlCardHardware.Controls.Add(tblSpecs);
            pnlCardHardware.Location = new Point(25, 100);
            pnlCardHardware.Name = "pnlCardHardware";
            pnlCardHardware.Padding = new Padding(15);
            pnlCardHardware.Size = new Size(590, 215);
            pnlCardHardware.StateCommon.Color1 = Color.White;
            pnlCardHardware.StateCommon.Color2 = Color.White;
            pnlCardHardware.TabIndex = 2;
            // 
            // tblSpecs
            // 
            tblSpecs.ColumnCount = 2;
            tblSpecs.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tblSpecs.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblSpecs.Controls.Add(lblProcesadorTag, 0, 0);
            tblSpecs.Controls.Add(lblProcesadorVal, 1, 0);
            tblSpecs.Controls.Add(lblRamTag, 0, 1);
            tblSpecs.Controls.Add(lblRamVal, 1, 1);
            tblSpecs.Controls.Add(lblAlmacenamientoTag, 0, 2);
            tblSpecs.Controls.Add(lblAlmacenamientoVal, 1, 2);
            tblSpecs.Controls.Add(lblPantallaTag, 0, 3);
            tblSpecs.Controls.Add(lblPantallaVal, 1, 3);
            tblSpecs.Controls.Add(lblGpuTag, 0, 4);
            tblSpecs.Controls.Add(lblGpuVal, 1, 4);
            tblSpecs.Dock = DockStyle.Fill;
            tblSpecs.Location = new Point(15, 15);
            tblSpecs.Name = "tblSpecs";
            tblSpecs.RowCount = 5;
            tblSpecs.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblSpecs.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblSpecs.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblSpecs.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblSpecs.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblSpecs.Size = new Size(560, 185);
            tblSpecs.TabIndex = 0;
            // 
            // lblProcesadorTag
            // 
            lblProcesadorTag.Location = new Point(3, 3);
            lblProcesadorTag.Name = "lblProcesadorTag";
            lblProcesadorTag.Size = new Size(102, 26);
            lblProcesadorTag.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProcesadorTag.TabIndex = 0;
            lblProcesadorTag.Values.Text = "Procesador:";
            // 
            // lblProcesadorVal
            // 
            lblProcesadorVal.Location = new Point(153, 3);
            lblProcesadorVal.Name = "lblProcesadorVal";
            lblProcesadorVal.Size = new Size(18, 26);
            lblProcesadorVal.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            lblProcesadorVal.TabIndex = 1;
            lblProcesadorVal.Values.Text = "-";
            // 
            // lblRamTag
            // 
            lblRamTag.Location = new Point(3, 40);
            lblRamTag.Name = "lblRamTag";
            lblRamTag.Size = new Size(128, 26);
            lblRamTag.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRamTag.TabIndex = 2;
            lblRamTag.Values.Text = "Memoria RAM:";
            // 
            // lblRamVal
            // 
            lblRamVal.Location = new Point(153, 40);
            lblRamVal.Name = "lblRamVal";
            lblRamVal.Size = new Size(18, 26);
            lblRamVal.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            lblRamVal.TabIndex = 3;
            lblRamVal.Values.Text = "-";
            // 
            // lblAlmacenamientoTag
            // 
            lblAlmacenamientoTag.Location = new Point(3, 77);
            lblAlmacenamientoTag.Name = "lblAlmacenamientoTag";
            lblAlmacenamientoTag.Size = new Size(146, 26);
            lblAlmacenamientoTag.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAlmacenamientoTag.TabIndex = 4;
            lblAlmacenamientoTag.Values.Text = "Almacenamiento:";
            // 
            // lblAlmacenamientoVal
            // 
            lblAlmacenamientoVal.Location = new Point(153, 77);
            lblAlmacenamientoVal.Name = "lblAlmacenamientoVal";
            lblAlmacenamientoVal.Size = new Size(18, 26);
            lblAlmacenamientoVal.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            lblAlmacenamientoVal.TabIndex = 5;
            lblAlmacenamientoVal.Values.Text = "-";
            // 
            // lblPantallaTag
            // 
            lblPantallaTag.Location = new Point(3, 114);
            lblPantallaTag.Name = "lblPantallaTag";
            lblPantallaTag.Size = new Size(78, 26);
            lblPantallaTag.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPantallaTag.TabIndex = 6;
            lblPantallaTag.Values.Text = "Pantalla:";
            // 
            // lblPantallaVal
            // 
            lblPantallaVal.Location = new Point(153, 114);
            lblPantallaVal.Name = "lblPantallaVal";
            lblPantallaVal.Size = new Size(18, 26);
            lblPantallaVal.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            lblPantallaVal.TabIndex = 7;
            lblPantallaVal.Values.Text = "-";
            // 
            // lblGpuTag
            // 
            lblGpuTag.Location = new Point(3, 151);
            lblGpuTag.Name = "lblGpuTag";
            lblGpuTag.Size = new Size(129, 26);
            lblGpuTag.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblGpuTag.TabIndex = 8;
            lblGpuTag.Values.Text = "Gráficos / GPU:";
            // 
            // lblGpuVal
            // 
            lblGpuVal.Location = new Point(153, 151);
            lblGpuVal.Name = "lblGpuVal";
            lblGpuVal.Size = new Size(18, 26);
            lblGpuVal.StateCommon.ShortText.Font = new Font("Segoe UI", 9.5F);
            lblGpuVal.TabIndex = 9;
            lblGpuVal.Values.Text = "-";
            // 
            // pnlCantidadContainer
            // 
            pnlCantidadContainer.Controls.Add(lblCantidadTag);
            pnlCantidadContainer.Controls.Add(numCantidad);
            pnlCantidadContainer.Location = new Point(25, 332);
            pnlCantidadContainer.Name = "pnlCantidadContainer";
            pnlCantidadContainer.Size = new Size(590, 45);
            pnlCantidadContainer.StateCommon.Color1 = Color.FromArgb(248, 250, 252);
            pnlCantidadContainer.StateCommon.Color2 = Color.FromArgb(248, 250, 252);
            pnlCantidadContainer.TabIndex = 3;
            // 
            // lblCantidadTag
            // 
            lblCantidadTag.Location = new Point(0, 10);
            lblCantidadTag.Name = "lblCantidadTag";
            lblCantidadTag.Size = new Size(187, 28);
            lblCantidadTag.StateCommon.ShortText.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblCantidadTag.TabIndex = 0;
            lblCantidadTag.Values.Text = "Cantidad a Comprar:";
            // 
            // numCantidad
            // 
            numCantidad.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numCantidad.Location = new Point(193, 13);
            numCantidad.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numCantidad.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(110, 29);
            numCantidad.StateCommon.Back.Color1 = Color.White;
            numCantidad.StateCommon.Content.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            numCantidad.StateCommon.Content.Padding = new Padding(4, 2, 4, 2);
            numCantidad.TabIndex = 1;
            numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Location = new Point(25, 430);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(280, 48);
            btnSeleccionar.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnSeleccionar.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnSeleccionar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnSeleccionar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnSeleccionar.TabIndex = 4;
            btnSeleccionar.Values.DropDownArrowColor = Color.Empty;
            btnSeleccionar.Values.Text = "\U0001f6d2 Agregar al Carrito";
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(335, 430);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(280, 48);
            btnCerrar.StateCommon.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnCerrar.StateCommon.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnCerrar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(51, 65, 85);
            btnCerrar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnCerrar.TabIndex = 5;
            btnCerrar.Values.DropDownArrowColor = Color.Empty;
            btnCerrar.Values.Text = "Cancelar";
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormDetalleNotebook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 529);
            Controls.Add(pnlContenedorPrincipal);
            Name = "FormDetalleNotebook";
            Load += FormDetalleNotebook_Load;
            ((System.ComponentModel.ISupportInitialize)pnlContenedorPrincipal).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            pnlContenedorPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlHeaderPrecios).EndInit();
            pnlHeaderPrecios.ResumeLayout(false);
            pnlHeaderPrecios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCardHardware).EndInit();
            pnlCardHardware.ResumeLayout(false);
            tblSpecs.ResumeLayout(false);
            tblSpecs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnlCantidadContainer).EndInit();
            pnlCantidadContainer.ResumeLayout(false);
            pnlCantidadContainer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel pnlContenedorPrincipal;
        private Krypton.Toolkit.KryptonLabel lblMarcaModelo;
        private Krypton.Toolkit.KryptonPanel pnlHeaderPrecios;
        private Krypton.Toolkit.KryptonLabel lblPrecio;
        private Krypton.Toolkit.KryptonLabel lblStockModal;
        private Krypton.Toolkit.KryptonPanel pnlCardHardware;
        private System.Windows.Forms.TableLayoutPanel tblSpecs;
        private Krypton.Toolkit.KryptonLabel lblProcesadorTag;
        private Krypton.Toolkit.KryptonLabel lblProcesadorVal;
        private Krypton.Toolkit.KryptonLabel lblRamTag;
        private Krypton.Toolkit.KryptonLabel lblRamVal;
        private Krypton.Toolkit.KryptonLabel lblAlmacenamientoTag;
        private Krypton.Toolkit.KryptonLabel lblAlmacenamientoVal;
        private Krypton.Toolkit.KryptonLabel lblPantallaTag;
        private Krypton.Toolkit.KryptonLabel lblPantallaVal;
        private Krypton.Toolkit.KryptonLabel lblGpuTag;
        private Krypton.Toolkit.KryptonLabel lblGpuVal;
        private Krypton.Toolkit.KryptonPanel pnlCantidadContainer;
        private Krypton.Toolkit.KryptonLabel lblCantidadTag;
        private Krypton.Toolkit.KryptonNumericUpDown numCantidad;
        private Krypton.Toolkit.KryptonButton btnSeleccionar;
        private Krypton.Toolkit.KryptonButton btnCerrar;
    }
}