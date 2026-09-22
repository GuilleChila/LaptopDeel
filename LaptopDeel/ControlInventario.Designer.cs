namespace LaptopDeel
{
    partial class ControlInventario
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

            // Bloque 1: Comercial
            this.lblId = new Krypton.Toolkit.KryptonLabel();
            this.txtId = new Krypton.Toolkit.KryptonTextBox();
            this.lblMarca = new Krypton.Toolkit.KryptonLabel();
            this.cmbMarca = new Krypton.Toolkit.KryptonComboBox();
            this.lblModelo = new Krypton.Toolkit.KryptonLabel();
            this.txtModelo = new Krypton.Toolkit.KryptonTextBox();
            this.lblPrecio = new Krypton.Toolkit.KryptonLabel();
            this.txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            this.lblStock = new Krypton.Toolkit.KryptonLabel();
            this.numStock = new Krypton.Toolkit.KryptonNumericUpDown();

            // Bloque 2: Hardware
            this.lblProcesador = new Krypton.Toolkit.KryptonLabel();
            this.cmbProcesador = new Krypton.Toolkit.KryptonComboBox();
            this.lblRam = new Krypton.Toolkit.KryptonLabel();
            this.cmbRam = new Krypton.Toolkit.KryptonComboBox();
            this.lblAlmacenamiento = new Krypton.Toolkit.KryptonLabel();
            this.cmbAlmacenamiento = new Krypton.Toolkit.KryptonComboBox();
            this.lblPantalla = new Krypton.Toolkit.KryptonLabel();
            this.cmbPantalla = new Krypton.Toolkit.KryptonComboBox();

            // Bloque 3: Gráfica y Categorías
            this.lblGpu = new Krypton.Toolkit.KryptonLabel();
            this.txtGpu = new Krypton.Toolkit.KryptonTextBox();
            this.lblCategorias = new Krypton.Toolkit.KryptonLabel();
            this.chkGaming = new Krypton.Toolkit.KryptonCheckBox();
            this.chkDiseno = new Krypton.Toolkit.KryptonCheckBox();
            this.chkOfimatica = new Krypton.Toolkit.KryptonCheckBox();
            this.chkEstudio = new Krypton.Toolkit.KryptonCheckBox();

            // Botonera Formulario
            this.btnLimpiar = new Krypton.Toolkit.KryptonButton();
            this.btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            this.btnActualizar = new Krypton.Toolkit.KryptonButton();

            // Tarjeta Inferior Listado
            this.panelTabla = new Krypton.Toolkit.KryptonPanel();
            this.lblBuscar = new Krypton.Toolkit.KryptonLabel();
            this.txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            this.lblFiltroCategoria = new Krypton.Toolkit.KryptonLabel();
            this.cmbFiltroCategoria = new Krypton.Toolkit.KryptonComboBox();
            this.lblFiltroEstado = new Krypton.Toolkit.KryptonLabel();
            this.cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            this.dgvInventario = new Krypton.Toolkit.KryptonDataGridView();
            this.btnDesactivarNotebook = new Krypton.Toolkit.KryptonButton();
            this.btnReactivarNotebook = new Krypton.Toolkit.KryptonButton();

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).BeginInit();
            this.panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).BeginInit();
            this.panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProcesador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlmacenamiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPantalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).BeginInit();
            this.SuspendLayout();

            // 
            // ControlInventario Base (Alto Contraste Slate)
            // 
            this.BackColor = System.Drawing.Color.FromArgb(203, 213, 225); // Slate medio para recortar las tarjetas
            this.Controls.Add(this.panelTabla);
            this.Controls.Add(this.panelFormulario);
            this.Controls.Add(this.lblTituloModulo);
            this.Name = "ControlInventario";
            this.Size = new System.Drawing.Size(1080, 640);
            this.Load += new System.EventHandler(this.ControlInventario_Load);

            // 
            // lblTituloModulo
            // 
            this.lblTituloModulo.Location = new System.Drawing.Point(20, 12);
            this.lblTituloModulo.Name = "lblTituloModulo";
            this.lblTituloModulo.Size = new System.Drawing.Size(380, 32);
            this.lblTituloModulo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTituloModulo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloModulo.TabIndex = 0;
            this.lblTituloModulo.Values.Text = "Catálogo y Registro de Notebooks";

            // 
            // panelFormulario (Tarjeta Superior Blanco Puro)
            // 
            this.panelFormulario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFormulario.Controls.Add(this.lblId);
            this.panelFormulario.Controls.Add(this.txtId);
            this.panelFormulario.Controls.Add(this.lblMarca);
            this.panelFormulario.Controls.Add(this.cmbMarca);
            this.panelFormulario.Controls.Add(this.lblModelo);
            this.panelFormulario.Controls.Add(this.txtModelo);
            this.panelFormulario.Controls.Add(this.lblPrecio);
            this.panelFormulario.Controls.Add(this.txtPrecio);
            this.panelFormulario.Controls.Add(this.lblStock);
            this.panelFormulario.Controls.Add(this.numStock);
            this.panelFormulario.Controls.Add(this.lblProcesador);
            this.panelFormulario.Controls.Add(this.cmbProcesador);
            this.panelFormulario.Controls.Add(this.lblRam);
            this.panelFormulario.Controls.Add(this.cmbRam);
            this.panelFormulario.Controls.Add(this.lblAlmacenamiento);
            this.panelFormulario.Controls.Add(this.cmbAlmacenamiento);
            this.panelFormulario.Controls.Add(this.lblPantalla);
            this.panelFormulario.Controls.Add(this.cmbPantalla);
            this.panelFormulario.Controls.Add(this.lblGpu);
            this.panelFormulario.Controls.Add(this.txtGpu);
            this.panelFormulario.Controls.Add(this.lblCategorias);
            this.panelFormulario.Controls.Add(this.chkGaming);
            this.panelFormulario.Controls.Add(this.chkDiseno);
            this.panelFormulario.Controls.Add(this.chkOfimatica);
            this.panelFormulario.Controls.Add(this.chkEstudio);
            this.panelFormulario.Controls.Add(this.btnLimpiar);
            this.panelFormulario.Controls.Add(this.btnGuardarNuevo);
            this.panelFormulario.Controls.Add(this.btnActualizar);
            this.panelFormulario.Location = new System.Drawing.Point(20, 50);
            this.panelFormulario.Name = "panelFormulario";
            this.panelFormulario.Size = new System.Drawing.Size(1040, 235);
            this.panelFormulario.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelFormulario.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelFormulario.TabIndex = 1;

            // --- FILA 1: DATOS COMERCIALES ---
            this.lblId.Location = new System.Drawing.Point(15, 10);
            this.lblId.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblId.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblId.Values.Text = "ID:";
            this.txtId.Location = new System.Drawing.Point(15, 34);
            this.txtId.Size = new System.Drawing.Size(65, 30);
            this.txtId.Enabled = false;

            this.lblMarca.Location = new System.Drawing.Point(90, 10);
            this.lblMarca.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMarca.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMarca.Values.Text = "Marca:";
            this.cmbMarca.Location = new System.Drawing.Point(90, 34);
            this.cmbMarca.Size = new System.Drawing.Size(160, 30);

            this.lblModelo.Location = new System.Drawing.Point(260, 10);
            this.lblModelo.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblModelo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblModelo.Values.Text = "Modelo:";
            this.txtModelo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelo.Location = new System.Drawing.Point(260, 34);
            this.txtModelo.Size = new System.Drawing.Size(425, 30);

            this.lblPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrecio.Location = new System.Drawing.Point(695, 10);
            this.lblPrecio.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPrecio.Values.Text = "Precio ($):";
            this.txtPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecio.Location = new System.Drawing.Point(695, 34);
            this.txtPrecio.Size = new System.Drawing.Size(185, 30);

            this.lblStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStock.Location = new System.Drawing.Point(890, 10);
            this.lblStock.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStock.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStock.Values.Text = "Stock (Uds):";
            this.numStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numStock.Location = new System.Drawing.Point(890, 34);
            this.numStock.Size = new System.Drawing.Size(135, 30);

            // --- FILA 2: HARDWARE MODULAR ---
            this.lblProcesador.Location = new System.Drawing.Point(15, 72);
            this.lblProcesador.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProcesador.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblProcesador.Values.Text = "Procesador:";
            this.cmbProcesador.Location = new System.Drawing.Point(15, 96);
            this.cmbProcesador.Size = new System.Drawing.Size(235, 30);

            this.lblRam.Location = new System.Drawing.Point(260, 72);
            this.lblRam.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRam.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRam.Values.Text = "Memoria RAM:";
            this.cmbRam.Location = new System.Drawing.Point(260, 96);
            this.cmbRam.Size = new System.Drawing.Size(225, 30);

            this.lblAlmacenamiento.Location = new System.Drawing.Point(495, 72);
            this.lblAlmacenamiento.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAlmacenamiento.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblAlmacenamiento.Values.Text = "Almacenamiento:";
            this.cmbAlmacenamiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbAlmacenamiento.Location = new System.Drawing.Point(495, 96);
            this.cmbAlmacenamiento.Size = new System.Drawing.Size(280, 30);

            this.lblPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPantalla.Location = new System.Drawing.Point(785, 72);
            this.lblPantalla.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPantalla.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPantalla.Values.Text = "Pantalla:";
            this.cmbPantalla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPantalla.Location = new System.Drawing.Point(785, 96);
            this.cmbPantalla.Size = new System.Drawing.Size(240, 30);

            // --- FILA 3: GRAFICA Y CATEGORIAS ---
            this.lblGpu.Location = new System.Drawing.Point(15, 132);
            this.lblGpu.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGpu.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblGpu.Values.Text = "Tarjeta Gráfica (GPU):";
            this.txtGpu.Location = new System.Drawing.Point(15, 156);
            this.txtGpu.Size = new System.Drawing.Size(235, 30);

            this.lblCategorias.Location = new System.Drawing.Point(260, 132);
            this.lblCategorias.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCategorias.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCategorias.Values.Text = "Categorías de Uso Asignadas:";

            this.chkGaming.Location = new System.Drawing.Point(260, 158);
            this.chkGaming.Values.Text = "Gaming";
            this.chkDiseno.Location = new System.Drawing.Point(340, 158);
            this.chkDiseno.Values.Text = "Diseño/Edición";
            this.chkOfimatica.Location = new System.Drawing.Point(460, 158);
            this.chkOfimatica.Values.Text = "Ofimática";
            this.chkEstudio.Location = new System.Drawing.Point(550, 158);
            this.chkEstudio.Values.Text = "Estudio";

            // --- FILA 4: BOTONERA RESALTADA ---
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.Location = new System.Drawing.Point(525, 185);
            this.btnLimpiar.Size = new System.Drawing.Size(160, 40);
            this.btnLimpiar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnLimpiar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnLimpiar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnLimpiar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.Values.Text = "🧹 Limpiar Campos";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);

            this.btnGuardarNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarNuevo.Location = new System.Drawing.Point(695, 185);
            this.btnGuardarNuevo.Size = new System.Drawing.Size(165, 40);
            this.btnGuardarNuevo.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGuardarNuevo.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGuardarNuevo.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGuardarNuevo.Values.Text = "💾 Guardar Equipo";
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);

            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(870, 185);
            this.btnActualizar.Size = new System.Drawing.Size(155, 40);
            this.btnActualizar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
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
            this.panelTabla.Controls.Add(this.lblFiltroCategoria);
            this.panelTabla.Controls.Add(this.cmbFiltroCategoria);
            this.panelTabla.Controls.Add(this.lblFiltroEstado);
            this.panelTabla.Controls.Add(this.cmbFiltroEstado);
            this.panelTabla.Controls.Add(this.dgvInventario);
            this.panelTabla.Controls.Add(this.btnDesactivarNotebook);
            this.panelTabla.Controls.Add(this.btnReactivarNotebook);
            this.panelTabla.Location = new System.Drawing.Point(20, 298);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Size = new System.Drawing.Size(1040, 325);
            this.panelTabla.StateCommon.Color1 = System.Drawing.Color.White;
            this.panelTabla.StateCommon.Color2 = System.Drawing.Color.White;
            this.panelTabla.TabIndex = 2;

            // Buscador
            this.lblBuscar.Location = new System.Drawing.Point(15, 12);
            this.lblBuscar.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBuscar.Values.Text = "Buscar Equipo:";

            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(15, 36);
            this.txtBuscar.Size = new System.Drawing.Size(520, 30);
            this.txtBuscar.CueHint.CueHintText = "🔍 Filtrar por Marca, Modelo o Especificación...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);

            // Filtros
            this.lblFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroCategoria.Location = new System.Drawing.Point(550, 12);
            this.lblFiltroCategoria.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroCategoria.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFiltroCategoria.Values.Text = "Categoría:";

            this.cmbFiltroCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(550, 36);
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(220, 30);
            this.cmbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroCategoria_SelectedIndexChanged);

            this.lblFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroEstado.Location = new System.Drawing.Point(785, 12);
            this.lblFiltroEstado.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFiltroEstado.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFiltroEstado.Values.Text = "Estado Catálogo:";

            this.cmbFiltroEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroEstado.Location = new System.Drawing.Point(785, 36);
            this.cmbFiltroEstado.Size = new System.Drawing.Size(240, 30);
            this.cmbFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.cmbFiltroEstado_SelectedIndexChanged);

            // Grilla
            this.dgvInventario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInventario.Location = new System.Drawing.Point(15, 76);
            this.dgvInventario.Size = new System.Drawing.Size(1010, 195);
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(248, 250, 252);
            this.dgvInventario.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvInventario.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(30, 41, 59);
            this.dgvInventario.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.White;
            this.dgvInventario.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dgvInventario.SelectionChanged += new System.EventHandler(this.dgvInventario_SelectionChanged);

            // Botones de Estado
            this.btnDesactivarNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDesactivarNotebook.Location = new System.Drawing.Point(15, 278);
            this.btnDesactivarNotebook.Size = new System.Drawing.Size(230, 38);
            this.btnDesactivarNotebook.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDesactivarNotebook.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDesactivarNotebook.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDesactivarNotebook.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDesactivarNotebook.Values.Text = "🗑️ Desactivar del Catálogo";
            this.btnDesactivarNotebook.Click += new System.EventHandler(this.btnDesactivarNotebook_Click);

            this.btnReactivarNotebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReactivarNotebook.Location = new System.Drawing.Point(795, 278);
            this.btnReactivarNotebook.Size = new System.Drawing.Size(230, 38);
            this.btnReactivarNotebook.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnReactivarNotebook.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnReactivarNotebook.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnReactivarNotebook.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnReactivarNotebook.Enabled = false;
            this.btnReactivarNotebook.Values.Text = "♻️ Reactivar en Catálogo";
            this.btnReactivarNotebook.Click += new System.EventHandler(this.btnReactivarNotebook_Click);

            ((System.ComponentModel.ISupportInitialize)(this.panelFormulario)).EndInit();
            this.panelFormulario.ResumeLayout(false);
            this.panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTabla)).EndInit();
            this.panelTabla.ResumeLayout(false);
            this.panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProcesador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbAlmacenamiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPantalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiltroEstado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTituloModulo;
        private Krypton.Toolkit.KryptonPanel panelFormulario;
        private Krypton.Toolkit.KryptonLabel lblId;
        private Krypton.Toolkit.KryptonTextBox txtId;
        private Krypton.Toolkit.KryptonLabel lblMarca;
        private Krypton.Toolkit.KryptonComboBox cmbMarca;
        private Krypton.Toolkit.KryptonLabel lblModelo;
        private Krypton.Toolkit.KryptonTextBox txtModelo;
        private Krypton.Toolkit.KryptonLabel lblPrecio;
        private Krypton.Toolkit.KryptonTextBox txtPrecio;
        private Krypton.Toolkit.KryptonLabel lblStock;
        private Krypton.Toolkit.KryptonNumericUpDown numStock;

        private Krypton.Toolkit.KryptonLabel lblProcesador;
        private Krypton.Toolkit.KryptonComboBox cmbProcesador;
        private Krypton.Toolkit.KryptonLabel lblRam;
        private Krypton.Toolkit.KryptonComboBox cmbRam;
        private Krypton.Toolkit.KryptonLabel lblAlmacenamiento;
        private Krypton.Toolkit.KryptonComboBox cmbAlmacenamiento;
        private Krypton.Toolkit.KryptonLabel lblPantalla;
        private Krypton.Toolkit.KryptonComboBox cmbPantalla;

        private Krypton.Toolkit.KryptonLabel lblGpu;
        private Krypton.Toolkit.KryptonTextBox txtGpu;
        private Krypton.Toolkit.KryptonLabel lblCategorias;
        private Krypton.Toolkit.KryptonCheckBox chkGaming;
        private Krypton.Toolkit.KryptonCheckBox chkDiseno;
        private Krypton.Toolkit.KryptonCheckBox chkOfimatica;
        private Krypton.Toolkit.KryptonCheckBox chkEstudio;

        private Krypton.Toolkit.KryptonButton btnLimpiar;
        private Krypton.Toolkit.KryptonButton btnGuardarNuevo;
        private Krypton.Toolkit.KryptonButton btnActualizar;

        private Krypton.Toolkit.KryptonPanel panelTabla;
        private Krypton.Toolkit.KryptonLabel lblBuscar;
        private Krypton.Toolkit.KryptonTextBox txtBuscar;
        private Krypton.Toolkit.KryptonLabel lblFiltroCategoria;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroCategoria;
        private Krypton.Toolkit.KryptonLabel lblFiltroEstado;
        private Krypton.Toolkit.KryptonComboBox cmbFiltroEstado;
        private Krypton.Toolkit.KryptonDataGridView dgvInventario;
        private Krypton.Toolkit.KryptonButton btnDesactivarNotebook;
        private Krypton.Toolkit.KryptonButton btnReactivarNotebook;
    }
}