namespace LaptopDeel
{
    partial class ControlLogs
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
            components = new System.ComponentModel.Container();
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            lblSubtituloModulo = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanelKPIs = new System.Windows.Forms.TableLayoutPanel();
            panelCardActivos = new Krypton.Toolkit.KryptonPanel();
            lblValActivos = new Krypton.Toolkit.KryptonLabel();
            lblTituloActivos = new Krypton.Toolkit.KryptonLabel();
            panelCardPromedio = new Krypton.Toolkit.KryptonPanel();
            lblValPromedio = new Krypton.Toolkit.KryptonLabel();
            lblTituloPromedio = new Krypton.Toolkit.KryptonLabel();
            panelCardIniciosHoy = new Krypton.Toolkit.KryptonPanel();
            lblValIniciosHoy = new Krypton.Toolkit.KryptonLabel();
            lblTituloIniciosHoy = new Krypton.Toolkit.KryptonLabel();
            panelTarjetaContenedora = new Krypton.Toolkit.KryptonPanel();
            lblSubtituloGrilla = new Krypton.Toolkit.KryptonLabel();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            btnRefrescar = new Krypton.Toolkit.KryptonButton();
            dgvSesiones = new Krypton.Toolkit.KryptonDataGridView();

            tableLayoutPanelKPIs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardActivos).BeginInit();
            panelCardActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardPromedio).BeginInit();
            panelCardPromedio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardIniciosHoy).BeginInit();
            panelCardIniciosHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelTarjetaContenedora).BeginInit();
            panelTarjetaContenedora.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            SuspendLayout();

            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new System.Drawing.Point(25, 18);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new System.Drawing.Size(430, 40);
            lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "MONITOREO DE SESIONES ACTIVAS";

            // 
            // lblSubtituloModulo
            // 
            lblSubtituloModulo.Location = new System.Drawing.Point(27, 58);
            lblSubtituloModulo.Name = "lblSubtituloModulo";
            lblSubtituloModulo.Size = new System.Drawing.Size(520, 22);
            lblSubtituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblSubtituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lblSubtituloModulo.TabIndex = 1;
            lblSubtituloModulo.Values.Text = "Control de usuarios actualmente conectados y auditoría del tiempo de actividad.";

            // 
            // tableLayoutPanelKPIs
            // 
            tableLayoutPanelKPIs.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelKPIs.ColumnCount = 3;
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanelKPIs.Controls.Add(panelCardActivos, 0, 0);
            tableLayoutPanelKPIs.Controls.Add(panelCardPromedio, 1, 0);
            tableLayoutPanelKPIs.Controls.Add(panelCardIniciosHoy, 2, 0);
            tableLayoutPanelKPIs.Location = new System.Drawing.Point(25, 90);
            tableLayoutPanelKPIs.Name = "tableLayoutPanelKPIs";
            tableLayoutPanelKPIs.RowCount = 1;
            tableLayoutPanelKPIs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelKPIs.Size = new System.Drawing.Size(1030, 85);
            tableLayoutPanelKPIs.TabIndex = 2;

            // 
            // panelCardActivos
            // 
            panelCardActivos.Controls.Add(lblValActivos);
            panelCardActivos.Controls.Add(lblTituloActivos);
            panelCardActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardActivos.Location = new System.Drawing.Point(3, 3);
            panelCardActivos.Name = "panelCardActivos";
            panelCardActivos.Size = new System.Drawing.Size(337, 79);
            panelCardActivos.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardActivos.StateCommon.Color2 = System.Drawing.Color.White;

            // 
            // lblTituloActivos
            // 
            lblTituloActivos.Location = new System.Drawing.Point(15, 12);
            lblTituloActivos.Name = "lblTituloActivos";
            lblTituloActivos.Size = new System.Drawing.Size(150, 20);
            lblTituloActivos.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTituloActivos.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTituloActivos.Values.Text = "🟢 Usuarios Activos";

            // 
            // lblValActivos
            // 
            lblValActivos.Location = new System.Drawing.Point(15, 34);
            lblValActivos.Name = "lblValActivos";
            lblValActivos.Size = new System.Drawing.Size(50, 36);
            lblValActivos.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            lblValActivos.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblValActivos.Values.Text = "0";

            // 
            // panelCardPromedio
            // 
            panelCardPromedio.Controls.Add(lblValPromedio);
            panelCardPromedio.Controls.Add(lblTituloPromedio);
            panelCardPromedio.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardPromedio.Location = new System.Drawing.Point(346, 3);
            panelCardPromedio.Name = "panelCardPromedio";
            panelCardPromedio.Size = new System.Drawing.Size(337, 79);
            panelCardPromedio.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardPromedio.StateCommon.Color2 = System.Drawing.Color.White;

            // 
            // lblTituloPromedio
            // 
            lblTituloPromedio.Location = new System.Drawing.Point(15, 12);
            lblTituloPromedio.Name = "lblTituloPromedio";
            lblTituloPromedio.Size = new System.Drawing.Size(160, 20);
            lblTituloPromedio.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTituloPromedio.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTituloPromedio.Values.Text = "⏱️ Tiempo Promedio";

            // 
            // lblValPromedio
            // 
            lblValPromedio.Location = new System.Drawing.Point(15, 34);
            lblValPromedio.Name = "lblValPromedio";
            lblValPromedio.Size = new System.Drawing.Size(120, 36);
            lblValPromedio.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            lblValPromedio.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblValPromedio.Values.Text = "00:00:00";

            // 
            // panelCardIniciosHoy
            // 
            panelCardIniciosHoy.Controls.Add(lblValIniciosHoy);
            panelCardIniciosHoy.Controls.Add(lblTituloIniciosHoy);
            panelCardIniciosHoy.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardIniciosHoy.Location = new System.Drawing.Point(689, 3);
            panelCardIniciosHoy.Name = "panelCardIniciosHoy";
            panelCardIniciosHoy.Size = new System.Drawing.Size(338, 79);
            panelCardIniciosHoy.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardIniciosHoy.StateCommon.Color2 = System.Drawing.Color.White;

            // 
            // lblTituloIniciosHoy
            // 
            lblTituloIniciosHoy.Location = new System.Drawing.Point(15, 12);
            lblTituloIniciosHoy.Name = "lblTituloIniciosHoy";
            lblTituloIniciosHoy.Size = new System.Drawing.Size(180, 20);
            lblTituloIniciosHoy.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblTituloIniciosHoy.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblTituloIniciosHoy.Values.Text = "👥 Inicios de Sesión Hoy";

            // 
            // lblValIniciosHoy
            // 
            lblValIniciosHoy.Location = new System.Drawing.Point(15, 34);
            lblValIniciosHoy.Name = "lblValIniciosHoy";
            lblValIniciosHoy.Size = new System.Drawing.Size(50, 36);
            lblValIniciosHoy.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(71, 85, 105);
            lblValIniciosHoy.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            lblValIniciosHoy.Values.Text = "0";

            // 
            // panelTarjetaContenedora
            // 
            panelTarjetaContenedora.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            panelTarjetaContenedora.Controls.Add(lblSubtituloGrilla);
            panelTarjetaContenedora.Controls.Add(txtBuscar);
            panelTarjetaContenedora.Controls.Add(btnRefrescar);
            panelTarjetaContenedora.Controls.Add(dgvSesiones);
            panelTarjetaContenedora.Location = new System.Drawing.Point(25, 185);
            panelTarjetaContenedora.Name = "panelTarjetaContenedora";
            panelTarjetaContenedora.Size = new System.Drawing.Size(1030, 410);
            panelTarjetaContenedora.StateCommon.Color1 = System.Drawing.Color.White;
            panelTarjetaContenedora.StateCommon.Color2 = System.Drawing.Color.White;
            panelTarjetaContenedora.TabIndex = 3;

            // 
            // lblSubtituloGrilla
            // 
            lblSubtituloGrilla.Location = new System.Drawing.Point(20, 18);
            lblSubtituloGrilla.Name = "lblSubtituloGrilla";
            lblSubtituloGrilla.Size = new System.Drawing.Size(180, 24);
            lblSubtituloGrilla.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            lblSubtituloGrilla.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblSubtituloGrilla.Values.Text = "LISTADO DE SESIONES";

            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtBuscar.Location = new System.Drawing.Point(20, 52);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(810, 35);
            txtBuscar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            txtBuscar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(203, 213, 225);
            txtBuscar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            txtBuscar.StateCommon.Border.Rounding = 8F;
            txtBuscar.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtBuscar.CueHint.CueHintText = "🔍 Buscar por Usuario o Correo...";
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;

            // 
            // btnRefrescar
            // 
            btnRefrescar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnRefrescar.Location = new System.Drawing.Point(840, 52);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new System.Drawing.Size(170, 35);
            btnRefrescar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnRefrescar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnRefrescar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnRefrescar.StateCommon.Border.Rounding = 8F;
            btnRefrescar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnRefrescar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Values.Text = "🔄 Refrescar Listado";
            btnRefrescar.Click += btnRefrescar_Click;

            // 
            // dgvSesiones
            // 
            dgvSesiones.AllowUserToAddRows = false;
            dgvSesiones.AllowUserToDeleteRows = false;
            dgvSesiones.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvSesiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSesiones.Location = new System.Drawing.Point(20, 100);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.ReadOnly = true;
            dgvSesiones.RowHeadersVisible = false;
            dgvSesiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSesiones.Size = new System.Drawing.Size(990, 290);
            dgvSesiones.TabIndex = 2;

            // 
            // ControlLogs
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            Controls.Add(lblTituloModulo);
            Controls.Add(lblSubtituloModulo);
            Controls.Add(tableLayoutPanelKPIs);
            Controls.Add(panelTarjetaContenedora);
            Name = "ControlLogs";
            Size = new System.Drawing.Size(1080, 620);
            Load += ControlLogs_Load;

            tableLayoutPanelKPIs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardActivos).EndInit();
            panelCardActivos.ResumeLayout(false);
            panelCardActivos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardPromedio).EndInit();
            panelCardPromedio.ResumeLayout(false);
            panelCardPromedio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardIniciosHoy).EndInit();
            panelCardIniciosHoy.ResumeLayout(false);
            panelCardIniciosHoy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelTarjetaContenedora).EndInit();
            panelTarjetaContenedora.ResumeLayout(false);
            panelTarjetaContenedora.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonLabel lblSubtituloModulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelKPIs;
        private Krypton.Toolkit.KryptonPanel panelCardActivos;
        private Krypton.Toolkit.KryptonLabel lblValActivos;
        private Krypton.Toolkit.KryptonLabel lblTituloActivos;
        private Krypton.Toolkit.KryptonPanel panelCardPromedio;
        private Krypton.Toolkit.KryptonLabel lblValPromedio;
        private Krypton.Toolkit.KryptonLabel lblTituloPromedio;
        private Krypton.Toolkit.KryptonPanel panelCardIniciosHoy;
        private Krypton.Toolkit.KryptonLabel lblValIniciosHoy;
        private Krypton.Toolkit.KryptonLabel lblTituloIniciosHoy;
        private Krypton.Toolkit.KryptonPanel panelTarjetaContenedora;
        private Krypton.Toolkit.KryptonLabel lblSubtituloGrilla;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonButton btnRefrescar;
        private Krypton.Toolkit.KryptonDataGridView dgvSesiones;
    }
}