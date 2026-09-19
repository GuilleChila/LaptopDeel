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
            this.lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.panelFormulario = new Krypton.Toolkit.KryptonPanel();
            this.lblDNI = new Krypton.Toolkit.KryptonLabel();
            this.txtDni = new Krypton.Toolkit.KryptonTextBox();
            this.lblNombre = new Krypton.Toolkit.KryptonLabel();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.lblApellido = new Krypton.Toolkit.KryptonLabel();
            this.txtApellido = new Krypton.Toolkit.KryptonTextBox();
            this.lblFechaNac = new Krypton.Toolkit.KryptonLabel();
            this.dtpFechaNacimiento = new Krypton.Toolkit.KryptonDateTimePicker();
            this.lblCorreo = new Krypton.Toolkit.KryptonLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.lblContrasena = new Krypton.Toolkit.KryptonLabel();
            this.txtContrasena = new Krypton.Toolkit.KryptonTextBox();
            this.lblRol = new Krypton.Toolkit.KryptonLabel();
            this.cmbRol = new Krypton.Toolkit.KryptonComboBox();
            this.btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();

            this.panelTabla = new Krypton.Toolkit.KryptonPanel();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            this.dgvUsuarios = new Krypton.Toolkit.KryptonDataGridView();
            this.btnDesactivarUsuario = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).BeginInit();
            this.SuspendLayout();

            // 
            // ControlUsuarios Base
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.lblTituloModulo);
            this.Name = "ControlUsuarios";
            this.Size = new System.Drawing.Size(1080, 620);
            this.Load += new System.EventHandler(this.ControlUsuarios_Load);

            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.Location = new System.Drawing.Point(20, 15);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(390, 32);
            this.lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Values.Text = "Gestión y Control de Cuentas de Usuarios";

            // 
            // panelFormulario (Tarjeta Izquierda)
            // 
            this.panelFormulario.Controls.Add(this.lblDNI);
            this.panelFormulario.Controls.Add(this.txtDni);
            this.panelFormulario.Controls.Add(this.lblNombre);
            this.panelFormulario.Controls.Add(this.txtNombre);
            this.panelFormulario.Controls.Add(this.lblApellido);
            this.panelFormulario.Controls.Add(this.txtApellido);
            this.panelFormulario.Controls.Add(this.lblFechaNac);
            this.panelFormulario.Controls.Add(this.dtpFechaNacimiento);
            this.panelFormulario.Controls.Add(this.lblCorreo);
            this.panelFormulario.Controls.Add(this.txtCorreo);
            this.panelFormulario.Controls.Add(this.lblContrasena);
            this.panelFormulario.Controls.Add(this.txtContrasena);
            this.panelFormulario.Controls.Add(this.lblRol);
            this.panelFormulario.Controls.Add(this.cmbRol);
            this.panelFormulario.Controls.Add(this.btnGuardarNuevo);
            this.panelFormulario.Controls.Add(this.btnActualizar);
            this.panelFormulario.Controls.Add(this.btnLimpiar);
            this.panelFormulario.Location = new System.Drawing.Point(20, 60);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(380, 540);
            this.panelFormulario.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelFormulario.StateCommon.Color2 = System.Drawing.Color.White;

            // DNI
            this.lblDNI.Location = new System.Drawing.Point(15, 15);
            this.lblDNI.Values.Text = "DNI / Documento:";
            this.txtDni.Location = new System.Drawing.Point(15, 38);
            this.txtDni.Size = new System.Drawing.Size(345, 30);

            // Nombre
            this.lblNombre.Location = new System.Drawing.Point(15, 75);
            this.lblNombre.Values.Text = "Nombre:";
            this.txtNombre.Location = new System.Drawing.Point(15, 98);
            this.txtNombre.Size = new System.Drawing.Size(345, 30);

            // Apellido
            this.lblApellido.Location = new System.Drawing.Point(15, 135);
            this.lblApellido.Values.Text = "Apellido:";
            this.txtApellido.Location = new System.Drawing.Point(15, 158);
            this.txtApellido.Size = new System.Drawing.Size(345, 30);

            // Fecha Nacimiento
            this.lblFechaNac.Location = new System.Drawing.Point(15, 195);
            this.lblFechaNac.Values.Text = "Fecha de Nacimiento:";
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(15, 218);
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(345, 30);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;

            // Correo
            this.lblCorreo.Location = new System.Drawing.Point(15, 255);
            this.lblCorreo.Values.Text = "Correo Electrónico:";
            this.txtCorreo.Location = new System.Drawing.Point(15, 278);
            this.txtCorreo.Size = new System.Drawing.Size(345, 30);

            // Contraseña
            this.lblContrasena.Location = new System.Drawing.Point(15, 315);
            this.lblContrasena.Values.Text = "Contraseña:";
            this.txtContrasena.Location = new System.Drawing.Point(15, 338);
            this.txtContrasena.Size = new System.Drawing.Size(345, 30);
            this.txtContrasena.UseSystemPasswordChar = true;

            // Rol
            this.lblRol.Location = new System.Drawing.Point(15, 375);
            this.lblRol.Values.Text = "Rol de Usuario:";
            this.cmbRol.Location = new System.Drawing.Point(15, 398);
            this.cmbRol.Size = new System.Drawing.Size(345, 30);

            // Botón Guardar
            this.btnGuardarNuevo.Location = new System.Drawing.Point(15, 445);
            this.btnGuardarNuevo.Size = new System.Drawing.Size(165, 38);
            this.btnGuardarNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardarNuevo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGuardarNuevo.Values.Text = "💾 Guardar";
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);

            // Botón Actualizar
            this.btnActualizar.Location = new System.Drawing.Point(195, 445);
            this.btnActualizar.Size = new System.Drawing.Size(165, 38);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizar.Values.Text = "✏️ Actualizar";
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // Botón Limpiar
            this.btnLimpiar.Location = new System.Drawing.Point(15, 490);
            this.btnLimpiar.Size = new System.Drawing.Size(345, 32);
            this.btnLimpiar.Values.Text = "🧹 Limpiar Campos";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // 
            // panelTabla (Tarjeta Derecha)
            // 
            this.panelTabla.Controls.Add(this.txtBuscar);
            this.panelTabla.Controls.Add(this.cmbFiltroEstado);
            this.panelTabla.Controls.Add(this.dgvUsuarios);
            this.panelTabla.Controls.Add(this.btnDesactivarUsuario);
            this.panelTabla.Location = new System.Drawing.Point(420, 60);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(640, 540);
            this.panelTabla.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelTabla.StateCommon.Color2 = System.Drawing.Color.White;

            // Buscador
            this.txtBuscar.Location = new System.Drawing.Point(15, 15);
            this.txtBuscar.Size = new System.Drawing.Size(430, 30);
            this.txtBuscar.CueHint.CueHintText = "🔍 Buscar por Nombre, Apellido, DNI o Email...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            // Filtro Estado
            this.cmbFiltroEstado.Location = new System.Drawing.Point(455, 15);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(170, 30);
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);

            // Grilla
            this.dgvUsuarios.Location = new System.Drawing.Point(15, 55);
            this.dgvUsuarios.Size = new System.Drawing.Size(610, 425);
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);

            // Botón Desactivar
            this.btnDesactivarUsuario.Location = new System.Drawing.Point(380, 490);
            this.btnDesactivarUsuario.Size = new System.Drawing.Size(245, 38);
            this.btnDesactivarUsuario.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDesactivarUsuario.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btnDesactivarUsuario.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDesactivarUsuario.Values.Text = "🗑️ Desactivar Usuario Seleccionado";
            this.btnDesactivarUsuario.Click += new System.EventHandler(this.btnDesactivarUsuario_Click);

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private Krypton.Toolkit.KryptonPanel panelTabla;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroEstado;
        private Krypton.Toolkit.KryptonDataGridView dgvUsuarios;
        private Krypton.Toolkit.KryptonButton btnDesactivarUsuario;
    }
}