using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlClientes : UserControl
    {
        private readonly ClientesDAO _clientesDAO;
        private List<Cliente> _listaClientesMemoria;
        private Cliente? _clienteSeleccionado;
        private bool _modoEdicion;

        private readonly Color _colorAzulActivo = Color.FromArgb(37, 99, 235);
        private readonly Color _colorGrisInactivo = Color.FromArgb(148, 163, 184);

        public ControlClientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            _clientesDAO = new ClientesDAO();
            _listaClientesMemoria = new List<Cliente>();
            _clienteSeleccionado = null;
            _modoEdicion = false;
        }

        private void ControlClientes_Load(object? sender, EventArgs e)
        {
            CargarCombos();
            ConfigurarColumnasGrilla();
            SuscribirEventosValidacion();
            CargarGrilla();
            LimpiarFormulario();
        }

        private void CargarCombos()
        {
            cmbIva.Items.Clear();
            cmbIva.Items.Add("Consumidor Final");
            cmbIva.Items.Add("Responsable Inscripto");
            cmbIva.Items.Add("Monotributo");
            cmbIva.Items.Add("Exento");
            cmbIva.SelectedIndex = 0;

            cmbFiltroEstado.Items.Clear();
            cmbFiltroEstado.Items.Add("Activos");
            cmbFiltroEstado.Items.Add("Inactivos / Eliminados");
            cmbFiltroEstado.SelectedIndex = 0;
        }

        private void ConfigurarColumnasGrilla()
        {
            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("IdCliente", "ID");
            dgvClientes.Columns["IdCliente"].Visible = false;

            dgvClientes.Columns.Add("Dni", "DNI / CUIT");
            dgvClientes.Columns.Add("NombreCompleto", "Nombre Completo / Razón Social");
            dgvClientes.Columns.Add("Correo", "Correo Electrónico");
            dgvClientes.Columns.Add("Telefono", "Teléfono");
            dgvClientes.Columns.Add("Direccion", "Dirección");
            dgvClientes.Columns.Add("Iva", "Condición IVA");
            dgvClientes.Columns.Add("Estado", "Estado");

            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.ReadOnly = true;
        }

        private void SuscribirEventosValidacion()
        {
            txtDniCuit.TextChanged += EvaluarEstadoBotones;
            txtNombreCompleto.TextChanged += EvaluarEstadoBotones;
            txtTelefono.TextChanged += EvaluarEstadoBotones;
            txtCorreo.TextChanged += EvaluarEstadoBotones;
            txtDireccion.TextChanged += EvaluarEstadoBotones;
            cmbIva.SelectedIndexChanged += EvaluarEstadoBotones;
        }

        // --- VALIDACIONES DE CAMPOS ---

        private bool ValidarDniCuit(out string mensaje)
        {
            string val = txtDniCuit.Text.Trim();
            if (string.IsNullOrEmpty(val))
            {
                mensaje = "El DNI/CUIT es obligatorio.";
                return false;
            }
            if (!Regex.IsMatch(val, @"^\d+$"))
            {
                mensaje = "El DNI/CUIT solo debe contener números (sin espacios ni puntos).";
                return false;
            }
            if (val.Length < 8 || val.Length > 11)
            {
                mensaje = "El DNI/CUIT debe tener entre 8 y 11 dígitos.";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }

        private bool ValidarNombreCompleto(out string mensaje)
        {
            string val = txtNombreCompleto.Text.Trim();
            if (string.IsNullOrEmpty(val))
            {
                mensaje = "El Nombre Completo / Razón Social es obligatorio.";
                return false;
            }
            if (val.Length > 150)
            {
                mensaje = "El Nombre Completo no puede superar los 150 caracteres.";
                return false;
            }
            if (!Regex.IsMatch(val, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                mensaje = "El Nombre Completo solo permite letras y espacios.";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }

        private bool ValidarTelefono(out string mensaje)
        {
            string val = txtTelefono.Text.Trim();
            if (string.IsNullOrEmpty(val))
            {
                mensaje = "El Teléfono es obligatorio.";
                return false;
            }
            if (!Regex.IsMatch(val, @"^\d+$"))
            {
                mensaje = "El Teléfono solo permite números (sin espacios, guiones ni puntos).";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }

        private bool ValidarCorreo(out string mensaje)
        {
            string val = txtCorreo.Text.Trim();
            if (string.IsNullOrEmpty(val))
            {
                mensaje = "El Correo Electrónico es obligatorio.";
                return false;
            }
            if (!val.Contains("@"))
            {
                mensaje = "El Correo Electrónico debe incluir el carácter '@'.";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }

        private bool ValidarDireccion(out string mensaje)
        {
            string val = txtDireccion.Text.Trim();
            if (string.IsNullOrEmpty(val))
            {
                mensaje = "La Dirección es obligatoria.";
                return false;
            }
            if (!Regex.IsMatch(val, @"^.+\s\d{1,4}$"))
            {
                mensaje = "La Dirección debe incluir calle y altura (ej: Av. Italia 1234, hasta 4 dígitos).";
                return false;
            }
            mensaje = string.Empty;
            return true;
        }

        private bool SonTodosLosCamposValidos()
        {
            return ValidarDniCuit(out _) &&
                   ValidarNombreCompleto(out _) &&
                   ValidarTelefono(out _) &&
                   ValidarCorreo(out _) &&
                   ValidarDireccion(out _) &&
                   cmbIva.SelectedIndex >= 0;
        }

        private bool UnificaryValidarFormulario()
        {
            if (!ValidarDniCuit(out string err1))
            {
                MostrarMensajeError(err1);
                txtDniCuit.Focus();
                return false;
            }
            if (!ValidarNombreCompleto(out string err2))
            {
                MostrarMensajeError(err2);
                txtNombreCompleto.Focus();
                return false;
            }
            if (!ValidarTelefono(out string err3))
            {
                MostrarMensajeError(err3);
                txtTelefono.Focus();
                return false;
            }
            if (!ValidarCorreo(out string err4))
            {
                MostrarMensajeError(err4);
                txtCorreo.Focus();
                return false;
            }
            if (!ValidarDireccion(out string err5))
            {
                MostrarMensajeError(err5);
                txtDireccion.Focus();
                return false;
            }
            return true;
        }

        private void MostrarMensajeError(string mensaje)
        {
            KryptonMessageBox.Show(
                mensaje,
                "Validación de Campos",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Warning
            );
        }

        // --- LÓGICA Y ESTADO DE BOTONES ---

        private void EvaluarEstadoBotones(object? sender, EventArgs? e)
        {
            if (!_modoEdicion)
            {
                bool valido = SonTodosLosCamposValidos();
                btnGuardarNuevo.Enabled = valido;
                btnGuardarNuevo.StateCommon.Back.Color1 = valido ? _colorAzulActivo : _colorGrisInactivo;
                btnGuardarNuevo.StateCommon.Back.Color2 = valido ? _colorAzulActivo : _colorGrisInactivo;

                btnActualizar.Enabled = false;
            }
            else
            {
                btnGuardarNuevo.Enabled = false;
                btnGuardarNuevo.StateCommon.Back.Color1 = _colorGrisInactivo;
                btnGuardarNuevo.StateCommon.Back.Color2 = _colorGrisInactivo;

                bool huboCambios = HaCambiadoRegistro();
                btnActualizar.Enabled = huboCambios && SonTodosLosCamposValidos();
            }
        }

        private bool HaCambiadoRegistro()
        {
            if (_clienteSeleccionado == null) return false;

            return txtDniCuit.Text.Trim() != _clienteSeleccionado.Dni ||
                   txtNombreCompleto.Text.Trim() != _clienteSeleccionado.NombreCompleto ||
                   txtTelefono.Text.Trim() != _clienteSeleccionado.Telefono ||
                   txtCorreo.Text.Trim() != _clienteSeleccionado.Correo ||
                   txtDireccion.Text.Trim() != _clienteSeleccionado.Direccion ||
                   cmbIva.SelectedItem?.ToString() != _clienteSeleccionado.Iva;
        }

        private void LimpiarFormulario()
        {
            _modoEdicion = false;
            _clienteSeleccionado = null;

            txtDniCuit.Text = string.Empty;
            txtDniCuit.Enabled = true;
            txtNombreCompleto.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            cmbIva.SelectedIndex = 0;

            btnLimpiar.Enabled = false;
            btnActualizar.Enabled = false;

            btnGuardarNuevo.Enabled = false;
            btnGuardarNuevo.StateCommon.Back.Color1 = _colorGrisInactivo;
            btnGuardarNuevo.StateCommon.Back.Color2 = _colorGrisInactivo;

            dgvClientes.ClearSelection();
            ActualizarBotonesBajaReactivacion();
        }

        private void CargarGrilla()
        {
            _listaClientesMemoria = _clientesDAO.ObtenerTodos();
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            if (_listaClientesMemoria == null) return;

            string busqueda = txtBuscar.Text.Trim().ToLower();
            bool mostrarInactivos = cmbFiltroEstado.SelectedIndex == 1;

            var listaFiltrada = _listaClientesMemoria.Where(c =>
            {
                bool coincideEstado = c.Eliminado == mostrarInactivos;
                bool coincideBusqueda = string.IsNullOrEmpty(busqueda) ||
                                         (!string.IsNullOrEmpty(c.Dni) && c.Dni.ToLower().Contains(busqueda)) ||
                                         (!string.IsNullOrEmpty(c.NombreCompleto) && c.NombreCompleto.ToLower().Contains(busqueda)) ||
                                         (!string.IsNullOrEmpty(c.Correo) && c.Correo.ToLower().Contains(busqueda));

                return coincideEstado && coincideBusqueda;
            }).ToList();

            dgvClientes.Rows.Clear();
            foreach (var cli in listaFiltrada)
            {
                dgvClientes.Rows.Add(
                    cli.IdCliente,
                    cli.Dni,
                    cli.NombreCompleto,
                    cli.Correo,
                    cli.Telefono,
                    cli.Direccion,
                    cli.Iva,
                    cli.Eliminado ? "Inactivo / Eliminado" : "Activo"
                );
            }

            dgvClientes.ClearSelection();
            ActualizarBotonesBajaReactivacion();
        }

        private void ActualizarBotonesBajaReactivacion()
        {
            bool haySeleccion = dgvClientes.SelectedRows.Count > 0;

            if (haySeleccion && _clienteSeleccionado != null)
            {
                btnDesactivarCliente.Enabled = !_clienteSeleccionado.Eliminado;
                btnReactivarCliente.Enabled = _clienteSeleccionado.Eliminado;
            }
            else
            {
                btnDesactivarCliente.Enabled = false;
                btnReactivarCliente.Enabled = false;
            }
        }

        // --- ACCIONES DE BOTONES ---

        private void btnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void btnGuardarNuevo_Click(object? sender, EventArgs e)
        {
            if (!UnificaryValidarFormulario()) return;

            string selectedIva = cmbIva.SelectedItem?.ToString() ?? "Consumidor Final";

            var nuevoCliente = new Cliente(
                idCliente: 0,
                dni: txtDniCuit.Text.Trim(),
                nombreCompleto: txtNombreCompleto.Text.Trim(),
                correo: txtCorreo.Text.Trim(),
                telefono: txtTelefono.Text.Trim(),
                direccion: txtDireccion.Text.Trim(),
                iva: selectedIva,
                eliminado: false
            );

            bool ok = _clientesDAO.Insertar(nuevoCliente, out string error);
            if (ok)
            {
                KryptonMessageBox.Show(
                    "Cliente registrado exitosamente.",
                    "Éxito",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Information
                );
                CargarGrilla();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show(
                    "No se pudo guardar el cliente: " + error,
                    "Error BD",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error
                );
            }
        }

        private void btnActualizar_Click(object? sender, EventArgs e)
        {
            if (_clienteSeleccionado == null) return;
            if (!UnificaryValidarFormulario()) return;

            string selectedIva = cmbIva.SelectedItem?.ToString() ?? "Consumidor Final";

            var clienteEditado = new Cliente(
                idCliente: _clienteSeleccionado.IdCliente,
                dni: txtDniCuit.Text.Trim(),
                nombreCompleto: txtNombreCompleto.Text.Trim(),
                correo: txtCorreo.Text.Trim(),
                telefono: txtTelefono.Text.Trim(),
                direccion: txtDireccion.Text.Trim(),
                iva: selectedIva,
                eliminado: _clienteSeleccionado.Eliminado
            );

            bool ok = _clientesDAO.Actualizar(clienteEditado, out string error);
            if (ok)
            {
                KryptonMessageBox.Show(
                    "Datos del cliente actualizados correctamente.",
                    "Éxito",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Information
                );
                CargarGrilla();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show(
                    "Error al actualizar el cliente: " + error,
                    "Error BD",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error
                );
            }
        }

        private void btnDesactivarCliente_Click(object? sender, EventArgs e)
        {
            if (_clienteSeleccionado == null) return;

            var confirm = KryptonMessageBox.Show(
                $"¿Está seguro de dar de baja al cliente {_clienteSeleccionado.NombreCompleto} (DNI: {_clienteSeleccionado.Dni})?",
                "Confirmar Baja Lógica",
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                bool ok = _clientesDAO.Desactivar(_clienteSeleccionado.IdCliente, out string error);
                if (ok)
                {
                    KryptonMessageBox.Show(
                        "Cliente desactivado exitosamente.",
                        "Éxito",
                        KryptonMessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Information
                    );
                    CargarGrilla();
                    LimpiarFormulario();
                }
                else
                {
                    KryptonMessageBox.Show(
                        "Error al desactivar cliente: " + error,
                        "Error",
                        KryptonMessageBoxButtons.OK,
                        KryptonMessageBoxIcon.Error
                    );
                }
            }
        }

        private void btnReactivarCliente_Click(object? sender, EventArgs e)
        {
            if (_clienteSeleccionado == null) return;

            bool ok = _clientesDAO.Reactivar(_clienteSeleccionado.IdCliente, out string error);
            if (ok)
            {
                KryptonMessageBox.Show(
                    "Cliente reactivado con éxito.",
                    "Éxito",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Information
                );
                CargarGrilla();
                LimpiarFormulario();
            }
            else
            {
                KryptonMessageBox.Show(
                    "Error al reactivar cliente: " + error,
                    "Error",
                    KryptonMessageBoxButtons.OK,
                    KryptonMessageBoxIcon.Error
                );
            }
        }

        // --- EVENTOS DE GRILLA Y FILTROS ---

        private void dgvClientes_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                var rowVal = dgvClientes.SelectedRows[0].Cells["IdCliente"].Value;
                if (rowVal == null || !int.TryParse(rowVal.ToString(), out int idCliente)) return;

                _clienteSeleccionado = _listaClientesMemoria.FirstOrDefault(c => c.IdCliente == idCliente);

                if (_clienteSeleccionado != null)
                {
                    _modoEdicion = true;

                    txtDniCuit.Text = _clienteSeleccionado.Dni;
                    txtNombreCompleto.Text = _clienteSeleccionado.NombreCompleto;
                    txtTelefono.Text = _clienteSeleccionado.Telefono;
                    txtCorreo.Text = _clienteSeleccionado.Correo;
                    txtDireccion.Text = _clienteSeleccionado.Direccion;

                    int idxIva = cmbIva.Items.IndexOf(_clienteSeleccionado.Iva);
                    cmbIva.SelectedIndex = idxIva >= 0 ? idxIva : 0;

                    btnLimpiar.Enabled = true;

                    EvaluarEstadoBotones(null, null);
                    ActualizarBotonesBajaReactivacion();
                }
            }
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void cmbFiltroEstado_SelectedIndexChanged(object? sender, EventArgs e)
        {
            AplicarFiltros();
            LimpiarFormulario();
        }

        // Evento opcional para evitar incongruencias si el diseñador lo conserva
        private void lblIva_Click(object? sender, EventArgs e)
        {
        }
    }
}