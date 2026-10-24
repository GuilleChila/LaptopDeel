using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlInventarioNotebooks : UserControl
    {
        // Guardamos la lista en memoria para que el buscador y los filtros sean instantáneos
        private List<Notebook> listaNotebooksCompleta = new List<Notebook>();

        // 1. EL CONSTRUCTOR (Acá conectamos todo y hacemos la primera carga)
        public ControlInventarioNotebooks()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            // Conexiones de eventos que hicimos recién
            dgvInventario.SelectionChanged += dgvInventario_SelectionChanged;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            cmbFiltroCategoria.SelectedIndexChanged += cmbFiltroCategoria_SelectedIndexChanged;
            cmbFiltroEstado.SelectedIndexChanged += cmbFiltroEstado_SelectedIndexChanged;

            // Carga inicial (Solo se ejecuta una vez al arrancar)
            ConfigurarColumnasGrilla();
            CargarCombosHardware();
            CargarDatosDesdeBD();
            LimpiarFormulario();
        }

        // 2. EL EVENTO LOAD (Dejalo vacío para que no haga el trabajo dos veces)
        private void ControlInventarioNotebooks_Load(object sender, EventArgs e)
        {
            // Vacío intencionalmente (la carga ya se hizo en el constructor)
        }

        // 3. EL REFRESCO (¡Está perfecto como lo armaste!)
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            // Cada vez que el usuario vuelve a esta pestaña desde otra, 
            // actualizamos los combos por si agregó una nueva RAM o Procesador.
            if (this.Visible && !this.DesignMode)
            {
                CargarCombosHardware();
            }
        }

        public void CargarCombosHardware()
        {
            try
            {
                // 1. Marcas (Lista fija o podés agregar más)
                cmbMarca.Items.Clear();
                cmbMarca.Items.AddRange(new string[] { "Lenovo", "ASUS", "HP", "Dell", "Acer", "Apple", "MSI", "Gigabyte", "Samsung" });

                // 2. Procesadores desde la BD (filtramos con .Where para traer solo los activos)
                var daoProc = new ProcesadorDAO();
                cmbProcesador.DataSource = null;
                cmbProcesador.DataSource = daoProc.ObtenerTodos().Where(x => !x.Eliminado).ToList();
                cmbProcesador.ValueMember = "IdProcesador"; // Guarda el ID por detrás

                // 3. Memorias RAM desde la BD
                var daoRam = new RamDAO();
                cmbRam.DataSource = null;
                cmbRam.DataSource = daoRam.ObtenerTodos().Where(x => !x.Eliminado).ToList();
                cmbRam.ValueMember = "IdRam";

                // 4. Almacenamientos desde la BD
                var daoAlm = new AlmacenamientoDAO();
                cmbAlmacenamiento.DataSource = null;
                cmbAlmacenamiento.DataSource = daoAlm.ObtenerTodos().Where(x => !x.Eliminado).ToList();
                cmbAlmacenamiento.ValueMember = "IdAlmacenamiento";

                // 5. Pantallas desde la BD
                var daoPan = new PantallaDAO();
                cmbPantalla.DataSource = null;
                cmbPantalla.DataSource = daoPan.ObtenerTodos().Where(x => !x.Eliminado).ToList();
                cmbPantalla.ValueMember = "IdPantalla";

                // 6. Tarjetas Gráficas desde la BD 
                // (Nota: Si en tu diseño todavía tenés txtGpu, cambialo por un KryptonComboBox llamado cmbTarjetaGrafica)
                var daoGpu = new TarjetaGraficaDAO();
                cmbTarjetaGrafica.DataSource = null;
                cmbTarjetaGrafica.DataSource = daoGpu.ObtenerTodos().Where(x => !x.Eliminado).ToList();
                cmbTarjetaGrafica.ValueMember = "IdTarjetaGrafica";

                // 7. Filtro de Categorías desde la BD
                var daoCat = new CategoriaDAO();
                var categoriasActivas = daoCat.ObtenerTodos().Where(x => !x.Eliminado).Select(c => c.Nombre).ToArray();
                cmbFiltroCategoria.Items.Clear();
                cmbFiltroCategoria.Items.Add("Todas las Categorías");
                cmbFiltroCategoria.Items.AddRange(categoriasActivas);
                cmbFiltroCategoria.SelectedIndex = 0;

                // 8. Filtro de Estado
                cmbFiltroEstado.Items.Clear();
                cmbFiltroEstado.Items.AddRange(new string[] { "Activas", "Inactivas / Eliminadas" });
                cmbFiltroEstado.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar los componentes desde la base de datos: " + ex.Message,
                                       "Error de Carga", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvInventario.Columns.Clear();
            dgvInventario.AutoGenerateColumns = false;

            dgvInventario.Columns.Add("IdNotebook", "ID");
            dgvInventario.Columns.Add("Marca", "Marca");
            dgvInventario.Columns.Add("Modelo", "Modelo");
            dgvInventario.Columns.Add("Categorias", "Categorías"); // <-- NUEVA COLUMNA ACÁ
            dgvInventario.Columns.Add("Especificaciones", "Especificaciones de Hardware");
            dgvInventario.Columns.Add("Precio", "Precio ($)");
            dgvInventario.Columns.Add("Stock", "Stock (Uds)");
            dgvInventario.Columns.Add("Estado", "Estado");

            dgvInventario.Columns["IdNotebook"].Width = 50;
            dgvInventario.Columns["Categorias"].Width = 120; // Le damos un buen ancho
            dgvInventario.Columns["Especificaciones"].FillWeight = 200;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarDatosDesdeBD()
        {
            try
            {
                var dao = new NotebookDAO();
                listaNotebooksCompleta = dao.ObtenerTodos();
                AplicarFiltrosGrilla();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar inventario de notebooks: " + ex.Message, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void AplicarFiltrosGrilla()
        {
            if (dgvInventario.Columns.Count == 0) return;

            dgvInventario.Rows.Clear();

            // 1. Filtro por Estado (Índice 1 = "Inactivas / Eliminadas", cualquier otro = "Activas")
            bool mostrarEliminados = (cmbFiltroEstado.SelectedIndex == 1);
            var filtradas = listaNotebooksCompleta.Where(n => n.Eliminado == mostrarEliminados);

            // 2. Filtro por Categoría (Si no está en "Todas las Categorías")
            if (cmbFiltroCategoria.SelectedIndex > 0 && cmbFiltroCategoria.SelectedItem != null)
            {
                string categoriaElegida = cmbFiltroCategoria.SelectedItem.ToString().ToLower();
                filtradas = filtradas.Where(n =>
                    !string.IsNullOrEmpty(n.Categorias) &&
                    n.Categorias.ToLower().Contains(categoriaElegida));
            }

            // 3. Filtro por Caja de Búsqueda (Marca, Modelo, Hardware o Categoría)
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                filtradas = filtradas.Where(n =>
                    n.Marca.ToLower().Contains(textoBusqueda) ||
                    n.Modelo.ToLower().Contains(textoBusqueda) ||
                    n.Procesador.ToLower().Contains(textoBusqueda) ||
                    n.Ram.ToLower().Contains(textoBusqueda) ||
                    n.TarjetaGrafica.ToLower().Contains(textoBusqueda) ||
                    n.Categorias.ToLower().Contains(textoBusqueda));
            }

            // Llenamos la grilla con los resultados filtrados
            foreach (var n in filtradas)
            {
                // Texto limpio de specs sin la categoría mezclada
                string specs = $"{n.Procesador} | RAM: {n.Ram} | Disco: {n.Almacenamiento} | GPU: {n.TarjetaGrafica} | Pant: {n.Pantalla}";
                string estadoTexto = n.Eliminado ? "Inactiva" : "Activa";

                // Si no tiene categoría, mostramos un texto por defecto
                string categoriasTexto = string.IsNullOrEmpty(n.Categorias) ? "Sin categoría" : n.Categorias;

                // ACORDATE DE RESPETAR EL ORDEN DE LAS COLUMNAS AL AGREGAR
                int rowIndex = dgvInventario.Rows.Add(
                    n.IdNotebook,
                    n.Marca,
                    n.Modelo,
                    categoriasTexto, // <-- MANDAMOS EL DATO A LA NUEVA COLUMNA
                    specs,
                    n.Precio.ToString("N2"),
                    n.Stock,
                    estadoTexto
                );

                dgvInventario.Rows[rowIndex].Tag = n;
            }

            dgvInventario.ClearSelection();
        }

        private void LimpiarFormulario()
        {
            txtId.Text = string.Empty;
            txtModelo.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            numStock.Value = 1;

            chkGaming.Checked = false;
            chkDiseno.Checked = false;
            chkOficina.Checked = false;
            chkEstudio.Checked = false;

            cmbMarca.SelectedIndex = -1;
            cmbProcesador.SelectedIndex = -1;
            cmbRam.SelectedIndex = -1;
            cmbAlmacenamiento.SelectedIndex = -1;
            cmbPantalla.SelectedIndex = -1;
            cmbTarjetaGrafica.SelectedIndex = -1;

            btnGuardarNuevo.Enabled = true;
            btnActualizar.Enabled = false;

            dgvInventario.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e) => LimpiarFormulario();

        // Método auxiliar para validar y armar el objeto Notebook tanto al Insertar como al Actualizar
        private bool ConstruirNotebookDesdeFormulario(out Notebook notebook)
        {
            notebook = null;

            if (string.IsNullOrWhiteSpace(cmbMarca.Text) || string.IsNullOrWhiteSpace(txtModelo.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                KryptonMessageBox.Show("Por favor, complete Marca, Modelo y Precio.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            if (cmbProcesador.SelectedValue == null || cmbRam.SelectedValue == null ||
                cmbAlmacenamiento.SelectedValue == null || cmbPantalla.SelectedValue == null ||
                cmbTarjetaGrafica.SelectedValue == null)
            {
                KryptonMessageBox.Show("Seleccione todos los componentes de hardware en los desplegables.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio) || precio < 0)
            {
                KryptonMessageBox.Show("Ingrese un Precio numérico válido.", "Formato Incorrecto", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            notebook = new Notebook
            {
                Marca = cmbMarca.Text.Trim(),
                Modelo = txtModelo.Text.Trim(),
                Precio = precio,
                Stock = (int)numStock.Value,
                IdProcesador = Convert.ToInt32(cmbProcesador.SelectedValue),
                IdRam = Convert.ToInt32(cmbRam.SelectedValue),
                IdAlmacenamiento = Convert.ToInt32(cmbAlmacenamiento.SelectedValue),
                IdPantalla = Convert.ToInt32(cmbPantalla.SelectedValue),
                IdTarjetaGrafica = Convert.ToInt32(cmbTarjetaGrafica.SelectedValue)
            };

            return true;
        }
        private List<string> ObtenerCategoriasTildadas()
        {
            var lista = new List<string>();
            if (chkGaming.Checked) lista.Add("Gaming");
            if (chkDiseno.Checked) lista.Add("Diseño");
            if (chkOficina.Checked) lista.Add("Oficina");
            if (chkEstudio.Checked) lista.Add("Estudio");
            return lista;
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (!ConstruirNotebookDesdeFormulario(out Notebook nuevaNotebook)) return;

            var dao = new NotebookDAO();

            // 1. PRIMERO insertamos la Notebook en la BD
            if (dao.Insertar(nuevaNotebook, out string mensajeError))
            {
                // 2. UNA VEZ GUARDADA, ahora sí le asignamos las categorías tildadas
                // (Asegurate de que tu método Insertar actualice nuevaNotebook.IdNotebook con el LAST_INSERT_ID)
                dao.GuardarCategoriasDeNotebook(nuevaNotebook.IdNotebook, ObtenerCategoriasTildadas());

                KryptonMessageBox.Show("Notebook registrada exitosamente en el catálogo.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                CargarDatosDesdeBD();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Error al guardar la Notebook: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text)) return;
            if (!ConstruirNotebookDesdeFormulario(out Notebook notebookEditada)) return;

            notebookEditada.IdNotebook = Convert.ToInt32(txtId.Text);

            var dao = new NotebookDAO();
            if (dao.Actualizar(notebookEditada, out string mensajeError))
            {
                // 1° Guardamos los cambios de los CheckBoxes en la tabla intermedia
                dao.GuardarCategoriasDeNotebook(notebookEditada.IdNotebook, ObtenerCategoriasTildadas());

                // 2° Recién cuando todo se guardó en la BD, mostramos el cartel de éxito
                KryptonMessageBox.Show("Especificaciones, precio y categorías actualizados correctamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                CargarDatosDesdeBD();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Error al actualizar la Notebook: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnDesactivarNotebook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                KryptonMessageBox.Show("Seleccione un equipo de la grilla primero.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var dao = new NotebookDAO();

            if (dao.Desactivar(id, out string mensajeError))
            {
                KryptonMessageBox.Show("Equipo desactivado del catálogo público.", "Baja Lógica", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarDatosDesdeBD();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Error al desactivar: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnReactivarNotebook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                KryptonMessageBox.Show("Seleccione un equipo inactivo de la grilla primero.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            var dao = new NotebookDAO();

            if (dao.Reactivar(id, out string mensajeError))
            {
                KryptonMessageBox.Show("Equipo restaurado como disponible en el catálogo.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarDatosDesdeBD();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Error al reactivar: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void dgvInventario_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0 && dgvInventario.CurrentRow?.Tag is Notebook nb)
            {

                string cats = nb.Categorias.ToLower();
                chkGaming.Checked = cats.Contains("gaming");
                chkDiseno.Checked = cats.Contains("diseño") || cats.Contains("diseno");
                chkOficina.Checked = cats.Contains("ofimática") || cats.Contains("ofimatica");
                chkEstudio.Checked = cats.Contains("estudio");

                txtId.Text = nb.IdNotebook.ToString();
                cmbMarca.Text = nb.Marca;
                txtModelo.Text = nb.Modelo;
                txtPrecio.Text = nb.Precio.ToString("0.##");
                numStock.Value = nb.Stock >= numStock.Minimum && nb.Stock <= numStock.Maximum ? nb.Stock : 0;

                cmbProcesador.SelectedValue = nb.IdProcesador;
                cmbRam.SelectedValue = nb.IdRam;
                cmbAlmacenamiento.SelectedValue = nb.IdAlmacenamiento;
                cmbPantalla.SelectedValue = nb.IdPantalla;
                cmbTarjetaGrafica.SelectedValue = nb.IdTarjetaGrafica;

                btnGuardarNuevo.Enabled = false;
                btnActualizar.Enabled = true;
            }
        }

        private void cmbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            AplicarFiltrosGrilla();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

            bool mostrandoInactivos = cmbFiltroEstado.SelectedIndex == 1;
            btnReactivarNotebook.Enabled = mostrandoInactivos;
            btnDesactivarNotebook.Enabled = !mostrandoInactivos;

            AplicarFiltrosGrilla();
            LimpiarFormulario();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltrosGrilla();
        }

        
    }
}