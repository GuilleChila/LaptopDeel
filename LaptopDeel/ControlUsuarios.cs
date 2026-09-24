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

        public ControlUsuarios()
        {
            InitializeComponent();
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
            // Roles disponibles según la base de datos (1: Admin, 2: Vendedor, 3: Gerente)
            cmbRol.Items.Clear();
            cmbRol.Items.Add(new KeyValuePair<int, string>(1, "Administrador"));
            cmbRol.Items.Add(new KeyValuePair<int, string>(2, "Vendedor"));
            cmbRol.Items.Add(new KeyValuePair<int, string>(3, "Gerente"));
            cmbRol.DisplayMember = "Value";
            cmbRol.ValueMember = "Key";
            cmbRol.SelectedIndex = 0;

            // Filtro de estados
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

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0 && dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value != null)
            {
                int id = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells["IdUsuario"].Value);
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
                }
            }
        }

        private void btnGuardarNuevo_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            int idRolSeleccionado = 2; // Rol Vendedor por defecto

            if (cmbRol.SelectedItem is KeyValuePair<int, string> itemRol)
            {
                idRolSeleccionado = itemRol.Key;
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

            if (usuarioDAO.ExisteDniOCorreo(txtDni.Text.Trim(), txtCorreo.Text.Trim()))
            {
                KryptonMessageBox.Show("El DNI o el Correo ingresado ya se encuentran registrados para otro usuario.",
                    "Datos Duplicados", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return; // ¡CORTAMOS ACÁ! No dejamos que avance a guardar.
            }

            else
            {
                KryptonMessageBox.Show("No se pudo registrar el usuario. Verifique si el DNI o correo ya existen.", "Error",
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
                KryptonMessageBox.Show("Seleccione un usuario de la lista para desactivar.", "Atención",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = KryptonMessageBox.Show(
                "¿Está seguro de dar de baja lógicamente al usuario seleccionado?",
                "Confirmación de Baja",
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                bool exito = usuarioDAO.EliminarLogico(idUsuarioSeleccionado.Value);
                if (exito)
                {
                    KryptonMessageBox.Show("Usuario desactivado del sistema.", "Baja Exitosa",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    CargarGrilla();
                    LimpiarFormulario();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = null;
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now.AddYears(-18);
            txtCorreo.Text = string.Empty;
            txtContrasena.Text = string.Empty;

            if (cmbRol.Items.Count > 0) cmbRol.SelectedIndex = 0;

            dgvUsuarios.ClearSelection();
            btnGuardarNuevo.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private bool ValidarCampos()
        {
            // Limpiamos los espacios en blanco a los costados para evitar errores
            string dni = txtDni.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // 1. Validar campos vacíos (La que ya tenías)
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(contrasena))
            {
                KryptonMessageBox.Show("Por favor complete todos los campos obligatorios.", "Campos Incompletos",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            // 2. Validar DNI: Solo números y longitud máxima de 8
            if (!dni.All(char.IsDigit))
            {
                KryptonMessageBox.Show("El DNI solo puede contener números, sin puntos ni letras.", "DNI Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }
            if (dni.Length > 8 || dni.Length < 7) // En Argentina suelen ser 7 u 8 números
            {
                KryptonMessageBox.Show("El DNI debe tener entre 7 y 8 dígitos.", "DNI Inválido",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return false;
            }

            // 3. Validar Nombre y Apellido: Solo letras y espacios
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

            // Si pasó todas las barreras, la validación es exitosa
            return true;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cmbFiltroEstado_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();
    }
}