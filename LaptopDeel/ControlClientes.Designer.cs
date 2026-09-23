namespace LaptopDeel
{
    partial class ControlClientes
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
            panelFormulario = new Krypton.Toolkit.KryptonPanel();
            lblDniCuit = new Krypton.Toolkit.KryptonLabel();
            txtDniCuit = new Krypton.Toolkit.KryptonTextBox();
            lblNombreCompleto = new Krypton.Toolkit.KryptonLabel();
            txtNombreCompleto = new Krypton.Toolkit.KryptonTextBox();
            lblIva = new Krypton.Toolkit.KryptonLabel();
            cmbIva = new Krypton.Toolkit.KryptonComboBox();
            lblTelefono = new Krypton.Toolkit.KryptonLabel();
            txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            lblCorreo = new Krypton.Toolkit.KryptonLabel();
            txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            lblDireccion = new Krypton.Toolkit.KryptonLabel();
            txtDireccion = new Krypton.Toolkit.KryptonTextBox();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            btnActualizar = new Krypton.Toolkit.KryptonButton();
            panelTabla = new Krypton.Toolkit.KryptonPanel();
            lblBuscar = new Krypton.Toolkit.KryptonLabel();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblFiltroEstado = new Krypton.Toolkit.KryptonLabel();
            cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            dgvClientes = new Krypton.Toolkit.KryptonDataGridView();
            btnDesactivarCliente = new Krypton.Toolkit.KryptonButton();
            btnReactivarCliente = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelFormulario).BeginInit();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbIva).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).BeginInit();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(20, 12);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(401, 41);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Gestión y Registro de Clientes";
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.Controls.Add(lblDniCuit);
            panelFormulario.Controls.Add(txtDniCuit);
            panelFormulario.Controls.Add(lblNombreCompleto);
            panelFormulario.Controls.Add(txtNombreCompleto);
            panelFormulario.Controls.Add(lblIva);
            panelFormulario.Controls.Add(cmbIva);
            panelFormulario.Controls.Add(lblTelefono);
            panelFormulario.Controls.Add(txtTelefono);
            panelFormulario.Controls.Add(lblCorreo);
            panelFormulario.Controls.Add(txtCorreo);
            panelFormulario.Controls.Add(lblDireccion);
            panelFormulario.Controls.Add(txtDireccion);
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnGuardarNuevo);
            panelFormulario.Controls.Add(btnActualizar);
            panelFormulario.Location = new Point(20, 50);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1040, 210);
            panelFormulario.StateCommon.Color1 = Color.White;
            panelFormulario.StateCommon.Color2 = Color.White;
            panelFormulario.TabIndex = 1;
            // 
            // lblDniCuit
            // 
            lblDniCuit.Location = new Point(15, 12);
            lblDniCuit.Name = "lblDniCuit";
            lblDniCuit.Size = new Size(215, 24);
            lblDniCuit.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblDniCuit.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDniCuit.TabIndex = 0;
            lblDniCuit.Values.Text = "DNI / CUIT (Clave Primaria):";
            // 
            // txtDniCuit
            // 
            txtDniCuit.Location = new Point(15, 36);
            txtDniCuit.Name = "txtDniCuit";
            txtDniCuit.Size = new Size(220, 27);
            txtDniCuit.TabIndex = 1;
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.Location = new Point(250, 12);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(258, 24);
            lblNombreCompleto.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblNombreCompleto.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreCompleto.TabIndex = 2;
            lblNombreCompleto.Values.Text = "Nombre Completo / Razón Social:";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtNombreCompleto.Location = new Point(250, 36);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(515, 27);
            txtNombreCompleto.TabIndex = 3;
            // 
            // lblIva
            // 
            lblIva.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIva.Location = new Point(709, 12);
            lblIva.Name = "lblIva";
            lblIva.Size = new Size(119, 24);
            lblIva.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblIva.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIva.TabIndex = 4;
            lblIva.Values.Text = "Condición IVA:";
            // 
            // cmbIva
            // 
            cmbIva.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbIva.Location = new Point(780, 36);
            cmbIva.Name = "cmbIva";
            cmbIva.Size = new Size(245, 26);
            cmbIva.TabIndex = 5;
            // 
            // lblTelefono
            // 
            lblTelefono.Location = new Point(15, 78);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(172, 24);
            lblTelefono.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblTelefono.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.TabIndex = 6;
            lblTelefono.Values.Text = "Teléfono de Contacto:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(15, 102);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(220, 27);
            txtTelefono.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(250, 78);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(150, 24);
            lblCorreo.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblCorreo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreo.TabIndex = 8;
            lblCorreo.Values.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(250, 102);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 27);
            txtCorreo.TabIndex = 9;
            // 
            // lblDireccion
            // 
            lblDireccion.Location = new Point(515, 78);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(279, 24);
            lblDireccion.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblDireccion.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDireccion.TabIndex = 10;
            lblDireccion.Values.Text = "Dirección / Domicilio de Facturación:";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDireccion.Location = new Point(515, 102);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(510, 27);
            txtDireccion.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Location = new Point(525, 152);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 40);
            btnLimpiar.StateCommon.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnLimpiar.StateCommon.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnLimpiar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(51, 65, 85);
            btnLimpiar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "\U0001f9f9 Limpiar Campos";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarNuevo.Location = new Point(695, 152);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(165, 40);
            btnGuardarNuevo.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGuardarNuevo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardarNuevo.TabIndex = 13;
            btnGuardarNuevo.Values.DropDownArrowColor = Color.Empty;
            btnGuardarNuevo.Values.Text = "💾 Guardar Nuevo";
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(870, 152);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 40);
            btnActualizar.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnActualizar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.TabIndex = 14;
            btnActualizar.Values.DropDownArrowColor = Color.Empty;
            btnActualizar.Values.Text = "✏️ Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTabla.Controls.Add(lblBuscar);
            panelTabla.Controls.Add(txtBuscar);
            panelTabla.Controls.Add(lblFiltroEstado);
            panelTabla.Controls.Add(cmbFiltroEstado);
            panelTabla.Controls.Add(dgvClientes);
            panelTabla.Controls.Add(btnDesactivarCliente);
            panelTabla.Controls.Add(btnReactivarCliente);
            panelTabla.Location = new Point(20, 275);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1040, 325);
            panelTabla.StateCommon.Color1 = Color.White;
            panelTabla.StateCommon.Color2 = Color.White;
            panelTabla.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(15, 12);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(118, 24);
            lblBuscar.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblBuscar.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.TabIndex = 0;
            lblBuscar.Values.Text = "Buscar Cliente:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.CueHint.CueHintText = "🔍 Escriba DNI, CUIT, Nombre o Email para filtrar...";
            txtBuscar.Location = new Point(15, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(750, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblFiltroEstado
            // 
            lblFiltroEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltroEstado.Location = new Point(687, 12);
            lblFiltroEstado.Name = "lblFiltroEstado";
            lblFiltroEstado.Size = new Size(141, 24);
            lblFiltroEstado.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblFiltroEstado.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltroEstado.TabIndex = 2;
            lblFiltroEstado.Values.Text = "Filtrar por Estado:";
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroEstado.Location = new Point(780, 36);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(245, 26);
            cmbFiltroEstado.TabIndex = 3;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersHeight = 36;
            dgvClientes.Location = new Point(15, 76);
            dgvClientes.MultiSelect = false;
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1010, 195);
            dgvClientes.StateCommon.Background.Color1 = Color.FromArgb(248, 250, 252);
            dgvClientes.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvClientes.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(30, 41, 59);
            dgvClientes.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(30, 41, 59);
            dgvClientes.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvClientes.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvClientes.TabIndex = 4;
            dgvClientes.SelectionChanged += dgvClientes_SelectionChanged;
            // 
            // btnDesactivarCliente
            // 
            btnDesactivarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesactivarCliente.Location = new Point(15, 278);
            btnDesactivarCliente.Name = "btnDesactivarCliente";
            btnDesactivarCliente.Size = new Size(230, 38);
            btnDesactivarCliente.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesactivarCliente.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnDesactivarCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDesactivarCliente.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDesactivarCliente.TabIndex = 5;
            btnDesactivarCliente.Values.DropDownArrowColor = Color.Empty;
            btnDesactivarCliente.Values.Text = "🗑️ Desactivar Cliente";
            btnDesactivarCliente.Click += btnDesactivarCliente_Click;
            // 
            // btnReactivarCliente
            // 
            btnReactivarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReactivarCliente.Enabled = false;
            btnReactivarCliente.Location = new Point(795, 278);
            btnReactivarCliente.Name = "btnReactivarCliente";
            btnReactivarCliente.Size = new Size(230, 38);
            btnReactivarCliente.StateCommon.Back.Color1 = Color.FromArgb(16, 185, 129);
            btnReactivarCliente.StateCommon.Back.Color2 = Color.FromArgb(16, 185, 129);
            btnReactivarCliente.StateCommon.Content.ShortText.Color1 = Color.White;
            btnReactivarCliente.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReactivarCliente.TabIndex = 6;
            btnReactivarCliente.Values.DropDownArrowColor = Color.Empty;
            btnReactivarCliente.Values.Text = "♻️ Reactivar Cliente";
            btnReactivarCliente.Click += btnReactivarCliente_Click;
            // 
            // ControlClientes
            // 
            BackColor = Color.FromArgb(203, 213, 225);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(lblTituloModulo);
            ImeMode = ImeMode.NoControl;
            Name = "ControlClientes";
            Size = new Size(1080, 620);
            Load += ControlClientes_Load;
            ((System.ComponentModel.ISupportInitialize)panelFormulario).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbIva).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).EndInit();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonPanel panelFormulario;
        private Krypton.Toolkit.KryptonLabel lblDniCuit;
        private Krypton.Toolkit.KryptonTextBox txtDniCuit;
        private Krypton.Toolkit.KryptonLabel lblNombreCompleto;
        private Krypton.Toolkit.KryptonTextBox txtNombreCompleto;
        private Krypton.Toolkit.KryptonLabel lblIva;
        private Krypton.Toolkit.KryptonComboBox cmbIva;
        private Krypton.Toolkit.KryptonLabel lblTelefono;
        private Krypton.Toolkit.KryptonTextBox txtTelefono;
        private Krypton.Toolkit.KryptonLabel lblCorreo;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonLabel lblDireccion;
        private Krypton.Toolkit.KryptonTextBox txtDireccion;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonButton btnGuardarNuevo;
        private Krypton.Toolkit.KryptonButton btnActualizar;

        private Krypton.Toolkit.KryptonPanel panelTabla;
        private Krypton.Toolkit.KryptonLabel lblBuscar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonLabel lblFiltroEstado;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroEstado;
        private Krypton.Toolkit.KryptonDataGridView dgvClientes;
        private Krypton.Toolkit.KryptonButton btnDesactivarCliente;
        private Krypton.Toolkit.KryptonButton btnReactivarCliente;
    }
}