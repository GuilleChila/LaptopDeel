namespace LaptopDeel
{
    partial class ControlRespaldo
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
            tableLayoutPanelContenedor = new TableLayoutPanel();
            panelCardLocal = new Krypton.Toolkit.KryptonPanel();
            lblTituloCardLocal = new Krypton.Toolkit.KryptonLabel();
            lblRutaDestino = new Krypton.Toolkit.KryptonLabel();
            txtRutaLocal = new Krypton.Toolkit.KryptonTextBox();
            btnExaminar = new Krypton.Toolkit.KryptonButton();
            btnGenerarLocal = new Krypton.Toolkit.KryptonButton();
            panelCardNube = new Krypton.Toolkit.KryptonPanel();
            lblTituloCardNube = new Krypton.Toolkit.KryptonLabel();
            lblEstadoGoogle = new Krypton.Toolkit.KryptonLabel();
            tableLayoutBotonesNube = new TableLayoutPanel();
            btnConectarGoogle = new Krypton.Toolkit.KryptonButton();
            btnDesconectarGoogle = new Krypton.Toolkit.KryptonButton();
            btnSubirGoogleDrive = new Krypton.Toolkit.KryptonButton();
            panelCardHistorial = new Krypton.Toolkit.KryptonPanel();
            lblTituloHistorial = new Krypton.Toolkit.KryptonLabel();
            dgvHistorialRespaldos = new Krypton.Toolkit.KryptonDataGridView();
            progressBarRespaldo = new ProgressBar();
            tableLayoutPanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardLocal).BeginInit();
            panelCardLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardNube).BeginInit();
            panelCardNube.SuspendLayout();
            tableLayoutBotonesNube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardHistorial).BeginInit();
            panelCardHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistorialRespaldos).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(29, 27);
            lblTituloModulo.Margin = new Padding(3, 4, 3, 4);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(771, 46);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Respaldo y Copias de Seguridad de la Base de Datos";
            // 
            // tableLayoutPanelContenedor
            // 
            tableLayoutPanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelContenedor.ColumnCount = 2;
            tableLayoutPanelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelContenedor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelContenedor.Controls.Add(panelCardLocal, 0, 0);
            tableLayoutPanelContenedor.Controls.Add(panelCardNube, 1, 0);
            tableLayoutPanelContenedor.Controls.Add(panelCardHistorial, 0, 1);
            tableLayoutPanelContenedor.Location = new Point(29, 93);
            tableLayoutPanelContenedor.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelContenedor.Name = "tableLayoutPanelContenedor";
            tableLayoutPanelContenedor.RowCount = 2;
            tableLayoutPanelContenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 280F));
            tableLayoutPanelContenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelContenedor.Size = new Size(1177, 707);
            tableLayoutPanelContenedor.TabIndex = 1;
            // 
            // panelCardLocal
            // 
            panelCardLocal.Controls.Add(lblTituloCardLocal);
            panelCardLocal.Controls.Add(lblRutaDestino);
            panelCardLocal.Controls.Add(txtRutaLocal);
            panelCardLocal.Controls.Add(btnExaminar);
            panelCardLocal.Controls.Add(btnGenerarLocal);
            panelCardLocal.Dock = DockStyle.Fill;
            panelCardLocal.Location = new Point(3, 4);
            panelCardLocal.Margin = new Padding(3, 4, 9, 4);
            panelCardLocal.Name = "panelCardLocal";
            panelCardLocal.Size = new Size(576, 272);
            panelCardLocal.StateCommon.Color1 = Color.White;
            panelCardLocal.StateCommon.Color2 = Color.White;
            panelCardLocal.TabIndex = 0;
            // 
            // lblTituloCardLocal
            // 
            lblTituloCardLocal.AutoSize = false;
            lblTituloCardLocal.Location = new System.Drawing.Point(18, 12);
            lblTituloCardLocal.Name = "lblTituloCardLocal";
            lblTituloCardLocal.Size = new System.Drawing.Size(350, 30);
            lblTituloCardLocal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloCardLocal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            lblTituloCardLocal.Values.Text = "💻 Almacenamiento Local / USB ";
            // 
            // lblRutaDestino
            // 
            lblRutaDestino.Location = new Point(21, 60);
            lblRutaDestino.Margin = new Padding(3, 4, 3, 4);
            lblRutaDestino.Name = "lblRutaDestino";
            lblRutaDestino.Size = new Size(125, 23);
            lblRutaDestino.StateCommon.ShortText.Color1 = Color.FromArgb(100, 116, 139);
            lblRutaDestino.StateCommon.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRutaDestino.TabIndex = 1;
            lblRutaDestino.Values.Text = "Ruta de Destino:";
            // 
            // txtRutaLocal
            // 
            txtRutaLocal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRutaLocal.Location = new Point(21, 93);
            txtRutaLocal.Margin = new Padding(3, 4, 3, 4);
            txtRutaLocal.Name = "txtRutaLocal";
            txtRutaLocal.ReadOnly = true;
            txtRutaLocal.Size = new Size(400, 30);
            txtRutaLocal.StateCommon.Back.Color1 = Color.FromArgb(241, 245, 249);
            txtRutaLocal.StateCommon.Border.Color1 = Color.FromArgb(203, 213, 225);
            txtRutaLocal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            txtRutaLocal.StateCommon.Border.Rounding = 6F;
            txtRutaLocal.StateCommon.Content.Font = new Font("Segoe UI", 8.5F);
            txtRutaLocal.TabIndex = 0;
            // 
            // btnExaminar
            // 
            btnExaminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExaminar.Location = new Point(430, 93);
            btnExaminar.Margin = new Padding(3, 4, 3, 4);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(126, 41);
            btnExaminar.StateCommon.Back.Color1 = Color.FromArgb(100, 116, 139);
            btnExaminar.StateCommon.Back.Color2 = Color.FromArgb(100, 116, 139);
            btnExaminar.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnExaminar.StateCommon.Border.Rounding = 6F;
            btnExaminar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnExaminar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnExaminar.TabIndex = 1;
            btnExaminar.Values.DropDownArrowColor = Color.Empty;
            btnExaminar.Values.Text = "📁 Examinar...";
            btnExaminar.Click += btnExaminar_Click;
            // 
            // btnGenerarLocal
            // 
            btnGenerarLocal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGenerarLocal.Location = new Point(21, 193);
            btnGenerarLocal.Margin = new Padding(3, 4, 3, 4);
            btnGenerarLocal.Name = "btnGenerarLocal";
            btnGenerarLocal.Size = new Size(535, 56);
            btnGenerarLocal.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnGenerarLocal.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnGenerarLocal.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnGenerarLocal.StateCommon.Border.Rounding = 6F;
            btnGenerarLocal.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGenerarLocal.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGenerarLocal.TabIndex = 2;
            btnGenerarLocal.Values.DropDownArrowColor = Color.Empty;
            btnGenerarLocal.Values.Text = "💾 Generar Respaldo Local / USB";
            btnGenerarLocal.Click += btnGenerarLocal_Click;
            // 
            // panelCardNube
            // 
            panelCardNube.Controls.Add(lblTituloCardNube);
            panelCardNube.Controls.Add(lblEstadoGoogle);
            panelCardNube.Controls.Add(tableLayoutBotonesNube);
            panelCardNube.Dock = DockStyle.Fill;
            panelCardNube.Location = new Point(597, 4);
            panelCardNube.Margin = new Padding(9, 4, 3, 4);
            panelCardNube.Name = "panelCardNube";
            panelCardNube.Size = new Size(577, 272);
            panelCardNube.StateCommon.Color1 = Color.White;
            panelCardNube.StateCommon.Color2 = Color.White;
            panelCardNube.TabIndex = 1;
            // 
            // lblTituloCardNube
            // 
            lblTituloCardNube.AutoSize = false;
            lblTituloCardNube.Location = new System.Drawing.Point(18, 12);
            lblTituloCardNube.Name = "lblTituloCardNube";
            lblTituloCardNube.Size = new System.Drawing.Size(350, 30);
            lblTituloCardNube.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            lblTituloCardNube.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Bold);
            lblTituloCardNube.Values.Text = "☁️ Copia de Seguridad en la Nube ";
            // 
            // lblEstadoGoogle
            // 
            lblEstadoGoogle.AutoSize = false;
            lblEstadoGoogle.Location = new System.Drawing.Point(18, 45);
            lblEstadoGoogle.Name = "lblEstadoGoogle";
            lblEstadoGoogle.Size = new System.Drawing.Size(460, 24);
            lblEstadoGoogle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            // 
            // tableLayoutBotonesNube
            // 
            tableLayoutBotonesNube.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutBotonesNube.ColumnCount = 2;
            tableLayoutBotonesNube.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBotonesNube.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutBotonesNube.Controls.Add(btnConectarGoogle, 0, 0);
            tableLayoutBotonesNube.Controls.Add(btnDesconectarGoogle, 1, 0);
            tableLayoutBotonesNube.Controls.Add(btnSubirGoogleDrive, 0, 1);
            tableLayoutBotonesNube.Location = new Point(21, 120);
            tableLayoutBotonesNube.Margin = new Padding(3, 4, 3, 4);
            tableLayoutBotonesNube.Name = "tableLayoutBotonesNube";
            tableLayoutBotonesNube.RowCount = 2;
            tableLayoutBotonesNube.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBotonesNube.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutBotonesNube.Size = new Size(536, 131);
            tableLayoutBotonesNube.TabIndex = 0;
            // 
            // btnConectarGoogle
            // 
            btnConectarGoogle.Dock = DockStyle.Fill;
            btnConectarGoogle.Location = new Point(0, 0);
            btnConectarGoogle.Margin = new Padding(0, 0, 5, 8);
            btnConectarGoogle.Name = "btnConectarGoogle";
            btnConectarGoogle.Size = new Size(263, 57);
            btnConectarGoogle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnConectarGoogle.StateCommon.Border.Rounding = 6F;
            btnConectarGoogle.StateDisabled.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnConectarGoogle.StateDisabled.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnConectarGoogle.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnConectarGoogle.StateDisabled.Content.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnConectarGoogle.StateNormal.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnConectarGoogle.StateNormal.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnConectarGoogle.StateNormal.Content.ShortText.Color1 = Color.White;
            btnConectarGoogle.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnConectarGoogle.TabIndex = 0;
            btnConectarGoogle.Values.DropDownArrowColor = Color.Empty;
            btnConectarGoogle.Values.Text = "🔑 Conectar Cuenta";
            btnConectarGoogle.Click += btnConectarGoogle_Click;
            // 
            // btnDesconectarGoogle
            // 
            btnDesconectarGoogle.Dock = DockStyle.Fill;
            btnDesconectarGoogle.Location = new Point(273, 0);
            btnDesconectarGoogle.Margin = new Padding(5, 0, 0, 8);
            btnDesconectarGoogle.Name = "btnDesconectarGoogle";
            btnDesconectarGoogle.Size = new Size(263, 57);
            btnDesconectarGoogle.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnDesconectarGoogle.StateCommon.Border.Rounding = 6F;
            btnDesconectarGoogle.StateDisabled.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnDesconectarGoogle.StateDisabled.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnDesconectarGoogle.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnDesconectarGoogle.StateDisabled.Content.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnDesconectarGoogle.StateNormal.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesconectarGoogle.StateNormal.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnDesconectarGoogle.StateNormal.Content.ShortText.Color1 = Color.White;
            btnDesconectarGoogle.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnDesconectarGoogle.TabIndex = 1;
            btnDesconectarGoogle.Values.DropDownArrowColor = Color.Empty;
            btnDesconectarGoogle.Values.Text = "🔴 Desconectar Cuenta";
            btnDesconectarGoogle.Click += btnDesconectarGoogle_Click;
            // 
            // btnSubirGoogleDrive
            // 
            tableLayoutBotonesNube.SetColumnSpan(btnSubirGoogleDrive, 2);
            btnSubirGoogleDrive.Dock = DockStyle.Fill;
            btnSubirGoogleDrive.Location = new Point(0, 69);
            btnSubirGoogleDrive.Margin = new Padding(0, 4, 0, 0);
            btnSubirGoogleDrive.Name = "btnSubirGoogleDrive";
            btnSubirGoogleDrive.Size = new Size(536, 62);
            btnSubirGoogleDrive.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            btnSubirGoogleDrive.StateCommon.Border.Rounding = 6F;
            btnSubirGoogleDrive.StateDisabled.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnSubirGoogleDrive.StateDisabled.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnSubirGoogleDrive.StateDisabled.Content.ShortText.Color1 = Color.FromArgb(148, 163, 184);
            btnSubirGoogleDrive.StateDisabled.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubirGoogleDrive.StateNormal.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnSubirGoogleDrive.StateNormal.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnSubirGoogleDrive.StateNormal.Content.ShortText.Color1 = Color.White;
            btnSubirGoogleDrive.StateNormal.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSubirGoogleDrive.TabIndex = 2;
            btnSubirGoogleDrive.Values.DropDownArrowColor = Color.Empty;
            btnSubirGoogleDrive.Values.Text = "☁️ Generar y Subir a Google Drive";
            btnSubirGoogleDrive.Click += btnSubirGoogleDrive_Click;
            // 
            // panelCardHistorial
            // 
            tableLayoutPanelContenedor.SetColumnSpan(panelCardHistorial, 2);
            panelCardHistorial.Controls.Add(lblTituloHistorial);
            panelCardHistorial.Controls.Add(dgvHistorialRespaldos);
            panelCardHistorial.Controls.Add(progressBarRespaldo);
            panelCardHistorial.Dock = DockStyle.Fill;
            panelCardHistorial.Location = new Point(3, 296);
            panelCardHistorial.Margin = new Padding(3, 16, 3, 4);
            panelCardHistorial.Name = "panelCardHistorial";
            panelCardHistorial.Size = new Size(1171, 407);
            panelCardHistorial.StateCommon.Color1 = Color.White;
            panelCardHistorial.StateCommon.Color2 = Color.White;
            panelCardHistorial.TabIndex = 2;
            // 
            // lblTituloHistorial
            // 
            lblTituloHistorial.Location = new Point(21, 16);
            lblTituloHistorial.Margin = new Padding(3, 4, 3, 4);
            lblTituloHistorial.Name = "lblTituloHistorial";
            lblTituloHistorial.Size = new Size(313, 30);
            lblTituloHistorial.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloHistorial.StateCommon.ShortText.Font = new Font("Segoe UI", 11.5F, FontStyle.Bold);
            lblTituloHistorial.TabIndex = 0;
            lblTituloHistorial.Values.Text = "Historial de Respaldos Recientes";
            // 
            // dgvHistorialRespaldos
            // 
            dgvHistorialRespaldos.AllowUserToAddRows = false;
            dgvHistorialRespaldos.AllowUserToDeleteRows = false;
            dgvHistorialRespaldos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistorialRespaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistorialRespaldos.BorderStyle = BorderStyle.None;
            dgvHistorialRespaldos.ColumnHeadersHeight = 36;
            dgvHistorialRespaldos.Location = new Point(21, 64);
            dgvHistorialRespaldos.Margin = new Padding(3, 4, 3, 4);
            dgvHistorialRespaldos.Name = "dgvHistorialRespaldos";
            dgvHistorialRespaldos.ReadOnly = true;
            dgvHistorialRespaldos.RowHeadersVisible = false;
            dgvHistorialRespaldos.RowHeadersWidth = 51;
            dgvHistorialRespaldos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistorialRespaldos.Size = new Size(1130, 309);
            dgvHistorialRespaldos.StateCommon.Background.Color1 = Color.FromArgb(248, 250, 252);
            dgvHistorialRespaldos.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(30, 41, 59);
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(30, 41, 59);
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvHistorialRespaldos.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvHistorialRespaldos.TabIndex = 0;
            // 
            // progressBarRespaldo
            // 
            progressBarRespaldo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBarRespaldo.Location = new Point(21, 381);
            progressBarRespaldo.Margin = new Padding(3, 4, 3, 4);
            progressBarRespaldo.Name = "progressBarRespaldo";
            progressBarRespaldo.Size = new Size(1130, 11);
            progressBarRespaldo.Style = ProgressBarStyle.Marquee;
            progressBarRespaldo.TabIndex = 1;
            progressBarRespaldo.Visible = false;
            // 
            // ControlRespaldo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(lblTituloModulo);
            Controls.Add(tableLayoutPanelContenedor);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ControlRespaldo";
            Size = new Size(1234, 827);
            tableLayoutPanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)panelCardLocal).EndInit();
            panelCardLocal.ResumeLayout(false);
            panelCardLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelCardNube).EndInit();
            panelCardNube.ResumeLayout(false);
            panelCardNube.PerformLayout();
            tableLayoutBotonesNube.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutBotonesNube;
        private Krypton.Toolkit.KryptonButton btnConectarGoogle;
        private Krypton.Toolkit.KryptonButton btnDesconectarGoogle;
        private Krypton.Toolkit.KryptonButton btnSubirGoogleDrive;
        private Krypton.Toolkit.KryptonPanel panelCardHistorial;
        private Krypton.Toolkit.KryptonLabel lblTituloHistorial;
        private Krypton.Toolkit.KryptonDataGridView dgvHistorialRespaldos;
        private System.Windows.Forms.ProgressBar progressBarRespaldo;
    }
}