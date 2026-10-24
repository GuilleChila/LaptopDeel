namespace LaptopDeel
{
    partial class ControlHistorialVentas
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
            lblSubtituloGrilla = new Krypton.Toolkit.KryptonLabel();
            panelTarjetaContenedora = new Krypton.Toolkit.KryptonPanel();
            lblFiltroBuscar = new Krypton.Toolkit.KryptonLabel();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            chkUsarFiltroFecha = new Krypton.Toolkit.KryptonCheckBox();
            lblFechaInicio = new Krypton.Toolkit.KryptonLabel();
            dtpInicio = new Krypton.Toolkit.KryptonDateTimePicker();
            lblFechaFin = new Krypton.Toolkit.KryptonLabel();
            dtpFin = new Krypton.Toolkit.KryptonDateTimePicker();
            lblVendedor = new Krypton.Toolkit.KryptonLabel();
            cmbVendedor = new Krypton.Toolkit.KryptonComboBox();
            btnFiltrar = new Krypton.Toolkit.KryptonButton();
            dgvHistorial = new Krypton.Toolkit.KryptonDataGridView();

            ((System.ComponentModel.ISupportInitialize)panelTarjetaContenedora).BeginInit();
            panelTarjetaContenedora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbVendedor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).BeginInit();
            SuspendLayout();

            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(25, 18);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(330, 40);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "HISTORIAL DE VENTAS";

            // 
            // panelTarjetaContenedora
            // 
            panelTarjetaContenedora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTarjetaContenedora.Controls.Add(lblSubtituloGrilla);
            panelTarjetaContenedora.Controls.Add(lblFiltroBuscar);
            panelTarjetaContenedora.Controls.Add(txtBuscar);
            panelTarjetaContenedora.Controls.Add(chkUsarFiltroFecha);
            panelTarjetaContenedora.Controls.Add(lblFechaInicio);
            panelTarjetaContenedora.Controls.Add(dtpInicio);
            panelTarjetaContenedora.Controls.Add(lblFechaFin);
            panelTarjetaContenedora.Controls.Add(dtpFin);
            panelTarjetaContenedora.Controls.Add(lblVendedor);
            panelTarjetaContenedora.Controls.Add(cmbVendedor);
            panelTarjetaContenedora.Controls.Add(btnFiltrar);
            panelTarjetaContenedora.Controls.Add(dgvHistorial);
            panelTarjetaContenedora.Location = new Point(25, 70);
            panelTarjetaContenedora.Name = "panelTarjetaContenedora";
            panelTarjetaContenedora.Size = new Size(1070, 565);
            panelTarjetaContenedora.StateCommon.Color1 = Color.White;
            panelTarjetaContenedora.StateCommon.Color2 = Color.White;
            panelTarjetaContenedora.TabIndex = 1;

            // 
            // lblSubtituloGrilla
            // 
            lblSubtituloGrilla.Location = new Point(20, 15);
            lblSubtituloGrilla.Name = "lblSubtituloGrilla";
            lblSubtituloGrilla.Size = new Size(170, 24);
            lblSubtituloGrilla.StateCommon.ShortText.Color1 = Color.FromArgb(37, 99, 235);
            lblSubtituloGrilla.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtituloGrilla.TabIndex = 0;
            lblSubtituloGrilla.Values.Text = "VENTAS REALIZADAS";

            // 
            // lblFiltroBuscar
            // 
            lblFiltroBuscar.Location = new Point(20, 48);
            lblFiltroBuscar.Name = "lblFiltroBuscar";
            lblFiltroBuscar.Size = new Size(160, 20);
            lblFiltroBuscar.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblFiltroBuscar.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFiltroBuscar.TabIndex = 1;
            lblFiltroBuscar.Values.Text = "Buscar por Cliente / Factura:";

            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(20, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(240, 32);
            txtBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            txtBuscar.StateCommon.Border.Rounding = 8F;
            txtBuscar.TabIndex = 2;
            txtBuscar.Text = "🔍 Buscar...";
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            // 
            // chkUsarFiltroFecha
            // 
            chkUsarFiltroFecha.Location = new Point(280, 78);
            chkUsarFiltroFecha.Name = "chkUsarFiltroFecha";
            chkUsarFiltroFecha.Size = new Size(115, 20);
            chkUsarFiltroFecha.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkUsarFiltroFecha.TabIndex = 3;
            chkUsarFiltroFecha.Values.Text = "Filtrar Fechas";
            chkUsarFiltroFecha.CheckedChanged += chkUsarFiltroFecha_CheckedChanged;

            // 
            // lblFechaInicio
            // 
            lblFechaInicio.Location = new Point(405, 48);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(50, 20);
            lblFechaInicio.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblFechaInicio.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Values.Text = "Desde:";

            // 
            // dtpInicio
            // 
            dtpInicio.Enabled = false;
            dtpInicio.Format = DateTimePickerFormat.Short;
            dtpInicio.Location = new Point(405, 72);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(130, 32);
            dtpInicio.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            dtpInicio.StateCommon.Border.Rounding = 8F;
            dtpInicio.TabIndex = 5;

            // 
            // lblFechaFin
            // 
            lblFechaFin.Location = new Point(545, 48);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(48, 20);
            lblFechaFin.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblFechaFin.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblFechaFin.TabIndex = 6;
            lblFechaFin.Values.Text = "Hasta:";

            // 
            // dtpFin
            // 
            dtpFin.Enabled = false;
            dtpFin.Format = DateTimePickerFormat.Short;
            dtpFin.Location = new Point(545, 72);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(130, 32);
            dtpFin.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            dtpFin.StateCommon.Border.Rounding = 8F;
            dtpFin.TabIndex = 7;

            // 
            // lblVendedor
            // 
            lblVendedor.Location = new Point(685, 48);
            lblVendedor.Name = "lblVendedor";
            lblVendedor.Size = new Size(72, 20);
            lblVendedor.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblVendedor.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblVendedor.TabIndex = 8;
            lblVendedor.Values.Text = "Vendedor:";
            lblVendedor.Visible = false;

            // 
            // cmbVendedor
            // 
            cmbVendedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVendedor.Location = new Point(685, 72);
            cmbVendedor.Name = "cmbVendedor";
            cmbVendedor.Size = new Size(180, 32);
            cmbVendedor.StateCommon.ComboBox.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            cmbVendedor.StateCommon.ComboBox.Border.Rounding = 8F;
            cmbVendedor.TabIndex = 9;
            cmbVendedor.Visible = false;

            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFiltrar.Location = new Point(920, 70);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(130, 36);
            btnFiltrar.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnFiltrar.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnFiltrar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnFiltrar.StateCommon.Border.Rounding = 8F;
            btnFiltrar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnFiltrar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFiltrar.TabIndex = 10;
            btnFiltrar.Values.Text = "🔄 Filtrar";
            btnFiltrar.Click += btnFiltrar_Click;

            // 
            // dgvHistorial
            // 
            dgvHistorial.AllowUserToAddRows = false;
            dgvHistorial.AllowUserToDeleteRows = false;
            dgvHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorial.BorderStyle = BorderStyle.None;
            dgvHistorial.ColumnHeadersHeight = 38;
            dgvHistorial.Location = new Point(20, 120);
            dgvHistorial.Name = "dgvHistorial";
            dgvHistorial.ReadOnly = true;
            dgvHistorial.RowHeadersWidth = 35;
            dgvHistorial.RowTemplate.Height = 36;
            dgvHistorial.Size = new Size(1030, 420);
            dgvHistorial.StateCommon.Background.Color1 = Color.White;
            dgvHistorial.StateCommon.Background.Color2 = Color.White;
            dgvHistorial.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvHistorial.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(30, 41, 59);
            dgvHistorial.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(30, 41, 59);
            dgvHistorial.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvHistorial.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvHistorial.TabIndex = 11;
            dgvHistorial.CellClick += dgvHistorial_CellClick;

            // 
            // ControlHistorialVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelTarjetaContenedora);
            Controls.Add(lblTituloModulo);
            Name = "ControlHistorialVentas";
            Size = new Size(1120, 660);

            ((System.ComponentModel.ISupportInitialize)panelTarjetaContenedora).EndInit();
            panelTarjetaContenedora.ResumeLayout(false);
            panelTarjetaContenedora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbVendedor).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonPanel panelTarjetaContenedora;
        private Krypton.Toolkit.KryptonLabel lblSubtituloGrilla;
        private Krypton.Toolkit.KryptonLabel lblFiltroBuscar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonCheckBox chkUsarFiltroFecha;
        private Krypton.Toolkit.KryptonLabel lblFechaInicio;
        private Krypton.Toolkit.KryptonDateTimePicker dtpInicio;
        private Krypton.Toolkit.KryptonLabel lblFechaFin;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFin;
        private Krypton.Toolkit.KryptonLabel lblVendedor;
        private Krypton.Toolkit.KryptonComboBox cmbVendedor;
        private Krypton.Toolkit.KryptonButton btnFiltrar;
        private Krypton.Toolkit.KryptonDataGridView dgvHistorial;
    }
}