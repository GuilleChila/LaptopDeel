namespace LaptopDeel
{
    partial class ControlInventarioNotebooks
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
            cmbTarjetaGrafica = new Krypton.Toolkit.KryptonComboBox();
            lblId = new Krypton.Toolkit.KryptonLabel();
            txtId = new Krypton.Toolkit.KryptonTextBox();
            lblMarca = new Krypton.Toolkit.KryptonLabel();
            cmbMarca = new Krypton.Toolkit.KryptonComboBox();
            lblModelo = new Krypton.Toolkit.KryptonLabel();
            txtModelo = new Krypton.Toolkit.KryptonTextBox();
            lblPrecio = new Krypton.Toolkit.KryptonLabel();
            txtPrecio = new Krypton.Toolkit.KryptonTextBox();
            lblStock = new Krypton.Toolkit.KryptonLabel();
            numStock = new Krypton.Toolkit.KryptonNumericUpDown();
            lblProcesador = new Krypton.Toolkit.KryptonLabel();
            cmbProcesador = new Krypton.Toolkit.KryptonComboBox();
            lblRam = new Krypton.Toolkit.KryptonLabel();
            cmbRam = new Krypton.Toolkit.KryptonComboBox();
            lblAlmacenamiento = new Krypton.Toolkit.KryptonLabel();
            cmbAlmacenamiento = new Krypton.Toolkit.KryptonComboBox();
            lblPantalla = new Krypton.Toolkit.KryptonLabel();
            cmbPantalla = new Krypton.Toolkit.KryptonComboBox();
            lblGpu = new Krypton.Toolkit.KryptonLabel();
            lblCategorias = new Krypton.Toolkit.KryptonLabel();
            chkGaming = new Krypton.Toolkit.KryptonCheckBox();
            chkDiseno = new Krypton.Toolkit.KryptonCheckBox();
            chkOficina = new Krypton.Toolkit.KryptonCheckBox();
            chkEstudio = new Krypton.Toolkit.KryptonCheckBox();
            btnLimpiar = new Krypton.Toolkit.KryptonButton();
            btnGuardarNuevo = new Krypton.Toolkit.KryptonButton();
            btnActualizar = new Krypton.Toolkit.KryptonButton();
            panelTabla = new Krypton.Toolkit.KryptonPanel();
            lblBuscar = new Krypton.Toolkit.KryptonLabel();
            txtBuscar = new Krypton.Toolkit.KryptonTextBox();
            lblFiltroCategoria = new Krypton.Toolkit.KryptonLabel();
            cmbFiltroCategoria = new Krypton.Toolkit.KryptonComboBox();
            lblFiltroEstado = new Krypton.Toolkit.KryptonLabel();
            cmbFiltroEstado = new Krypton.Toolkit.KryptonComboBox();
            dgvInventario = new Krypton.Toolkit.KryptonDataGridView();
            btnDesactivarNotebook = new Krypton.Toolkit.KryptonButton();
            btnReactivarNotebook = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)panelFormulario).BeginInit();
            panelFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTarjetaGrafica).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbMarca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbProcesador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbRam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbAlmacenamiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbPantalla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).BeginInit();
            panelTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroCategoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // lblTituloModulo
            // 
            lblTituloModulo.Location = new Point(20, 12);
            lblTituloModulo.Name = "lblTituloModulo";
            lblTituloModulo.Size = new Size(458, 41);
            lblTituloModulo.StateCommon.ShortText.Color1 = Color.FromArgb(15, 23, 42);
            lblTituloModulo.StateCommon.ShortText.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTituloModulo.TabIndex = 0;
            lblTituloModulo.Values.Text = "Catálogo y Registro de Notebooks";
            // 
            // panelFormulario
            // 
            panelFormulario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelFormulario.Controls.Add(cmbTarjetaGrafica);
            panelFormulario.Controls.Add(lblId);
            panelFormulario.Controls.Add(txtId);
            panelFormulario.Controls.Add(lblMarca);
            panelFormulario.Controls.Add(cmbMarca);
            panelFormulario.Controls.Add(lblModelo);
            panelFormulario.Controls.Add(txtModelo);
            panelFormulario.Controls.Add(lblPrecio);
            panelFormulario.Controls.Add(txtPrecio);
            panelFormulario.Controls.Add(lblStock);
            panelFormulario.Controls.Add(numStock);
            panelFormulario.Controls.Add(lblProcesador);
            panelFormulario.Controls.Add(cmbProcesador);
            panelFormulario.Controls.Add(lblRam);
            panelFormulario.Controls.Add(cmbRam);
            panelFormulario.Controls.Add(lblAlmacenamiento);
            panelFormulario.Controls.Add(cmbAlmacenamiento);
            panelFormulario.Controls.Add(lblPantalla);
            panelFormulario.Controls.Add(cmbPantalla);
            panelFormulario.Controls.Add(lblGpu);
            panelFormulario.Controls.Add(lblCategorias);
            panelFormulario.Controls.Add(chkGaming);
            panelFormulario.Controls.Add(chkDiseno);
            panelFormulario.Controls.Add(chkOficina);
            panelFormulario.Controls.Add(chkEstudio);
            panelFormulario.Controls.Add(btnLimpiar);
            panelFormulario.Controls.Add(btnGuardarNuevo);
            panelFormulario.Controls.Add(btnActualizar);
            panelFormulario.Location = new Point(20, 50);
            panelFormulario.Name = "panelFormulario";
            panelFormulario.Size = new Size(1040, 235);
            panelFormulario.StateCommon.Color1 = Color.White;
            panelFormulario.StateCommon.Color2 = Color.White;
            panelFormulario.TabIndex = 1;
            // 
            // cmbTarjetaGrafica
            // 
            cmbTarjetaGrafica.Location = new Point(18, 162);
            cmbTarjetaGrafica.Name = "cmbTarjetaGrafica";
            cmbTarjetaGrafica.Size = new Size(194, 26);
            cmbTarjetaGrafica.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            cmbTarjetaGrafica.TabIndex = 28;
            // 
            // lblId
            // 
            lblId.Location = new Point(15, 10);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 24);
            lblId.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblId.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblId.TabIndex = 0;
            lblId.Values.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(15, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(65, 27);
            txtId.TabIndex = 1;
            // 
            // lblMarca
            // 
            lblMarca.Location = new Point(90, 10);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(61, 24);
            lblMarca.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblMarca.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblMarca.TabIndex = 2;
            lblMarca.Values.Text = "Marca:";
            // 
            // cmbMarca
            // 
            cmbMarca.Location = new Point(90, 34);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(160, 26);
            cmbMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            lblModelo.Location = new Point(260, 10);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(72, 24);
            lblModelo.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblModelo.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModelo.TabIndex = 4;
            lblModelo.Values.Text = "Modelo:";
            // 
            // txtModelo
            // 
            txtModelo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtModelo.Location = new Point(260, 34);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(425, 27);
            txtModelo.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrecio.Location = new Point(695, 10);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(85, 24);
            lblPrecio.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblPrecio.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecio.TabIndex = 6;
            lblPrecio.Values.Text = "Precio ($):";
            // 
            // txtPrecio
            // 
            txtPrecio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtPrecio.Location = new Point(695, 34);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(185, 27);
            txtPrecio.TabIndex = 7;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStock.Location = new Point(890, 4);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(99, 24);
            lblStock.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblStock.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStock.TabIndex = 8;
            lblStock.Values.Text = "Stock (Uds):";
            // 
            // numStock
            // 
            numStock.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numStock.Increment = new decimal(new int[] { 1, 0, 0, 0 });
            numStock.Location = new Point(890, 34);
            numStock.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            numStock.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(135, 26);
            numStock.TabIndex = 9;
            numStock.Value = new decimal(new int[] { 0, 0, 0, 0 });
            // 
            // lblProcesador
            // 
            lblProcesador.Location = new Point(15, 72);
            lblProcesador.Name = "lblProcesador";
            lblProcesador.Size = new Size(97, 24);
            lblProcesador.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblProcesador.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblProcesador.TabIndex = 10;
            lblProcesador.Values.Text = "Procesador:";
            // 
            // cmbProcesador
            // 
            cmbProcesador.Location = new Point(15, 96);
            cmbProcesador.Name = "cmbProcesador";
            cmbProcesador.Size = new Size(235, 26);
            cmbProcesador.TabIndex = 11;
            // 
            // lblRam
            // 
            lblRam.Location = new Point(260, 72);
            lblRam.Name = "lblRam";
            lblRam.Size = new Size(121, 24);
            lblRam.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblRam.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRam.TabIndex = 12;
            lblRam.Values.Text = "Memoria RAM:";
            // 
            // cmbRam
            // 
            cmbRam.Location = new Point(260, 96);
            cmbRam.Name = "cmbRam";
            cmbRam.Size = new Size(225, 26);
            cmbRam.TabIndex = 13;
            // 
            // lblAlmacenamiento
            // 
            lblAlmacenamiento.Location = new Point(495, 72);
            lblAlmacenamiento.Name = "lblAlmacenamiento";
            lblAlmacenamiento.Size = new Size(139, 24);
            lblAlmacenamiento.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblAlmacenamiento.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAlmacenamiento.TabIndex = 14;
            lblAlmacenamiento.Values.Text = "Almacenamiento:";
            // 
            // cmbAlmacenamiento
            // 
            cmbAlmacenamiento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbAlmacenamiento.Location = new Point(495, 96);
            cmbAlmacenamiento.Name = "cmbAlmacenamiento";
            cmbAlmacenamiento.Size = new Size(280, 26);
            cmbAlmacenamiento.TabIndex = 15;
            // 
            // lblPantalla
            // 
            lblPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPantalla.Location = new Point(682, 72);
            lblPantalla.Name = "lblPantalla";
            lblPantalla.Size = new Size(74, 24);
            lblPantalla.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblPantalla.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPantalla.TabIndex = 16;
            lblPantalla.Values.Text = "Pantalla:";
            // 
            // cmbPantalla
            // 
            cmbPantalla.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbPantalla.Location = new Point(785, 96);
            cmbPantalla.Name = "cmbPantalla";
            cmbPantalla.Size = new Size(240, 26);
            cmbPantalla.TabIndex = 17;
            // 
            // lblGpu
            // 
            lblGpu.Location = new Point(15, 132);
            lblGpu.Name = "lblGpu";
            lblGpu.Size = new Size(169, 24);
            lblGpu.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblGpu.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGpu.TabIndex = 18;
            lblGpu.Values.Text = "Tarjeta Gráfica (GPU):";
            // 
            // lblCategorias
            // 
            lblCategorias.Location = new Point(260, 132);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(225, 24);
            lblCategorias.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblCategorias.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategorias.TabIndex = 20;
            lblCategorias.Values.Text = "Categorías de Uso Asignadas:";
            // 
            // chkGaming
            // 
            chkGaming.Location = new Point(260, 158);
            chkGaming.Name = "chkGaming";
            chkGaming.Size = new Size(81, 24);
            chkGaming.TabIndex = 21;
            chkGaming.Values.Text = "Gaming";
            // 
            // chkDiseno
            // 
            chkDiseno.Location = new Point(340, 158);
            chkDiseno.Name = "chkDiseno";
            chkDiseno.Size = new Size(130, 24);
            chkDiseno.TabIndex = 22;
            chkDiseno.Values.Text = "Diseño/Edición";
            // 
            // chkOficina
            // 
            chkOficina.Location = new Point(460, 158);
            chkOficina.Name = "chkOficina";
            chkOficina.Size = new Size(75, 24);
            chkOficina.TabIndex = 23;
            chkOficina.Values.Text = "Oficina";
            // 
            // chkEstudio
            // 
            chkEstudio.Location = new Point(550, 158);
            chkEstudio.Name = "chkEstudio";
            chkEstudio.Size = new Size(78, 24);
            chkEstudio.TabIndex = 24;
            chkEstudio.Values.Text = "Estudio";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLimpiar.Location = new Point(525, 185);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(160, 40);
            btnLimpiar.StateCommon.Back.Color1 = Color.FromArgb(226, 232, 240);
            btnLimpiar.StateCommon.Back.Color2 = Color.FromArgb(226, 232, 240);
            btnLimpiar.StateCommon.Content.ShortText.Color1 = Color.FromArgb(51, 65, 85);
            btnLimpiar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar.TabIndex = 25;
            btnLimpiar.Values.DropDownArrowColor = Color.Empty;
            btnLimpiar.Values.Text = "\U0001f9f9 Limpiar Campos";
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardarNuevo
            // 
            btnGuardarNuevo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnGuardarNuevo.Location = new Point(695, 185);
            btnGuardarNuevo.Name = "btnGuardarNuevo";
            btnGuardarNuevo.Size = new Size(165, 40);
            btnGuardarNuevo.StateCommon.Back.Color1 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Back.Color2 = Color.FromArgb(37, 99, 235);
            btnGuardarNuevo.StateCommon.Content.ShortText.Color1 = Color.White;
            btnGuardarNuevo.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnGuardarNuevo.TabIndex = 26;
            btnGuardarNuevo.Values.DropDownArrowColor = Color.Empty;
            btnGuardarNuevo.Values.Text = "💾 Guardar Equipo";
            btnGuardarNuevo.Click += btnGuardarNuevo_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Enabled = false;
            btnActualizar.Location = new Point(870, 185);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(155, 40);
            btnActualizar.StateCommon.Back.Color1 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Back.Color2 = Color.FromArgb(30, 41, 59);
            btnActualizar.StateCommon.Content.ShortText.Color1 = Color.White;
            btnActualizar.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnActualizar.TabIndex = 27;
            btnActualizar.Values.DropDownArrowColor = Color.Empty;
            btnActualizar.Values.Text = "✏️ Actualizar";
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panelTabla
            // 
            panelTabla.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTabla.Controls.Add(lblBuscar);
            panelTabla.Controls.Add(txtBuscar);
            panelTabla.Controls.Add(lblFiltroCategoria);
            panelTabla.Controls.Add(cmbFiltroCategoria);
            panelTabla.Controls.Add(lblFiltroEstado);
            panelTabla.Controls.Add(cmbFiltroEstado);
            panelTabla.Controls.Add(dgvInventario);
            panelTabla.Controls.Add(btnDesactivarNotebook);
            panelTabla.Controls.Add(btnReactivarNotebook);
            panelTabla.Location = new Point(20, 298);
            panelTabla.Name = "panelTabla";
            panelTabla.Size = new Size(1040, 325);
            panelTabla.StateCommon.Color1 = Color.White;
            panelTabla.StateCommon.Color2 = Color.White;
            panelTabla.TabIndex = 2;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(18, 6);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(118, 24);
            lblBuscar.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblBuscar.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBuscar.TabIndex = 0;
            lblBuscar.Values.Text = "Buscar Equipo:";
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.CueHint.CueHintText = "🔍 Filtrar por Marca, Modelo o Especificación...";
            txtBuscar.Location = new Point(15, 36);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(520, 27);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // lblFiltroCategoria
            // 
            lblFiltroCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltroCategoria.Location = new Point(794, 6);
            lblFiltroCategoria.Name = "lblFiltroCategoria";
            lblFiltroCategoria.Size = new Size(86, 24);
            lblFiltroCategoria.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblFiltroCategoria.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltroCategoria.TabIndex = 2;
            lblFiltroCategoria.Values.Text = "Categoría:";
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroCategoria.Location = new Point(550, 36);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(220, 26);
            cmbFiltroCategoria.TabIndex = 3;
            cmbFiltroCategoria.SelectedIndexChanged += cmbFiltroCategoria_SelectedIndexChanged;
            // 
            // lblFiltroEstado
            // 
            lblFiltroEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblFiltroEstado.Location = new Point(550, 6);
            lblFiltroEstado.Name = "lblFiltroEstado";
            lblFiltroEstado.Size = new Size(133, 24);
            lblFiltroEstado.StateCommon.ShortText.Color1 = Color.FromArgb(30, 41, 59);
            lblFiltroEstado.StateCommon.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFiltroEstado.TabIndex = 4;
            lblFiltroEstado.Values.Text = "Estado Catálogo:";
            // 
            // cmbFiltroEstado
            // 
            cmbFiltroEstado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbFiltroEstado.Location = new Point(785, 36);
            cmbFiltroEstado.Name = "cmbFiltroEstado";
            cmbFiltroEstado.Size = new Size(240, 26);
            cmbFiltroEstado.TabIndex = 5;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.BorderStyle = BorderStyle.None;
            dgvInventario.ColumnHeadersHeight = 36;
            dgvInventario.Location = new Point(15, 76);
            dgvInventario.MultiSelect = false;
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersWidth = 51;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(1010, 195);
            dgvInventario.StateCommon.Background.Color1 = Color.FromArgb(248, 250, 252);
            dgvInventario.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            dgvInventario.StateCommon.HeaderColumn.Back.Color1 = Color.FromArgb(30, 41, 59);
            dgvInventario.StateCommon.HeaderColumn.Back.Color2 = Color.FromArgb(30, 41, 59);
            dgvInventario.StateCommon.HeaderColumn.Content.Color1 = Color.White;
            dgvInventario.StateCommon.HeaderColumn.Content.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dgvInventario.TabIndex = 6;
            // 
            // btnDesactivarNotebook
            // 
            btnDesactivarNotebook.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDesactivarNotebook.Location = new Point(15, 278);
            btnDesactivarNotebook.Name = "btnDesactivarNotebook";
            btnDesactivarNotebook.Size = new Size(230, 38);
            btnDesactivarNotebook.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesactivarNotebook.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
            btnDesactivarNotebook.StateCommon.Content.ShortText.Color1 = Color.White;
            btnDesactivarNotebook.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDesactivarNotebook.TabIndex = 7;
            btnDesactivarNotebook.Values.DropDownArrowColor = Color.Empty;
            btnDesactivarNotebook.Values.Text = "🗑️ Desactivar del Catálogo";
            btnDesactivarNotebook.Click += btnDesactivarNotebook_Click;
            // 
            // btnReactivarNotebook
            // 
            btnReactivarNotebook.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnReactivarNotebook.Enabled = false;
            btnReactivarNotebook.Location = new Point(795, 278);
            btnReactivarNotebook.Name = "btnReactivarNotebook";
            btnReactivarNotebook.Size = new Size(230, 38);
            btnReactivarNotebook.StateCommon.Back.Color1 = Color.FromArgb(16, 185, 129);
            btnReactivarNotebook.StateCommon.Back.Color2 = Color.FromArgb(16, 185, 129);
            btnReactivarNotebook.StateCommon.Content.ShortText.Color1 = Color.White;
            btnReactivarNotebook.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnReactivarNotebook.TabIndex = 8;
            btnReactivarNotebook.Values.DropDownArrowColor = Color.Empty;
            btnReactivarNotebook.Values.Text = "♻️ Reactivar en Catálogo";
            btnReactivarNotebook.Click += btnReactivarNotebook_Click;
            // 
            // ControlInventarioNotebooks
            // 
            BackColor = Color.FromArgb(203, 213, 225);
            Controls.Add(panelTabla);
            Controls.Add(panelFormulario);
            Controls.Add(lblTituloModulo);
            Name = "ControlInventarioNotebooks";
            Size = new Size(1080, 640);
            ((System.ComponentModel.ISupportInitialize)panelFormulario).EndInit();
            panelFormulario.ResumeLayout(false);
            panelFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbTarjetaGrafica).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbMarca).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbProcesador).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbRam).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbAlmacenamiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbPantalla).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelTabla).EndInit();
            panelTabla.ResumeLayout(false);
            panelTabla.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroCategoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbFiltroEstado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Krypton.Toolkit.KryptonLabel lblCategorias;
        private Krypton.Toolkit.KryptonCheckBox chkGaming;
        private Krypton.Toolkit.KryptonCheckBox chkDiseno;
        private Krypton.Toolkit.KryptonCheckBox chkOficina;
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
        private Krypton.Toolkit.KryptonComboBox cmbTarjetaGrafica;
    }
}