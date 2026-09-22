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
            this.lblTituloModulo = new Krypton.Toolkit.KryptonLabel();
            this.panelFormulario = new Krypton.Toolkit.KryptonPanel();

            // Fila 1 Formulario
            this.lblDniCuit = new Krypton.Toolkit.KryptonLabel();
            this.txtDniCuit = new Krypton.Toolkit.KryptonTextBox();
            this.lblNombreCompleto = new Krypton.Toolkit.KryptonLabel();
            this.txtNombreCompleto = new Krypton.Toolkit.KryptonTextBox();
            this.lblIva = new Krypton.Toolkit.KryptonLabel();
            this.cmbIva = new Krypton.Toolkit.KryptonComboBox();

            // Fila 2 Formulario
            this.lblTelefono = new Krypton.Toolkit.KryptonLabel();
            this.txtTelefono = new Krypton.Toolkit.KryptonTextBox();
            this.lblCorreo = new Krypton.Toolkit.KryptonLabel();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.lblDireccion = new Krypton.Toolkit.KryptonLabel();
            this.txtDireccion = new Krypton.Toolkit.KryptonTextBox();

            // Fila 3 Botonera Formulario
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();

            // Tarjeta Inferior Listado / Grilla
            this.panelTabla = new Krypton.Toolkit.KryptonPanel();
            this.lblBuscar = new Krypton.Toolkit.KryptonLabel();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.lblFiltroEstado = new Krypton.Toolkit.KryptonLabel();
            this.cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            this.dgvClientes = new Krypton.Toolkit.KryptonDataGridView();
            this.btnDesactivarCliente = new Krypton.Toolkit.KryptonButton();
            this.btnReactivarCliente = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).BeginInit();
            this.SuspendLayout();

            // 
            // ControlClientes Base (Fondo con alto contraste Slate #CBD5E1)
            // 
            this.BackColor = System.Drawing.Color.FromArgb(203, 213, 225); // Slate medio para marcar contraste con las tarjetas
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.lblTituloModulo);
            this.Name = "ControlClientes";
            this.Size = new System.Drawing.Size(1080, 620);
            this.Load += new System.EventHandler(this.ControlClientes_Load);

            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.Location = new System.Drawing.Point(20, 12);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(350, 32);
            this.lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42); // Slate Oscuro
            this.lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Values.Text = "Gestión y Registro de Clientes";

            // 
            // panelFormulario (Tarjeta Superior - Blanco Puro con bordes definidos)
            // 
            this.panelFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormulario.Controls.Add(this.lblDniCuit);
            this.panelFormulario.Controls.Add(this.txtDniCuit);
            this.panelFormulario.Controls.Add(this.lblNombreCompleto);
            this.panelFormulario.Controls.Add(this.txtNombreCompleto);
            this.panelFormulario.Controls.Add(this.lblIva);
            this.panelFormulario.Controls.Add(this.cmbIva);
            this.panelFormulario.Controls.Add(this.lblTelefono);
            this.panelFormulario.Controls.Add(this.txtTelefono);
            this.panelFormulario.Controls.Add(this.lblCorreo);
            this.panelFormulario.Controls.Add(this.txtCorreo);
            this.panelFormulario.Controls.Add(this.lblDireccion);
            this.panelFormulario.Controls.Add(this.txtDireccion);
            this.panelFormulario.Controls.Add(this.btnLimpiar);
            this.panelFormulario.Controls.Add(this.btnGuardarNuevo);
            this.panelFormulario.Controls.Add(this.btnActualizar);
            this.panelFormulario.Location = new System.Drawing.Point(20, 50);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1040, 210);
            this.panelFormulario.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelFormulario.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelFormulario.TabIndex = 1;

            // --- FILA 1 ---
            // DNI / CUIT
            this.lblDniCuit.Location = new System.Drawing.Point(15, 12);
            this.lblDniCuit.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDniCuit.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDniCuit.Values.Text = "DNI / CUIT (Clave Primaria):";

            this.txtDniCuit.Location = new System.Drawing.Point(15, 36); // Espacio de 24px hacia abajo
            this.txtDniCuit.Size = new System.Drawing.Size(220, 30);

            // Nombre Completo / Razón Social
            this.lblNombreCompleto.Location = new System.Drawing.Point(250, 12);
            this.lblNombreCompleto.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNombreCompleto.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblNombreCompleto.Values.Text = "Nombre Completo / Razón Social:";

            this.txtNombreCompleto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreCompleto.Location = new System.Drawing.Point(250, 36);
            this.txtNombreCompleto.Size = new System.Drawing.Size(515, 30);

            // Condición IVA (Alineado en X=780 para coincidir exactamente con la caja desplegable)
            this.lblIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIva.Location = new System.Drawing.Point(780, 12); // Corregido el desplazamiento X para alinear con cmbIva
            this.lblIva.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIva.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblIva.Values.Text = "Condición IVA:";

            this.cmbIva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbIva.Location = new System.Drawing.Point(780, 36);
            this.cmbIva.Size = new System.Drawing.Size(245, 30);

            // --- FILA 2 ---
            // Teléfono
            this.lblTelefono.Location = new System.Drawing.Point(15, 78);
            this.lblTelefono.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTelefono.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblTelefono.Values.Text = "Teléfono de Contacto:";

            this.txtTelefono.Location = new System.Drawing.Point(15, 102);
            this.txtTelefono.Size = new System.Drawing.Size(220, 30);

            // Correo Electrónico
            this.lblCorreo.Location = new System.Drawing.Point(250, 78);
            this.lblCorreo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCorreo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCorreo.Values.Text = "Correo Electrónico:";

            this.txtCorreo.Location = new System.Drawing.Point(250, 102);
            this.txtCorreo.Size = new System.Drawing.Size(250, 30);

            // Dirección / Domicilio
            this.lblDireccion.Location = new System.Drawing.Point(515, 78);
            this.lblDireccion.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDireccion.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDireccion.Values.Text = "Dirección / Domicilio de Facturación:";

            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(515, 102);
            this.txtDireccion.Size = new System.Drawing.Size(510, 30);

            // --- FILA 3 (Botonera alineada a la derecha) ---
            // Limpiar
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(525, 152);
            this.btnLimpiar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnLimpiar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLimpiar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Values.Text = "🧹 Limpiar Campos";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            // Guardar Nuevo
            this.btnGuardarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNuevo.Location = new System.Drawing.Point(695, 152);
            this.btnGuardarNuevo.Size = new System.Drawing.Size(165, 40);
            this.btnGuardarNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235); // Royal Blue
            this.btnGuardarNuevo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGuardarNuevo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarNuevo.Values.Text = "💾 Guardar Nuevo";
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);

            // Actualizar Registro
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(870, 152);
            this.btnActualizar.Size = new System.Drawing.Size(155, 40);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59); // Slate Oscuro
            this.btnActualizar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnActualizar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnActualizar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Values.Text = "✏️ Actualizar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // 
            // panelTabla (Tarjeta Inferior)
            // 
            this.panelTabla.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTabla.Controls.Add(this.lblBuscar);
            this.panelTabla.Controls.Add(this.txtBuscar);
            this.panelTabla.Controls.Add(this.lblFiltroEstado);
            this.panelTabla.Controls.Add(this.cmbFiltroEstado);
            this.panelTabla.Controls.Add(this.dgvClientes);
            this.panelTabla.Controls.Add(this.btnDesactivarCliente);
            this.panelTabla.Controls.Add(this.btnReactivarCliente);
            this.panelTabla.Location = new System.Drawing.Point(20, 275);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1040, 325);
            this.panelTabla.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelTabla.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelTabla.TabIndex = 2;

            // Buscador
            this.lblBuscar.Location = new System.Drawing.Point(15, 12);
            this.lblBuscar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBuscar.Values.Text = "Buscar Cliente:";

            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(15, 36);
            this.txtBuscar.Size = new System.Drawing.Size(750, 30);
            this.txtBuscar.CueHint.CueHintText = "🔍 Escriba DNI, CUIT, Nombre o Email para filtrar...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            // Filtro Estado (Alineado en X=780)
            this.lblFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroEstado.Location = new System.Drawing.Point(780, 12);
            this.lblFiltroEstado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEstado.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFiltroEstado.Values.Text = "Filtrar por Estado:";

            this.cmbFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroEstado.Location = new System.Drawing.Point(780, 36);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(245, 30);
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);

            // Grilla de Datos Estilizada
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.Location = new System.Drawing.Point(15, 76);
            this.dgvClientes.Size = new System.Drawing.Size(1010, 195);
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvClientes.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvClientes.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvClientes.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvClientes.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);

            // Botón Desactivar / Baja Lógica
            this.btnDesactivarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesactivarCliente.Location = new System.Drawing.Point(15, 278);
            this.btnDesactivarCliente.Size = new System.Drawing.Size(230, 38);
            this.btnDesactivarCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDesactivarCliente.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDesactivarCliente.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDesactivarCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDesactivarCliente.Values.Text = "🗑️ Desactivar Cliente";
            this.btnDesactivarCliente.Click += new System.EventHandler(this.btnDesactivarCliente_Click);

            // Botón Reactivar Cliente
            this.btnReactivarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReactivarCliente.Location = new System.Drawing.Point(795, 278);
            this.btnReactivarCliente.Size = new System.Drawing.Size(230, 38);
            this.btnReactivarCliente.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnReactivarCliente.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnReactivarCliente.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReactivarCliente.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReactivarCliente.Enabled = false;
            this.btnReactivarCliente.Values.Text = "♻️ Reactivar Cliente";
            this.btnReactivarCliente.Click += new System.EventHandler(this.btnReactivarCliente_Click);

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbIva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
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