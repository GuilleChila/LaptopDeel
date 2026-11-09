namespace LaptopDeel
{
    partial class ControlRespaldo
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
            lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            tableLayoutPanelContenedor = new System.Windows.Forms.TableLayoutPanel();
            panelCardLocal = new Krypton.Toolkit.KryptonPanel();
            lblTituloCardLocal = new Krypton.Toolkit.KryptonLabel();
            lblRutaDestino = new Krypton.Toolkit.KryptonLabel();
            txtRutaLocal = new Krypton.Toolkit.KryptonTextBox();
            btnExaminar = new Krypton.Toolkit.KryptonButton();
            btnGenerarLocal = new Krypton.Toolkit.KryptonButton();
            panelCardNube = new Krypton.Toolkit.KryptonPanel();
            lblTituloCardNube = new Krypton.Toolkit.KryptonLabel();
            lblEstadoGoogle = new Krypton.Toolkit.KryptonLabel();
            btnConectarGoogle = new Krypton.Toolkit.KryptonButton();
            btnSubirGoogleDrive = new Krypton.Toolkit.KryptonButton();
            panelCardHistorial = new Krypton.Toolkit.KryptonPanel();
            lblTituloHistorial = new Krypton.Toolkit.KryptonLabel();
            dgvHistorialRespaldos = new Krypton.Toolkit.KryptonDataGridView();
            progressBarRespaldo = new System.Windows.Forms.ProgressBar();

            tableLayoutPanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardLocal).BeginInit();
            panelCardLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardNube).BeginInit();
            panelCardNube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardHistorial).BeginInit();
            panelCardHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialRespaldos).BeginInit();
            SuspendLayout();

            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new System.Drawing.Point(25, 20);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new System.Drawing.Size(650, 40);
            lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Respaldo y Copias de Seguridad de la Base de Datos";

            // 
            // tableLayoutPanelContenedor
            // 
            tableLayoutPanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanelContenedor.ColumnCount = 2;
            tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanelContenedor.Controls.Add(panelCardLocal, 0, 0);
            tableLayoutPanelContenedor.Controls.Add(panelCardNube, 1, 0);
            tableLayoutPanelContenedor.Controls.Add(panelCardHistorial, 0, 1);
            tableLayoutPanelContenedor.SetColumnSpan(panelCardHistorial, 2);
            tableLayoutPanelContenedor.Location = new System.Drawing.Point(25, 75);
            tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            tableLayoutPanelContenedor.RowCount = 2;
            tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            tableLayoutPanelContenedor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanelContenedor.Size = new System.Drawing.Size(1030, 525);
            tableLayoutPanelContenedor.TabIndex = 1;

            // 
            // panelCardLocal
            // 
            panelCardLocal.Controls.Add(lblTituloCardLocal);
            panelCardLocal.Controls.Add(lblRutaDestino);
            panelCardLocal.Controls.Add(txtRutaLocal);
            panelCardLocal.Controls.Add(btnExaminar);
            panelCardLocal.Controls.Add(btnGenerarLocal);
            panelCardLocal.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardLocal.Location = new System.Drawing.Point(3, 3);
            panelCardLocal.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            panelCardLocal.Name = "panelCardLocal";
            panelCardLocal.Size = new System.Drawing.Size(502, 184);
            panelCardLocal.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardLocal.StateCommon.Color2 = System.Drawing.Color.White;
            panelCardLocal.TabIndex = 0;

            // lblTituloCardLocal
            lblTituloCardLocal.Location = new System.Drawing.Point(20, 15);
            lblTituloCardLocal.Name = "lblTituloCardLocal";
            lblTituloCardLocal.Size = new System.Drawing.Size(260, 26);
            lblTituloCardLocal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloCardLocal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTituloCardLocal.Values.Text = "💻 Almacenamiento Local / USB";

            // lblRutaDestino
            lblRutaDestino.Location = new System.Drawing.Point(20, 50);
            lblRutaDestino.Name = "lblRutaDestino";
            lblRutaDestino.Size = new System.Drawing.Size(105, 20);
            lblRutaDestino.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            lblRutaDestino.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblRutaDestino.Values.Text = "Ruta de Destino:";

            // txtRutaLocal
            txtRutaLocal.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txtRutaLocal.Location = new System.Drawing.Point(20, 75);
            txtRutaLocal.Name = "txtRutaLocal";
            txtRutaLocal.ReadOnly = true;
            txtRutaLocal.Size = new System.Drawing.Size(335, 33);
            txtRutaLocal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(241, 245, 249);
            txtRutaLocal.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(203, 213, 225);
            txtRutaLocal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            txtRutaLocal.StateCommon.Border.Rounding = 8F;
            txtRutaLocal.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txtRutaLocal.TabIndex = 0;
            txtRutaLocal.Text = "D:\\Backups\\Database_2026_11_08_2230.sql";

            // btnExaminar
            btnExaminar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnExaminar.Location = new System.Drawing.Point(363, 75);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new System.Drawing.Size(120, 33);
            btnExaminar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(100, 116, 139);
            btnExaminar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(100, 116, 139);
            btnExaminar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnExaminar.StateCommon.Border.Rounding = 8F;
            btnExaminar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnExaminar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnExaminar.TabIndex = 1;
            btnExaminar.Values.Text = "📁 Examinar...";
            btnExaminar.Click += btnExaminar_Click;

            // btnGenerarLocal
            btnGenerarLocal.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnGenerarLocal.Location = new System.Drawing.Point(20, 125);
            btnGenerarLocal.Name = "btnGenerarLocal";
            btnGenerarLocal.Size = new System.Drawing.Size(463, 40);
            btnGenerarLocal.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnGenerarLocal.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnGenerarLocal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnGenerarLocal.StateCommon.Border.Rounding = 8F;
            btnGenerarLocal.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnGenerarLocal.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnGenerarLocal.TabIndex = 2;
            btnGenerarLocal.Values.Text = "💾 Generar Respaldo Local / USB";
            btnGenerarLocal.Click += btnGenerarLocal_Click;

            // 
            // panelCardNube
            // 
            panelCardNube.Controls.Add(lblTituloCardNube);
            panelCardNube.Controls.Add(lblEstadoGoogle);
            panelCardNube.Controls.Add(btnConectarGoogle);
            panelCardNube.Controls.Add(btnSubirGoogleDrive);
            panelCardNube.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardNube.Location = new System.Drawing.Point(525, 3);
            panelCardNube.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            panelCardNube.Name = "panelCardNube";
            panelCardNube.Size = new System.Drawing.Size(502, 184);
            panelCardNube.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardNube.StateCommon.Color2 = System.Drawing.Color.White;
            panelCardNube.TabIndex = 1;

            // lblTituloCardNube
            lblTituloCardNube.Location = new System.Drawing.Point(20, 15);
            lblTituloCardNube.Name = "lblTituloCardNube";
            lblTituloCardNube.Size = new System.Drawing.Size(265, 26);
            lblTituloCardNube.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloCardNube.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTituloCardNube.Values.Text = "☁️ Copia de Seguridad en la Nube";

            // lblEstadoGoogle
            lblEstadoGoogle.Location = new System.Drawing.Point(20, 50);
            lblEstadoGoogle.Name = "lblEstadoGoogle";
            lblEstadoGoogle.Size = new System.Drawing.Size(315, 20);
            lblEstadoGoogle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            lblEstadoGoogle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblEstadoGoogle.Values.Text = "🟢 Vinculado como gerencia@laptopdeel.com";

            // btnConectarGoogle
            btnConectarGoogle.Location = new System.Drawing.Point(20, 125);
            btnConectarGoogle.Name = "btnConectarGoogle";
            btnConectarGoogle.Size = new System.Drawing.Size(210, 40);
            btnConectarGoogle.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnConectarGoogle.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnConectarGoogle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnConectarGoogle.StateCommon.Border.Rounding = 8F;
            btnConectarGoogle.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnConectarGoogle.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnConectarGoogle.TabIndex = 0;
            btnConectarGoogle.Values.Text = "🔑 Conectar Cuenta Google";
            btnConectarGoogle.Click += btnConectarGoogle_Click;

            // btnSubirGoogleDrive
            btnSubirGoogleDrive.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnSubirGoogleDrive.Location = new System.Drawing.Point(240, 125);
            btnSubirGoogleDrive.Name = "btnSubirGoogleDrive";
            btnSubirGoogleDrive.Size = new System.Drawing.Size(242, 40);
            btnSubirGoogleDrive.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSubirGoogleDrive.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            btnSubirGoogleDrive.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.All;
            btnSubirGoogleDrive.StateCommon.Border.Rounding = 8F;
            btnSubirGoogleDrive.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            btnSubirGoogleDrive.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btnSubirGoogleDrive.TabIndex = 1;
            btnSubirGoogleDrive.Values.Text = "Generar y Subir a Google Drive";
            btnSubirGoogleDrive.Click += btnSubirGoogleDrive_Click;

            // 
            // panelCardHistorial
            // 
            panelCardHistorial.Controls.Add(lblTituloHistorial);
            panelCardHistorial.Controls.Add(dgvHistorialRespaldos);
            panelCardHistorial.Controls.Add(progressBarRespaldo);
            panelCardHistorial.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCardHistorial.Location = new System.Drawing.Point(3, 205);
            panelCardHistorial.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            panelCardHistorial.Name = "panelCardHistorial";
            panelCardHistorial.Size = new System.Drawing.Size(1024, 317);
            panelCardHistorial.StateCommon.Color1 = System.Drawing.Color.White;
            panelCardHistorial.StateCommon.Color2 = System.Drawing.Color.White;
            panelCardHistorial.TabIndex = 2;

            // lblTituloHistorial
            lblTituloHistorial.Location = new System.Drawing.Point(20, 15);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new System.Drawing.Size(275, 26);
            lblTituloHistorial.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloHistorial.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTituloHistorial.Values.Text = "Historial de Respaldos Recientes";

            // dgvHistorialRespaldos
            dgvHistorialRespaldos.AllowUserToAddRows = false;
            dgvHistorialRespaldos.AllowUserToDeleteRows = false;
            dgvHistorialRespaldos.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            dgvHistorialRespaldos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialRespaldos.Location = new System.Drawing.Point(20, 55);
            dgvHistorialRespaldos.Name = "dgvHistorialRespaldos";
            dgvHistorialRespaldos.ReadOnly = true;
            dgvHistorialRespaldos.RowHeadersVisible = false;
            dgvHistorialRespaldos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialRespaldos.Size = new System.Drawing.Size(984, 230);
            dgvHistorialRespaldos.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvHistorialRespaldos.TabIndex = 0;

            // progressBarRespaldo
            progressBarRespaldo.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            progressBarRespaldo.Location = new System.Drawing.Point(20, 292);
            progressBarRespaldo.Name = "progressBarRespaldo";
            progressBarRespaldo.Size = new System.Drawing.Size(984, 10);
            progressBarRespaldo.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            progressBarRespaldo.TabIndex = 1;
            progressBarRespaldo.Visible = false;

            // ControlRespaldo
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            Controls.Add(lblTituloModulo);
            Controls.Add(tableLayoutPanelContenedor);
            Name = "ControlRespaldo";
            Size = new System.Drawing.Size(1080, 620);

            tableLayoutPanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardLocal).EndInit();
            panelCardLocal.ResumeLayout(false);
            panelCardLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardNube).EndInit();
            panelCardNube.ResumeLayout(false);
            panelCardNube.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardHistorial).EndInit();
            panelCardHistorial.ResumeLayout(false);
            panelCardHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialRespaldos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedor;
        private Krypton.Toolkit.KryptonPanel panelCardLocal;
        private Krypton.Toolkit.KryptonLabel lblTituloCardLocal;
        private Krypton.Toolkit.KryptonLabel lblRutaDestino;
        private Krypton.Toolkit.KryptonTextBox txtRutaLocal;
        private Krypton.Toolkit.KryptonButton btnExaminar;
        private Krypton.Toolkit.KryptonButton btnGenerarLocal;
        private Krypton.Toolkit.KryptonPanel panelCardNube;
        private Krypton.Toolkit.KryptonLabel lblTituloCardNube;
        private Krypton.Toolkit.KryptonLabel lblEstadoGoogle;
        private Krypton.Toolkit.KryptonButton btnConectarGoogle;
        private Krypton.Toolkit.KryptonButton btnSubirGoogleDrive;
        private Krypton.Toolkit.KryptonPanel panelCardHistorial;
        private Krypton.Toolkit.KryptonLabel lblTituloHistorial;
        private Krypton.Toolkit.KryptonDataGridView dgvHistorialRespaldos;
        private System.Windows.Forms.ProgressBar progressBarRespaldo;
    }
}