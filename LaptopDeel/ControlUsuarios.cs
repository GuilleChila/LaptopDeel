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
    public partial class ControlUsuarios : UserControl
    {
        private readonly UsuarioDAO usuarioDAO;
        private List<Usuario> listaUsuariosMemoria;
        private int? idUsuarioSeleccionado = null;
        private bool estaCargando = false;
        public ControlUsuarios()
        {
            InitializeComponent();
            LimpiarFormulario();
            // Le decimos que por defecto siempre intente rellenar el espacio donde lo pongan
            this.Dock = DockStyle.Fill;
            usuarioDAO = new UsuarioDAO();
            listaUsuariosMemoria = new List<Usuario>();
        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {
            CargarDesplegables();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void CargarDesplegables()
        {           
            cmbRol.Items.Clear();
            cmbRol.Items.Add(new KeyValuePair<int, string>(1, "Administrador"));
            cmbRol.Items.Add(new KeyValuePair<int, string>(2, "Vendedor"));
            cmbRol.Items.Add(new KeyValuePair<int, string>(3, "Gerente"));
            cmbRol.DisplayMember = "Value";
            cmbRol.ValueMember = "Key";
            cmbRol.SelectedIndex = 0;
           
            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("Activos");
            cmbFiltroEstado.Items.Add("Inactivos (Eliminados)");
            cmbFiltroEstado.Items.Add("Todos");
            cmbFiltroEstado.SelectedIndex = 0;
        }
        private void CargarGrilla()
        {
            try
            {
                listaUsuariosMemoria = usuarioDAO.ObtenerTodos();
                AplicarFiltros();
                dgvUsuarios.ClearSelection();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error al cargar la lista de usuarios: {ex.Message}", "Error de Conexión",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }

        }

        private void AplicarFiltros()
        {
            if (listaUsuariosMemoria == null) return;

            estaCargando = true;

            string busqueda = txtBuscar.Text.Trim().ToLower();
            int filtroEstado = cmbFiltroEstado.SelectedIndex;

            var resultado = listaUsuariosMemoria.Where(u =>
            {
                bool cumpleEstado = filtroEstado switch
                {
                    0 => !u.Eliminado,
                    1 => u.Eliminado,
                    _ => true
                };

                // Comprobación segura contra referencias nulas (Resuelve las 3 advertencias CS8602)
                bool cumpleBusqueda = string.IsNullOrEmpty(busqueda) ||
                                      (!string.IsNullOrEmpty(u.Nombre) && u.Nombre.ToLower().Contains(busqueda)) ||
                                      (!string.IsNullOrEmpty(u.Apellido) && u.Apellido.ToLower().Contains(busqueda)) ||
                                      (!string.IsNullOrEmpty(u.DNI) && u.DNI.Contains(busqueda)) ||
                                      (!string.IsNullOrEmpty(u.Correo) && u.Correo.ToLower().Contains(busqueda));

                return cumpleEstado && cumpleBusqueda;
            }).Select(u => new
            {
                u.IdUsuario,
                u.DNI,
                NombreCompleto = $"{u.Nombre} {u.Apellido}",
                u.Correo,
                FechaNacimiento = u.FechaNacimiento.ToString("dd/MM/yyyy"),
                Rol = u.IdRol switch { 1 => "Administrador", 2 => "Vendedor", 3 => "Gerente", _ => "Desconocido" },
                Estado = u.Eliminado ? "Inactivo" : "Activo"
            }).ToList();

            dgvUsuarios.DataSource = resultado;
            FormatearGrilla();

            // Soltamos la selección mientras el semáforo sigue en rojo
            dgvUsuarios.ClearSelection();

            estaCargando = false; // 🟢 VOLVEMOS EL SEMÁFORO A VERDE
        }

        private void FormatearGrilla()
        {
            if (dgvUsuarios.Columns["IdUsuario"] != null)
                dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";

            if (dgvUsuarios.Columns["NombreCompleto"] != null)
                dgvUsuarios.Columns["NombreCompleto"].HeaderText = "Nombre Completo";

            if (dgvUsuarios.Columns["FechaNacimiento"] != null)
                dgvUsuarios.Columns["FechaNacimiento"].HeaderText = "Fecha Nac.";

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

       

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (usuarioDAO.ExisteDniOCorreo(txtDni.Text.Trim(), txtCorreo.Text.Trim()))
            {
                KryptonMessageBox.Show("El DNI o el Correo ingresado ya se encuentran registrados para otro usuario.",
                    "Datos Duplicados", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return; // ¡CORTAMOS ACÁ! No dejamos que avance a guardar.
            }

            Usuario nuevo = new Usuario(
                idUsuario: 0,
                idRol: idRolSeleccionado,
                nombre: txtNombre.Text.Trim(),
                apellido: txtApellido.Text.Trim(),
                correo: txtCorreo.Text.Trim(),
                contrasena: txtContrasena.Text.Trim(),
                fechaNacimiento: dtpFechaNacimiento.Value,
                dni: txtDni.Text.Trim(),
                eliminado: false
            );

            bool exito = usuarioDAO.Insertar(nuevo);

            if (exito)
            {
                KryptonMessageBox.Show("Usuario registrado con éxito.", "Operación Exitosa",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                   CargarGrilla();
                   LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Ocurrió un error inesperado al intentar guardar en la base de datos.", "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null) return;
            if (!ValidarCampos()) return;

            int idRolSeleccionado = 2;
            if (cmbRol.SelectedItem is KeyValuePair<int, string> itemRol)
            {
                idRolSeleccionado = itemRol.Key;
            }

            Usuario usuarioEditado = new Usuario(
                idUsuario: idUsuarioSeleccionado.Value,
                idRol: idRolSeleccionado,
                nombre: txtNombre.Text.Trim(),
                apellido: txtApellido.Text.Trim(),
                correo: txtCorreo.Text.Trim(),
                contrasena: txtContrasena.Text.Trim(),
                fechaNacimiento: dtpFechaNacimiento.Value,
                dni: txtDni.Text.Trim(),
                eliminado: false
            );

            bool exito = usuarioDAO.Actualizar(usuarioEditado);
            if (exito)
            {
                KryptonMessageBox.Show("Datos de usuario actualizados correctamente.", "Operación Exitosa",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                CargarGrilla();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show("Ocurrió un error al intentar actualizar el registro.", "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnDesactivarUsuario_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado == null)
            {
                KryptonMessageBox.Show("Seleccione un usuario de la lista.", "Atención",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }
            // Averiguamos si el botón está en modo "Activar" o "Desactivar" leyendo su texto
            bool modoActivar = btnDesactivarUsuario.Values.Text.Contains("Activar");

            string mensajePregunta = modoActivar
                ? "¿Está seguro de REACTIVAR este usuario para que vuelva a tener acceso al sistema?"
                : "¿Está seguro de dar de baja lógicamente al usuario seleccionado?";

            DialogResult confirmacion = KryptonMessageBox.Show(
                mensajePregunta, "Confirmación",
                KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                // Ejecutamos el método correspondiente según el modo del botón
                bool exito = modoActivar
                    ? usuarioDAO.ActivarLogico(idUsuarioSeleccionado.Value)
                    : usuarioDAO.EliminarLogico(idUsuarioSeleccionado.Value);

                if (exito)
                {
                    string mensajeExito = modoActivar ? "Usuario reactivado con éxito." : "Usuario desactivado del sistema.";
                    KryptonMessageBox.Show(mensajeExito, "Operación Exitosa",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                    CargarGrilla();
                    LimpiarFormulario();

                    // Devolvemos el botón a su color rojo original por defecto
                    btnDesactivarUsuario.Values.Text = "🗑️ Desactivar Usuario Seleccionado";
                    btnDesactivarUsuario.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
                    btnDesactivarUsuario.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            // Vaciamos todas las cajas de texto
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();

            // Reseteamos el ComboBox y la Fecha
            if (cmbRol.Items.Count > 0)
            {
                cmbRol.SelectedIndex = 0;
            }
            dtpFechaNacimiento.Value = DateTime.Now;
 
            btnGuardarNuevo.Enabled = true;  // Volvemos a encender el botón Guardar
            btnActualizar.Enabled = false; // Apagamos el botón Actualizar
            idUsuarioSeleccionado = null;  // Le decimos al sistema que ya no hay nadie seleccionado

            // Devolvemos el botón Desactivar a su color rojo original
            btnDesactivarUsuario.Values.Text = "🗑️ Desactivar Usuario Seleccionado";
            btnDesactivarUsuario.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68);
            btnDesactivarUsuario.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);

            // Ponemos el cursor parpadeando en el primer recuadro
            txtNombre.Focus();
        }

        private bool ValidarCampos()
        {
            // Limpiamos los espacios en blanco a los costados para evitar errores
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validar campos vacíos (La que ya tenías)
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                KryptonMessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos Incompletos",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            //Validar DNI: Solo números y longitud máxima de 8
            if (!dni.All(char.IsDigit))
            {
                KryptonMessageBox.Show("El DNI solo puede contener números, sin puntos ni letras.", "DNI Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }
            if (dni.Length > 8 || dni.Length < 7) 
            {
                KryptonMessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "DNI Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            // Validar Nombre y Apellido: Solo letras y espacios
            if (!nombre.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)) ||
                !apellido.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                KryptonMessageBox.Show("El nombre y el apellido no pueden contener números ni símbolos.", "Formato Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            // 4. Validar Correo: Formato básico con arroba y punto
            if (!correo.Contains("@") || !correo.Contains("."))
            {
                KryptonMessageBox.Show("Por favor, ingrese una dirección de correo válida (ejemplo@correo.com).", "Correo Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }
         
            return true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex < 0) return;

            // Agarramos el ID de la fila exacta donde el usuario hizo clic
            if (dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                Usuario? u = listaUsuariosMemoria.FirstOrDefault(x => x.IdUsuario == id);

                if (u != null)
                {
                    idUsuarioSeleccionado = u.IdUsuario;
                    txtDni.Text = u.DNI ?? string.Empty;
                    txtNombre.Text = u.Nombre ?? string.Empty;
                    txtApellido.Text = u.Apellido ?? string.Empty;
                    dtpFechaNacimiento.Value = u.FechaNacimiento;
                    txtCorreo.Text = u.Correo ?? string.Empty;
                    txtContrasena.Text = u.Contrasena ?? string.Empty;

                    for (int i = 0; i < cmbRol.Items.Count; i++)
                    {
                        if (cmbRol.Items[i] is KeyValuePair<int, string> item && item.Key == u.IdRol)
                        {
                            cmbRol.SelectedIndex = i;
                            break;
                        }
                    }

                    btnGuardarNuevo.Enabled = false;
                    btnActualizar.Enabled = true;

                    if (u.Eliminado)
                    {
                        btnDesactivarUsuario.Values.Text = "♻️ Activar Usuario Seleccionado";
                        btnDesactivarUsuario.StateCommon.Back.Color1 = Color.FromArgb(34, 197, 94); // Verde
                        btnDesactivarUsuario.StateCommon.Back.Color2 = Color.FromArgb(34, 197, 94);
                    }
                    else // Si está activo, el botón se pone rojo y dice "Desactivar"
                    {
                        btnDesactivarUsuario.Values.Text = "🗑️ Desactivar Usuario Seleccionado";
                        btnDesactivarUsuario.StateCommon.Back.Color1 = Color.FromArgb(239, 68, 68); // Rojo 
                        btnDesactivarUsuario.StateCommon.Back.Color2 = Color.FromArgb(239, 68, 68);
                    }
                }
            }
        }

    }
}