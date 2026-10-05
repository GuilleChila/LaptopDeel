namespace LaptopDeel
{
    partial class ControlInventarioComponentes
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
            lblSelector = new Krypton.Toolkit.KryptonLabel();
            cmbTipoComponente = new Krypton.Toolkit.KryptonComboBox();
            panelFormulario = new Krypton.Toolkit.KryptonPanel();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            btnGuardar = new Krypton.Toolkit.KryptonButton();
            txtCampo4 = new Krypton.Toolkit.KryptonTextBox();
            lblCampo4 = new Krypton.Toolkit.KryptonLabel();
            txtCampo3 = new Krypton.Toolkit.KryptonTextBox();
            lblCampo3 = new Krypton.Toolkit.KryptonLabel();
            txtCampo2 = new Krypton.Toolkit.KryptonTextBox();
            lblCampo2 = new Krypton.Toolkit.KryptonLabel();
            txtCampo1 = new Krypton.Toolkit.KryptonTextBox();
            lblCampo1 = new Krypton.Toolkit.KryptonLabel();
            txtId = new Krypton.Toolkit.KryptonTextBox();
            lblId = new Krypton.Toolkit.KryptonLabel();
            panelTabla = new Krypton.Toolkit.KryptonPanel();
            btnDesactivar = new Krypton.Toolkit.KryptonButton();
            dgvComponentes = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)cmbTipoComponente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelFormulario).BeginInit();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelTabla).BeginInit();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComponentes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(20, 12);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(497, 41);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 4;
            lblTituloModulo.Values.Text = "Gestión de Componentes y Catálogos";
            // 
            // lblSelector
            // 
            lblSelector.Location = new Point(20, 60);
            lblSelector.Name = "lblSelector";
            lblSelector.Size = new Size(289, 27);
            lblSelector.StateCommon.ShortText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelector.TabIndex = 3;
            lblSelector.Values.Text = "Seleccione el catálogo a gestionar:";
            // 
            // cmbTipoComponente
            // 
            cmbTipoComponente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoComponente.Items.AddRange(new object[] { "Almacenamientos", "Pantallas", "Procesadores", "Memorias RAM", "Tarjetas Gráficas", "Categorías" });
            cmbTipoComponente.Location = new Point(315, 61);
            cmbTipoComponente.Name = "cmbTipoComponente";
            cmbTipoComponente.Size = new Size(250, 26);
            cmbTipoComponente.TabIndex = 2;
            cmbTipoComponente.SelectedIndexChanged += cmbTipoComponente_SelectedIndexChanged;
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnGuardar);
            panelFormulario.Controls.Add(txtCampo4);
            panelFormulario.Controls.Add(lblCampo4);
            panelFormulario.Controls.Add(txtCampo3);
            panelFormulario.Controls.Add(lblCampo3);
            panelFormulario.Controls.Add(txtCampo2);
            panelFormulario.Controls.Add(lblCampo2);
            panelFormulario.Controls.Add(txtCampo1);
            panelFormulario.Controls.Add(lblCampo1);
            panelFormulario.Controls.Add(txtId);
            panelFormulario.Controls.Add(lblId);
            panelFormulario.Location = new Point(20, 100);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1040, 160);
            panelFormulario.StateCommon.Color1 = Color.White;
            panelFormulario.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(695, 95);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 40);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "\U0001f9f9 Limpiar";
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(865, 95);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(160, 40);
            btnGuardar.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnGuardar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGuardar.TabIndex = 1;
            btnGuardar.Values.DropDownArrowColor = Color.Empty;
            btnGuardar.Values.Text = "💾 Guardar Registro";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCampo4
            // 
            txtCampo4.Location = new Point(330, 100);
            txtCampo4.Name = "txtCampo4";
            txtCampo4.Size = new Size(220, 27);
            txtCampo4.TabIndex = 2;
            // 
            // lblCampo4
            // 
            lblCampo4.Location = new Point(330, 80);
            lblCampo4.Name = "lblCampo4";
            lblCampo4.Size = new Size(80, 24);
            lblCampo4.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCampo4.TabIndex = 3;
            lblCampo4.Values.Text = "Campo 4:";
            // 
            // txtCampo3
            // 
            txtCampo3.Location = new Point(90, 100);
            txtCampo3.Name = "txtCampo3";
            txtCampo3.Size = new Size(220, 27);
            txtCampo3.TabIndex = 4;
            // 
            // lblCampo3
            // 
            lblCampo3.Location = new Point(90, 80);
            lblCampo3.Name = "lblCampo3";
            lblCampo3.Size = new Size(80, 24);
            lblCampo3.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCampo3.TabIndex = 5;
            lblCampo3.Values.Text = "Campo 3:";
            // 
            // txtCampo2
            // 
            txtCampo2.Location = new Point(330, 35);
            txtCampo2.Name = "txtCampo2";
            txtCampo2.Size = new Size(220, 27);
            txtCampo2.TabIndex = 6;
            // 
            // lblCampo2
            // 
            lblCampo2.Location = new Point(330, 15);
            lblCampo2.Name = "lblCampo2";
            lblCampo2.Size = new Size(80, 24);
            lblCampo2.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCampo2.TabIndex = 7;
            lblCampo2.Values.Text = "Campo 2:";
            // 
            // txtCampo1
            // 
            txtCampo1.Location = new Point(90, 35);
            txtCampo1.Name = "txtCampo1";
            txtCampo1.Size = new Size(220, 27);
            txtCampo1.TabIndex = 8;
            // 
            // lblCampo1
            // 
            lblCampo1.Location = new Point(90, 15);
            lblCampo1.Name = "lblCampo1";
            lblCampo1.Size = new Size(80, 24);
            lblCampo1.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCampo1.TabIndex = 9;
            lblCampo1.Values.Text = "Campo 1:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(15, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(60, 27);
            txtId.TabIndex = 10;
            // 
            // lblId
            // 
            lblId.Location = new Point(15, 15);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 24);
            lblId.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.TabIndex = 11;
            lblId.Values.Text = "ID:";
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTabla.Controls.Add(btnDesactivar);
            panelTabla.Controls.Add(dgvComponentes);
            panelTabla.Location = new Point(20, 275);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1040, 345);
            panelTabla.StateCommon.Color1 = Color.White;
            panelTabla.TabIndex = 0;
            // 
            // btnDesactivar
            // 
            btnDesactivar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesactivar.Location = new Point(15, 300);
            btnDesactivar.Name = "btnDesactivar";
            btnDesactivar.Size = new Size(180, 35);
            btnDesactivar.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesactivar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDesactivar.TabIndex = 0;
            btnDesactivar.Values.DropDownArrowColor = Color.Empty;
            btnDesactivar.Values.Text = "🗑️ Eliminar/Desactivar";
            btnDesactivar.Click += btnDesactivar_Click_1;
            // 
            // dgvComponentes
            // 
            dgvComponentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComponentes.BorderStyle = BorderStyle.None;
            dgvComponentes.ColumnHeadersHeight = 36;
            dgvComponentes.Location = new Point(15, 15);
            dgvComponentes.Name = "dgvComponentes";
            dgvComponentes.ReadOnly = true;
            dgvComponentes.RowHeadersWidth = 51;
            dgvComponentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComponentes.Size = new Size(1010, 275);
            dgvComponentes.TabIndex = 1;           
            // 
            // ControlInventarioComponentes
            // 
            BackColor = Color.FromArgb(203, 213, 225);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(cmbTipoComponente);
            Controls.Add(lblSelector);
            Controls.Add(lblTituloModulo);
            Name = "ControlInventarioComponentes";
            Size = new Size(1080, 640);
            ((System.ComponentModel.ISupportInitialize)cmbTipoComponente).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelFormulario).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelTabla).EndInit();
            panelTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComponentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonLabel lblSelector;
        private Krypton.Toolkit.KryptonComboBox cmbTipoComponente;

        private Krypton.Toolkit.KryptonPanel panelFormulario;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonTextBox txtId;

        private Krypton.Toolkit.KryptonLabel lblCampo1;
        private Krypton.Toolkit.KryptonTextBox txtCampo1;
        private Krypton.Toolkit.KryptonLabel lblCampo2;
        private Krypton.Toolkit.KryptonTextBox txtCampo2;
        private Krypton.Toolkit.KryptonLabel lblCampo3;
        private Krypton.Toolkit.KryptonTextBox txtCampo3;
        private Krypton.Toolkit.KryptonLabel lblCampo4;
        private Krypton.Toolkit.KryptonTextBox txtCampo4;

        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonButton btnGuardar;

        private Krypton.Toolkit.KryptonPanel panelTabla;
        private Krypton.Toolkit.KryptonDataGridView dgvComponentes;
        private Krypton.Toolkit.KryptonButton btnDesactivar;
    }
}