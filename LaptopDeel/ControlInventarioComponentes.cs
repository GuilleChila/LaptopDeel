using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;
using System;
using System.Windows.Forms;

namespace LaptopDeel
{
    public partial class ControlInventarioComponentes : UserControl
    {
        public ControlInventarioComponentes()
        {
            InitializeComponent();
            this.dgvComponentes.SelectionChanged += new System.EventHandler(this.dgvComponentes_SelectionChanged);
        }

        private void dgvComponentes_SelectionChanged(object sender, EventArgs e)
        {
            // Restricción para rellenar los campos al hacer click
            if (dgvComponentes.CurrentRow != null && dgvComponentes.CurrentRow.Index > -1)
            {
                string seleccion = cmbTipoComponente.SelectedItem?.ToString();

                switch (seleccion)
                {
                    case "Almacenamientos":
                        // Escudo antibalas: Evita el error si las columnas todavía no terminaron de cargar
                        if (dgvComponentes.Columns.Contains("IdAlmacenamiento"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdAlmacenamiento"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Tipo"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Capacidad"].Value.ToString();

                            btnGuardar.Values.Text = "💾 Actualizar Registro";

                            bool estaEliminado = Convert.ToBoolean(dgvComponentes.CurrentRow.Cells["Eliminado"].Value);
                            if (estaEliminado)
                            {
                                btnDesactivar.Values.Text = "✅ Reactivar Registro";
                            }
                            else
                            {
                                btnDesactivar.Values.Text = "🗑️️ Eliminar/Desactivar";
                            }
                        }
                        break;

                    case "Pantallas":
                        // Escudo antibalas para Pantallas
                        if (dgvComponentes.Columns.Contains("IdPantalla"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdPantalla"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Tipo"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Tamano"].Value.ToString();
                            txtCampo3.Text = dgvComponentes.CurrentRow.Cells["TasaRefresco"].Value.ToString();
                            txtCampo4.Text = dgvComponentes.CurrentRow.Cells["Resolucion"].Value.ToString();

                            btnGuardar.Values.Text = "💾 Actualizar Registro";

                            bool estaEliminado = Convert.ToBoolean(dgvComponentes.CurrentRow.Cells["Eliminado"].Value);
                            if (estaEliminado)
                            {
                                btnDesactivar.Values.Text = "✅ Reactivar Registro";
                            }
                            else
                            {
                                btnDesactivar.Values.Text = "🗑️ Eliminar/Desactivar";
                            }
                        }
                        break;
                }
            }
        }

        private void LimpiarFormulario()
        {
            txtId.Text = string.Empty;
            txtCampo1.Text = string.Empty;
            txtCampo2.Text = string.Empty;
            txtCampo3.Text = string.Empty;
            txtCampo4.Text = string.Empty;

            btnGuardar.Values.Text = "💾 Guardar Registro";
            dgvComponentes.ClearSelection();

            btnDesactivar.Values.Text = "🗑️ Eliminar/Desactivar";
        }

        private void cmbTipoComponente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleccion = cmbTipoComponente.SelectedItem.ToString();
            OcultarTodosLosCampos();

            switch (seleccion)
            {
                case "Almacenamientos":
                    // Atributos: tipo, capacidad
                    ConfigurarCampo(1, "Tipo (Ej: SSD NVMe):");
                    ConfigurarCampo(2, "Capacidad (Ej: 1TB):");
                    CargarGrillaAlmacenamientos();
                    break;

                case "Pantallas":
                    // Atributos: tipo, tamano, tasa_refresco, resolucion
                    ConfigurarCampo(1, "Tipo (Ej: IPS):");
                    ConfigurarCampo(2, "Tamaño (Ej: 15.6\"):");
                    ConfigurarCampo(3, "Tasa de Refresco (Ej: 144Hz):");
                    ConfigurarCampo(4, "Resolución (Ej: 1920x1080):");
                    CargarGrillaPantallas();
                    break;

                case "Procesadores":
                    // Atributos: marca, generacion, velocidad, nombres
                    ConfigurarCampo(1, "Marca (Ej: Intel):");
                    ConfigurarCampo(2, "Generación (Ej: 13va):");
                    ConfigurarCampo(3, "Velocidad Base (Ej: 3.5GHz):");
                    ConfigurarCampo(4, "Nombres (Ej: Core i7):");
                    break;

                case "Memorias RAM":
                    // Atributos: generacion, capacidad
                    ConfigurarCampo(1, "Generación (Ej: DDR5):");
                    ConfigurarCampo(2, "Capacidad (Ej: 16GB):");
                    break;

                case "Tarjetas Gráficas":
                    // Atributos: nombre, marca, capacidad
                    ConfigurarCampo(1, "Nombre (Ej: RTX 4060):");
                    ConfigurarCampo(2, "Marca (Ej: NVIDIA):");
                    ConfigurarCampo(3, "Capacidad (Ej: 8GB):");
                    break;

                case "Categorías":
                    // Atributos: nombre, descripcion
                    ConfigurarCampo(1, "Nombre Categoría (Ej: Gaming):");
                    ConfigurarCampo(2, "Descripción Breve:");
                    break;
            }
        }

        // --- MÉTODOS AYUDANTES PARA EL DISEÑO LIMPIO ---

        private void OcultarTodosLosCampos()
        {
            lblCampo1.Visible = false; txtCampo1.Visible = false;
            lblCampo2.Visible = false; txtCampo2.Visible = false;
            lblCampo3.Visible = false; txtCampo3.Visible = false;
            lblCampo4.Visible = false; txtCampo4.Visible = false;

            // Limpiamos los textos anteriores
            txtCampo1.Text = ""; txtCampo2.Text = "";
            txtCampo3.Text = ""; txtCampo4.Text = "";
        }

        private void ConfigurarCampo(int numeroCampo, string titulo)
        {
            if (numeroCampo == 1) { lblCampo1.Text = titulo; lblCampo1.Visible = true; txtCampo1.Visible = true; }
            if (numeroCampo == 2) { lblCampo2.Text = titulo; lblCampo2.Visible = true; txtCampo2.Visible = true; }
            if (numeroCampo == 3) { lblCampo3.Text = titulo; lblCampo3.Visible = true; txtCampo3.Visible = true; }
            if (numeroCampo == 4) { lblCampo4.Text = titulo; lblCampo4.Visible = true; txtCampo4.Visible = true; }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que haya un catálogo seleccionado
            if (cmbTipoComponente.SelectedItem == null)
            {
                KryptonMessageBox.Show("Por favor, seleccione un catálogo a gestionar.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            string seleccion = cmbTipoComponente.SelectedItem.ToString();

            switch (seleccion)
            {
                case "Almacenamientos":
                    GuardarAlmacenamiento();
                    break;

                case "Pantallas":
                    GuardarPantalla();
                    break;
                case "Procesadores":
                case "Memorias RAM":
                case "Tarjetas Gráficas":
                case "Categorías":
                    KryptonMessageBox.Show($"El guardado de {seleccion} está en construcción...", "Info", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    break;
            }
        }

        private void GuardarAlmacenamiento()
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo2.Text))
            {
                KryptonMessageBox.Show("Por favor, complete el Tipo y la Capacidad.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            Almacenamiento obj = new Almacenamiento

            {
                Tipo = txtCampo1.Text.Trim(),
                Capacidad = txtCampo2.Text.Trim()
            };

            Datos.AlmacenamientoDAO dao = new Datos.AlmacenamientoDAO();
            string mensajeError;
            bool exito = false;

            // LA MAGIA: Si no hay ID, es un nuevo registro. Si hay ID, es una actualización.
            if (string.IsNullOrEmpty(txtId.Text))
            {
                exito = dao.Insertar(obj);
                mensajeError = exito ? "" : "No se pudo insertar el registro.";
            }
            else
            {
                obj.IdAlmacenamiento = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(obj);
                mensajeError = exito ? "" : "No se pudo actualizar el registro.";
            }

            if (exito)
            {
                KryptonMessageBox.Show("Operación realizada con éxito.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrillaAlmacenamientos();
            }
            else
            {
                KryptonMessageBox.Show("Error al guardar: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void GuardarPantalla()
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo2.Text) ||
                string.IsNullOrWhiteSpace(txtCampo3.Text) || string.IsNullOrWhiteSpace(txtCampo4.Text))
            {
                KryptonMessageBox.Show("Por favor, complete todos los campos de la pantalla.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }
            Pantalla obj = new Pantalla
            {
                Tipo = txtCampo1.Text.Trim(),
                Tamano = txtCampo2.Text.Trim(),
                TasaRefresco = txtCampo3.Text.Trim(),
                Resolucion = txtCampo4.Text.Trim()
            };
            PantallaDAO dao = new PantallaDAO();
            string mensajeError;
            bool exito = false;
            if (string.IsNullOrEmpty(txtId.Text))
            {
                exito = dao.Insertar(obj);
                mensajeError = exito ? "" : "No se pudo insertar el registro.";
            }
            else
            {
                obj.IdPantalla = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(obj);
                mensajeError = exito ? "" : "No se pudo actualizar el registro.";
            }
            if (exito)
            {
                KryptonMessageBox.Show("Operación realizada con éxito.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                LimpiarFormulario();
                CargarGrillaPantallas();
            }
            else
            {
                KryptonMessageBox.Show("Error al guardar: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }


        private void CargarGrillaAlmacenamientos()
        {
            Datos.AlmacenamientoDAO dao = new Datos.AlmacenamientoDAO();

            // El DAO ya nos devuelve la lista filtrada con Eliminado = 0
            var lista = dao.ObtenerTodos();

            // Refrescamos la grilla
            dgvComponentes.DataSource = null;
            dgvComponentes.DataSource = lista;

            // Ponemos lindos los títulos de las columnas (opcional pero muy recomendado)
            if (dgvComponentes.Columns.Count > 0)
            {
                dgvComponentes.Columns["IdAlmacenamiento"].HeaderText = "ID";
                dgvComponentes.Columns["IdAlmacenamiento"].Width = 50;
                dgvComponentes.Columns["Tipo"].HeaderText = "Tipo (Tecnología)";
                dgvComponentes.Columns["Capacidad"].HeaderText = "Capacidad";
                dgvComponentes.Columns["Eliminado"].Visible = false; // Ocultamos la columna lógica
            }
            dgvComponentes.ClearSelection();
        }

        private void CargarGrillaPantallas()
        {
            try
            {
                PantallaDAO dao = new PantallaDAO();
                var lista = dao.ObtenerTodos();
                dgvComponentes.DataSource = lista;

                // Ocultamos la columna Eliminado para que no ensucie la tabla
                if (dgvComponentes.Columns["Eliminado"] != null)
                {
                    dgvComponentes.Columns["Eliminado"].Visible = false;
                }

                // Le ponemos nombres más prolijos a las columnas
                if (dgvComponentes.Columns["IdPantalla"] != null) dgvComponentes.Columns["IdPantalla"].HeaderText = "ID";
                if (dgvComponentes.Columns["TasaRefresco"] != null) dgvComponentes.Columns["TasaRefresco"].HeaderText = "Refresco";
                if (dgvComponentes.Columns["Tamano"] != null) dgvComponentes.Columns["Tamano"].HeaderText = "Tamaño";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las pantallas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnDesactivar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                KryptonMessageBox.Show("Por favor, seleccione un registro de la tabla.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            bool estaEliminado = Convert.ToBoolean(dgvComponentes.CurrentRow.Cells["Eliminado"].Value);
            string accionTexto = estaEliminado ? "reactivar" : "eliminar/desactivar";

            DialogResult dialogResult = KryptonMessageBox.Show($"¿Está seguro que desea {accionTexto} este registro?", "Confirmar", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                string seleccion = cmbTipoComponente.SelectedItem.ToString();
                int id = Convert.ToInt32(txtId.Text);
                bool exito = false;

                try
                {
                    // 1. Ejecutamos la acción según el componente
                    switch (seleccion)
                    {
                        case "Almacenamientos":
                            Datos.AlmacenamientoDAO daoAlmacenamiento = new Datos.AlmacenamientoDAO();
                            exito = estaEliminado ? daoAlmacenamiento.Reactivar(id) : daoAlmacenamiento.Desactivar(id);
                            break;

                        case "Pantallas":
                            Datos.PantallaDAO daoPantalla = new Datos.PantallaDAO();
                            exito = estaEliminado ? daoPantalla.Reactivar(id) : daoPantalla.Desactivar(id);
                            break;
                    }

                    // 2. Si todo salió bien, avisamos y refrescamos
                    if (exito)
                    {
                        KryptonMessageBox.Show($"Registro {accionTexto}do correctamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                        LimpiarFormulario();

                        if (seleccion == "Almacenamientos") CargarGrillaAlmacenamientos();
                        else if (seleccion == "Pantallas") CargarGrillaPantallas();
                    }
                }
                catch (Exception ex) // <-- ACÁ ATRAPAMOS CUALQUIER ERROR DE LA BASE DE DATOS
                {
                    KryptonMessageBox.Show($"Error al {accionTexto}: " + ex.Message, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                }
            }
        }
    }
}