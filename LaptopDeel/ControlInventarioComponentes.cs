using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;
using System;
using System.Linq.Expressions;
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

                    case "Procesadores":
                        if (dgvComponentes.Columns.Contains("IdProcesador"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdProcesador"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Marca"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Generacion"].Value.ToString();
                            txtCampo3.Text = dgvComponentes.CurrentRow.Cells["Velocidad"].Value.ToString();
                            txtCampo4.Text = dgvComponentes.CurrentRow.Cells["Nombre"].Value.ToString();

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

                    case "Memorias RAM":
                        if (dgvComponentes.Columns.Contains("IdRam"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdRam"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Generacion"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Capacidad"].Value.ToString();

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

                    case "Tarjetas Gráficas":
                        if (dgvComponentes.Columns.Contains("IdTarjetaGrafica"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdTarjetaGrafica"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Nombre"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Marca"].Value.ToString();
                            txtCampo3.Text = dgvComponentes.CurrentRow.Cells["Capacidad"].Value.ToString();

                            btnGuardar.Values.Text = "💾 Actualizar Registro";
                            bool estaEliminado = Convert.ToBoolean(dgvComponentes.CurrentRow.Cells["Eliminado"].Value);
                            btnDesactivar.Values.Text = estaEliminado ? "✅ Reactivar Registro" : "🗑️ Eliminar/Desactivar";
                        }
                        break;

                    case "Categorías":
                        if (dgvComponentes.Columns.Contains("IdCategoria"))
                        {
                            txtId.Text = dgvComponentes.CurrentRow.Cells["IdCategoria"].Value.ToString();
                            txtCampo1.Text = dgvComponentes.CurrentRow.Cells["Nombre"].Value.ToString();
                            txtCampo2.Text = dgvComponentes.CurrentRow.Cells["Descripcion"].Value.ToString();

                            btnGuardar.Values.Text = "💾 Actualizar Registro";
                            bool estaEliminado = Convert.ToBoolean(dgvComponentes.CurrentRow.Cells["Eliminado"].Value);
                            btnDesactivar.Values.Text = estaEliminado ? "✅ Reactivar Registro" : "🗑️ Eliminar/Desactivar";
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
            btnDesactivar.Values.Text = "🗑️ Eliminar/Desactivar";
            dgvComponentes.ClearSelection();            
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
                    LimpiarFormulario();

                    break;

                case "Pantallas":
                    // Atributos: tipo, tamano, tasa_refresco, resolucion
                    ConfigurarCampo(1, "Tipo (Ej: IPS):");
                    ConfigurarCampo(2, "Tamaño (Ej: 15.6\"):");
                    ConfigurarCampo(3, "Tasa de Refresco (Ej: 144Hz):");
                    ConfigurarCampo(4, "Resolución (Ej: 1920x1080):");
                    CargarGrillaPantallas();
                    LimpiarFormulario();
                    break;

                case "Procesadores":
                    // Atributos: marca, generacion, velocidad, nombres
                    ConfigurarCampo(1, "Marca (Ej: Intel):");
                    ConfigurarCampo(2, "Generación (Ej: 13va):");
                    ConfigurarCampo(3, "Velocidad (Ej: 3.5GHz):");
                    ConfigurarCampo(4, "Nombre (Ej: Core i7):");
                    CargarGrillaProcesadores();
                    LimpiarFormulario();

                    break;

                case "Memorias RAM":
                    // Atributos: generacion, capacidad
                    ConfigurarCampo(1, "Generación (Ej: DDR5):");
                    ConfigurarCampo(2, "Capacidad (Ej: 16GB):");
                    CargarGrillaRams();
                    LimpiarFormulario();
                    break;

                case "Tarjetas Gráficas":
                    // Atributos: nombre, marca, capacidad
                    ConfigurarCampo(1, "Nombre (Ej: RTX 4060):");
                    ConfigurarCampo(2, "Marca (Ej: NVIDIA):");
                    ConfigurarCampo(3, "Capacidad (Ej: 8GB):");
                    CargarGrillaTarjetasGraficas();
                    LimpiarFormulario();
                    break;

                case "Categorías":
                    ConfigurarCampo(1, "Nombre (Ej: Gaming, Oficina):");
                    ConfigurarCampo(2, "Descripción:");                 
                    CargarGrillaCategorias();
                    LimpiarFormulario();
                    break;
            }
        }

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
                    GuardarProcesador();
                    break;
                case "Memorias RAM":
                    GuardarRam();
                    break;
                case "Tarjetas Gráficas":
                    GuardarTarjetaGrafica();
                    break;
                case "Categorías":
                   GuardarCategoria(); 
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

            Datos.AlmacenamientoDAO dao = new Datos.AlmacenamientoDAO();
            Almacenamiento obj = new Almacenamiento
            {
                Tipo = txtCampo1.Text.Trim(),
                Capacidad = txtCampo2.Text.Trim()
            };

            string mensajeError = ""; // <-- Inicializamos vacío
            bool exito = false;

            // LA MAGIA: Ahora sí le pasamos la mochila 'out mensajeError' para que el DAO la llene si algo falla
            if (string.IsNullOrEmpty(txtId.Text))
            {
                exito = dao.Insertar(obj, out mensajeError);
            }
            else
            {
                obj.IdAlmacenamiento = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(obj, out mensajeError);
            }

            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardado" : "actualizado";
                KryptonMessageBox.Show($"Almacenamiento {accion} con éxito.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                CargarGrillaAlmacenamientos();
                LimpiarFormulario();
            }
            else
            {
                // Y acá mostramos el error EXACTO que manda MariaDB
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

            PantallaDAO dao = new PantallaDAO();
            Pantalla obj = new Pantalla
            {
                Tipo = txtCampo1.Text.Trim(),
                Tamano = txtCampo2.Text.Trim(),
                TasaRefresco = txtCampo3.Text.Trim(),
                Resolucion = txtCampo4.Text.Trim()
            };

            string mensajeError = ""; // Inicializamos la variable que va a recibir el error
            bool exito = false;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                // Le pasamos el 'out mensajeError' al insertar
                exito = dao.Insertar(obj, out mensajeError);
            }
            else
            {
                obj.IdPantalla = Convert.ToInt32(txtId.Text);
                // Le pasamos el 'out mensajeError' al actualizar
                exito = dao.Actualizar(obj, out mensajeError);
            }

            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardada" : "actualizada";
                KryptonMessageBox.Show($"Pantalla {accion} exitosamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);                
                CargarGrillaPantallas();
                LimpiarFormulario();
            }
            else
            {
                // ¡Ahora sí muestra el error exacto que venga de la base de datos!
                KryptonMessageBox.Show("Error al guardar: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void GuardarProcesador()
        {
            // 1. Validamos que al menos la Marca y el Nombre no estén vacíos
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo4.Text))
            {
                KryptonMessageBox.Show("Por favor, complete al menos la Marca y el Nombre del procesador.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            // 2. Armamos el objeto Procesador con los datos de las cajas
            Datos.ProcesadorDAO dao = new Datos.ProcesadorDAO();
            Entidades.Procesador procesador = new Entidades.Procesador
            {
                Marca = txtCampo1.Text.Trim(),
                Generacion = txtCampo2.Text.Trim(),
                Velocidad = txtCampo3.Text.Trim(), // Si en la entidad usaste VelocidadBase o Nombre/Nombres según lo que definimos
                Nombre = txtCampo4.Text.Trim() // O Nombre, según tu clase Procesador.cs
            };

            string mensajeError = "";
            bool exito = false;

            // 3. Verificamos si es un registro NUEVO o una ACTUALIZACIÓN
            if (string.IsNullOrEmpty(txtId.Text))
            {
                // INSERTAR NUEVO
                exito = dao.Insertar(procesador, out mensajeError);
            }
            else
            {
                // ACTUALIZAR EXISTENTE
                procesador.IdProcesador = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(procesador, out mensajeError);
            }

            // 4. Feedback al usuario y refresco de pantalla
            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardado" : "actualizado";
                KryptonMessageBox.Show($"Procesador {accion} exitosamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarGrillaProcesadores();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Hubo un error al guardar el procesador: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void GuardarRam()
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo2.Text))
            {
                KryptonMessageBox.Show("Por favor, complete la Generación y la Capacidad.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            Datos.RamDAO dao = new Datos.RamDAO();
            Entidades.Ram ram = new Entidades.Ram
            {
                Generacion = txtCampo1.Text.Trim(),
                Capacidad = txtCampo2.Text.Trim()
            };

            string mensajeError = "";
            bool exito = false;

            if (string.IsNullOrEmpty(txtId.Text))
            {
                exito = dao.Insertar(ram, out mensajeError);

            }
            else
            {
                ram.IdRam = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(ram, out mensajeError);

            }

            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardada" : "actualizada";
                KryptonMessageBox.Show($"Memoria RAM {accion} exitosamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                CargarGrillaRams();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Error al guardar la RAM: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void GuardarTarjetaGrafica()
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text) || string.IsNullOrWhiteSpace(txtCampo2.Text) || string.IsNullOrWhiteSpace(txtCampo3.Text))
            {
                KryptonMessageBox.Show("Por favor, complete Nombre, Marca y Capacidad de la GPU.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            Datos.TarjetaGraficaDAO dao = new Datos.TarjetaGraficaDAO();
            Entidades.TarjetaGrafica gpu = new Entidades.TarjetaGrafica
            {
                Nombre = txtCampo1.Text.Trim(),
                Marca = txtCampo2.Text.Trim(),
                Capacidad = txtCampo3.Text.Trim()
            };

            string mensajeError = "";
            bool exito = false;

            if (string.IsNullOrEmpty(txtId.Text)) exito = dao.Insertar(gpu, out mensajeError);
            else
            {
                gpu.IdTarjetaGrafica = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(gpu, out mensajeError);
            }

            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardada" : "actualizada";
                KryptonMessageBox.Show($"Tarjeta Gráfica {accion} exitosamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarGrillaTarjetasGraficas();
                LimpiarFormulario();
            }
            else KryptonMessageBox.Show("Error al guardar la GPU: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
        }

        private void GuardarCategoria()
        {
            if (string.IsNullOrWhiteSpace(txtCampo1.Text))
            {
                KryptonMessageBox.Show("Por favor, complete al menos el Nombre de la categoría.", "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            Datos.CategoriaDAO dao = new Datos.CategoriaDAO();
            Entidades.Categoria categoria = new Entidades.Categoria
            {
                Nombre = txtCampo1.Text.Trim(),
                Descripcion = txtCampo2.Text.Trim() // txtCampo2 puede estar vacío si querés
            };

            string mensajeError = "";
            bool exito = false;

            if (string.IsNullOrEmpty(txtId.Text)) exito = dao.Insertar(categoria, out mensajeError);
            else
            {
                categoria.IdCategoria = Convert.ToInt32(txtId.Text);
                exito = dao.Actualizar(categoria, out mensajeError);
            }

            if (exito)
            {
                string accion = string.IsNullOrEmpty(txtId.Text) ? "guardada" : "actualizada";
                KryptonMessageBox.Show($"Categoría {accion} exitosamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarGrillaCategorias();
                LimpiarFormulario();
            }
            else KryptonMessageBox.Show("Error al guardar la Categoría: " + mensajeError, "Error BD", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
        }


        private void CargarGrillaAlmacenamientos()
        {
            try
            { 
                AlmacenamientoDAO dao = new AlmacenamientoDAO();
                var lista = dao.ObtenerTodos();
                dgvComponentes.DataSource = lista;


                if (dgvComponentes.Columns["Eliminado"] != null)
                {
                    dgvComponentes.Columns["Eliminado"].Visible = false;
                }

                if (dgvComponentes.Columns["IdAlmacenamiento"] != null) dgvComponentes.Columns["IdAlmacenamiento"].HeaderText = "ID";
                if (dgvComponentes.Columns["Tipo"] != null) dgvComponentes.Columns["Tipo"].HeaderText = "Tipo (Tecnología)";
                if (dgvComponentes.Columns["Capacidad"] != null) dgvComponentes.Columns["Capacidad"].HeaderText = "Capacidad";  
                if (dgvComponentes.Columns["Eliminado"] != null) dgvComponentes.Columns["Eliminado"].Visible = false;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las pantallas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           LimpiarFormulario();
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
            dgvComponentes.ClearSelection();
        }

        private void CargarGrillaProcesadores()
        {
            try
            {
                ProcesadorDAO dao = new ProcesadorDAO();
                var lista = dao.ObtenerTodos();
                dgvComponentes.DataSource = lista;

                if (dgvComponentes.Columns["Eliminado"] != null)
                {
                    dgvComponentes.Columns["Eliminado"].Visible = false;
                }

                if (dgvComponentes.Columns["IdProcesador"] != null) dgvComponentes.Columns["IdProcesador"].HeaderText = "ID";
                if (dgvComponentes.Columns["Velocidad"] != null) dgvComponentes.Columns["Velocidad"].HeaderText = "Velocidad";
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar los procesadores: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            dgvComponentes.ClearSelection();
        }

        private void CargarGrillaRams()
        {
            try
            {
                RamDAO dao = new RamDAO();
                dgvComponentes.DataSource = dao.ObtenerTodos();

                if (dgvComponentes.Columns["Eliminado"] != null) dgvComponentes.Columns["Eliminado"].Visible = false;
                if (dgvComponentes.Columns["IdRam"] != null) dgvComponentes.Columns["IdRam"].HeaderText = "ID";
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar RAMs: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            dgvComponentes.ClearSelection();
        }

        private void CargarGrillaTarjetasGraficas()
        {
            try
            {
                Datos.TarjetaGraficaDAO dao = new Datos.TarjetaGraficaDAO();
                dgvComponentes.DataSource = dao.ObtenerTodos();

                if (dgvComponentes.Columns["Eliminado"] != null) dgvComponentes.Columns["Eliminado"].Visible = false;
                if (dgvComponentes.Columns["IdTarjetaGrafica"] != null) dgvComponentes.Columns["IdTarjetaGrafica"].HeaderText = "ID";
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar Tarjetas Gráficas: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            dgvComponentes.ClearSelection();
        }

        private void CargarGrillaCategorias()
        {
            try
            {
                Datos.CategoriaDAO dao = new Datos.CategoriaDAO();
                dgvComponentes.DataSource = dao.ObtenerTodos();

                if (dgvComponentes.Columns["Eliminado"] != null) dgvComponentes.Columns["Eliminado"].Visible = false;
                if (dgvComponentes.Columns["IdCategoria"] != null) dgvComponentes.Columns["IdCategoria"].HeaderText = "ID";
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar Categorías: " + ex.Message, "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            dgvComponentes.ClearSelection();
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
            string mensajeError = "";

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
                            exito = estaEliminado ? daoAlmacenamiento.Reactivar(id, out mensajeError) : daoAlmacenamiento.Desactivar(id, out mensajeError);
                            break;

                        case "Pantallas":
                            Datos.PantallaDAO daoPantalla = new Datos.PantallaDAO();
                            exito = estaEliminado ? daoPantalla.Reactivar(id, out mensajeError) : daoPantalla.Desactivar(id, out mensajeError);
                            break;

                        case "Procesadores":
                            Datos.ProcesadorDAO daoProcesador = new Datos.ProcesadorDAO();
                            exito = estaEliminado ? daoProcesador.Reactivar(id, out mensajeError) : daoProcesador.Desactivar(id, out mensajeError);
                            break;

                        case "Memorias RAM":
                            Datos.RamDAO daoRam = new Datos.RamDAO();
                            exito = estaEliminado ? daoRam.Reactivar(id, out mensajeError) : daoRam.Desactivar(id, out mensajeError);
                            break;

                        case "Tarjetas Gráficas":
                            var daoGPU = new Datos.TarjetaGraficaDAO();
                            exito = estaEliminado ? daoGPU.Reactivar(id, out mensajeError) : daoGPU.Desactivar(id, out mensajeError);
                            break;
                    }

                    // 2. Si todo salió bien, avisamos y refrescamos
                    if (exito)
                    {
                        KryptonMessageBox.Show($"Registro {accionTexto}do correctamente.", "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                        LimpiarFormulario();

                        if (seleccion == "Almacenamientos") CargarGrillaAlmacenamientos();
                        else if (seleccion == "Pantallas") CargarGrillaPantallas();
                        else if (seleccion == "Procesadores") CargarGrillaProcesadores();
                        else if (seleccion == "Memorias RAM") CargarGrillaRams();
                        else if (seleccion == "Tarjetas Gráficas") CargarGrillaTarjetasGraficas();
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