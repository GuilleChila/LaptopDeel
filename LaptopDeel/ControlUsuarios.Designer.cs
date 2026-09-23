namespace LaptopDeel
{
    partial class ControlUsuarios
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
            lblDNI = new Krypton.Toolkit.KryptonLabel();
            txtDni = new Krypton.Toolkit.KryptonTextBox();
            lblNombre = new Krypton.Toolkit.KryptonLabel();
            txtNombre = new Krypton.Toolkit.KryptonTextBox();
            lblApellido = new Krypton.Toolkit.KryptonLabel();
            txtApellido = new Krypton.Toolkit.KryptonTextBox();
            lblFechaNac = new Krypton.Toolkit.KryptonLabel();
            dtpFechaNacimiento = new Krypton.Toolkit.KryptonDateTimePicker();
            lblCorreo = new Krypton.Toolkit.KryptonLabel();
            txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            lblContrasena = new Krypton.Toolkit.KryptonLabel();
            txtContrasena = new Krypton.Toolkit.KryptonTextBox();
            lblRol = new Krypton.Toolkit.KryptonLabel();
            cmbRol = new Krypton.Toolkit.KryptonComboBox();
            btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            btnActualizar = new Krypton.Toolkit.KryptonButton();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            btnDesactivarUsuario = new Krypton.Toolkit.KryptonButton();
            dgvUsuarios = new Krypton.Toolkit.KryptonDataGridView();
            panelTabla = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)panelFormulario).BeginInit();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbRol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).BeginInit();
            panelTabla.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(0, 0);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(548, 41);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Gestión y Control de Cuentas de Usuarios";
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.Controls.Add(lblDNI);
            panelFormulario.Controls.Add(txtDni);
            panelFormulario.Controls.Add(lblNombre);
            panelFormulario.Controls.Add(txtNombre);
            panelFormulario.Controls.Add(lblApellido);
            panelFormulario.Controls.Add(txtApellido);
            panelFormulario.Controls.Add(lblFechaNac);
            panelFormulario.Controls.Add(dtpFechaNacimiento);
            panelFormulario.Controls.Add(lblCorreo);
            panelFormulario.Controls.Add(txtCorreo);
            panelFormulario.Controls.Add(lblContrasena);
            panelFormulario.Controls.Add(txtContrasena);
            panelFormulario.Controls.Add(lblRol);
            panelFormulario.Controls.Add(cmbRol);
            panelFormulario.Controls.Add(btnGuardarNuevo);
            panelFormulario.Controls.Add(btnActualizar);
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Location = new Point(0, 41);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(380, 579);
            panelFormulario.StateCommon.Color1 = Color.White;
            panelFormulario.StateCommon.Color2 = Color.White;
            panelFormulario.TabIndex = 1;
            // 
            // lblDNI
            // 
            lblDNI.Location = new Point(15, 15);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(136, 24);
            lblDNI.TabIndex = 0;
            lblDNI.Values.Text = "DNI / Documento:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(15, 38);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(345, 27);
            txtDni.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(15, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 24);
            lblNombre.TabIndex = 2;
            lblNombre.Values.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(15, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(345, 27);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.Location = new Point(15, 135);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 24);
            lblApellido.TabIndex = 4;
            lblApellido.Values.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(15, 158);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(345, 27);
            txtApellido.TabIndex = 5;
            // 
            // lblFechaNac
            // 
            lblFechaNac.Location = new Point(15, 195);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(158, 24);
            lblFechaNac.TabIndex = 6;
            lblFechaNac.Values.Text = "Fecha de Nacimiento:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(15, 218);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(345, 25);
            dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblCorreo
            // 
            lblCorreo.Location = new Point(15, 255);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(141, 24);
            lblCorreo.TabIndex = 8;
            lblCorreo.Values.Text = "Correo Electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(15, 278);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(345, 27);
            txtCorreo.TabIndex = 9;
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(15, 315);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(92, 24);
            lblContrasena.TabIndex = 10;
            lblContrasena.Values.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(15, 338);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '●';
            txtContrasena.Size = new Size(345, 27);
            txtContrasena.TabIndex = 11;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblRol
            // 
            lblRol.Location = new Point(15, 375);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(114, 24);
            lblRol.TabIndex = 12;
            lblRol.Values.Text = "Rol de Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.Location = new Point(15, 398);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(345, 26);
            cmbRol.TabIndex = 13;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Location = new Point(15, 445);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(165, 38);
            btnGuardarNuevo.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGuardarNuevo.TabIndex = 14;
            btnGuardarNuevo.Values.DropDownArrowColor = Color.Empty;
            btnGuardarNuevo.Values.Text = "💾 Guardar";
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(195, 445);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(165, 38);
            btnActualizar.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnActualizar.TabIndex = 15;
            btnActualizar.Values.DropDownArrowColor = Color.Empty;
            btnActualizar.Values.Text = "✏️ Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(15, 490);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(345, 32);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "\U0001f9f9 Limpiar Campos";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.CueHint.CueHintText = "🔍 Buscar por Nombre, Apellido, DNI o Email...";
            txtBuscar.Location = new Point(3, 9);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(316, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbFiltroEstado.Location = new Point(363, 10);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(215, 26);
            cmbFiltroEstado.TabIndex = 1;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;
            // 
            // btnDesactivarUsuario
            // 
            btnDesactivarUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDesactivarUsuario.Location = new Point(408, 510);
            btnDesactivarUsuario.Name = "btnDesactivarUsuario";
            btnDesactivarUsuario.Size = new Size(271, 38);
            btnDesactivarUsuario.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesactivarUsuario.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnDesactivarUsuario.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDesactivarUsuario.TabIndex = 3;
            btnDesactivarUsuario.Values.DropDownArrowColor = Color.Empty;
            btnDesactivarUsuario.Values.Text = "🗑️ Desactivar Usuario Seleccionado";
            btnDesactivarUsuario.Click += btnDesactivarUsuario_Click;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersHeight = 36;
            dgvUsuarios.Location = new Point(3, 59);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(676, 445);
            dgvUsuarios.TabIndex = 2;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTabla.Controls.Add(txtBuscar);
            panelTabla.Controls.Add(dgvUsuarios);
            panelTabla.Controls.Add(cmbFiltroEstado);
            panelTabla.Controls.Add(btnDesactivarUsuario);
            panelTabla.Location = new Point(392, 41);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(688, 579);
            panelTabla.StateCommon.Color1 = Color.White;
            panelTabla.StateCommon.Color2 = Color.White;
            panelTabla.TabIndex = 0;
            // 
            // ControlUsuarios
            // 
            BackColor = Color.FromArgb(248, 250, 252);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(lblTituloModulo);
            Name = "ControlUsuarios";
            Size = new Size(1080, 620);
            Load += ControlUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)panelFormulario).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbRol).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).EndInit();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonPanel panelFormulario;
        private Krypton.Toolkit.KryptonLabel lblDNI;
        private Krypton.Toolkit.KryptonTextBox txtDni;
        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonLabel lblApellido;
        private Krypton.Toolkit.KryptonTextBox txtApellido;
        private Krypton.Toolkit.KryptonLabel lblFechaNac;
        private Krypton.Toolkit.KryptonDateTimePicker dtpFechaNacimiento;
        private Krypton.Toolkit.KryptonLabel lblCorreo;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonLabel lblContrasena;
        private Krypton.Toolkit.KryptonTextBox txtContrasena;
        private Krypton.Toolkit.KryptonLabel lblRol;
        private Krypton.Toolkit.KryptonComboBox cmbRol;
        private Krypton.Toolkit.KryptonButton btnGuardarNuevo;
        private Krypton.Toolkit.KryptonButton btnActualizar;
        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroEstado;
        private Krypton.Toolkit.KryptonButton btnDesactivarUsuario;
        private Krypton.Toolkit.KryptonDataGridView dgvUsuarios;
        private Krypton.Toolkit.KryptonPanel panelTabla;
    }
}