using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;

namespace LaptopDeel
{
    public partial class ControlRespaldo : UserControl
    {
        private readonly RespaldoDAO _respaldoDAO;
        private string _rutaSeleccionada = string.Empty;

        public ControlRespaldo()
        {
            InitializeComponent();
            _respaldoDAO = new RespaldoDAO();

            InicializarRutaPorDefecto();
            CargarEstadoInicialGoogle();
            CargarGrillaHistorial();
        }

        private void InicializarRutaPorDefecto()
        {
            string carpetaBackups;
            try
            {
                string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (!string.IsNullOrEmpty(carpetaDocumentos) && Directory.Exists(carpetaDocumentos))
                {
                    carpetaBackups = Path.Combine(carpetaDocumentos, "LaptopDeel_Backups");
                }
                else
                {
                    string perfilUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    carpetaBackups = Path.Combine(perfilUsuario, "LaptopDeel_Backups");
                }

                if (!Directory.Exists(carpetaBackups))
                {
                    Directory.CreateDirectory(carpetaBackups);
                }
            }
            catch
            {
                carpetaBackups = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LaptopDeel_Backups");
                if (!Directory.Exists(carpetaBackups))
                {
                    Directory.CreateDirectory(carpetaBackups);
                }
            }

            _rutaSeleccionada = Path.Combine(carpetaBackups, $"Backup_LaptopDeel_{DateTime.Now:yyyyMMdd_HHmmss}.sql");
            txtRutaLocal.Text = _rutaSeleccionada;
        }

        private async void CargarEstadoInicialGoogle()
        {
            bool conectado = _respaldoDAO.ExisteCuentaGoogleVinculada();
            if (conectado)
            {
                string email = await _respaldoDAO.ObtenerEmailCuentaVinculadaAsync();
                ActualizarEstadoGoogleUI(true, email);
            }
            else
            {
                ActualizarEstadoGoogleUI(false, string.Empty);
            }
        }

        private void ActualizarEstadoGoogleUI(bool estaVinculado, string email)
        {
            if (estaVinculado)
            {
                lblEstadoGoogle.Text = string.IsNullOrEmpty(email)
                    ? "🟢 Cuenta Google Vinculada "
                    : $"🟢 Vinculado como {email} ";
                lblEstadoGoogle.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);

                btnConectarGoogle.Enabled = false;
                btnDesconectarGoogle.Enabled = true;
                btnSubirGoogleDrive.Enabled = true;
            }
            else
            {
                lblEstadoGoogle.Text = "🔴 Cuenta No Vinculada ";
                lblEstadoGoogle.StateCommon.ShortText.Color1 = Color.FromArgb(239, 68, 68);

                btnConectarGoogle.Enabled = true;
                btnDesconectarGoogle.Enabled = false;
                btnSubirGoogleDrive.Enabled = false;
            }
        }

        private void CargarGrillaHistorial()
        {
            dgvHistorialRespaldos.DataSource = null;
            dgvHistorialRespaldos.DataSource = _respaldoDAO.ObtenerHistorialRespaldos();

            if (dgvHistorialRespaldos.Columns.Count > 0)
            {
                if (dgvHistorialRespaldos.Columns["FechaHora"] != null)
                    dgvHistorialRespaldos.Columns["FechaHora"].HeaderText = "Fecha / Hora";

                if (dgvHistorialRespaldos.Columns["NombreArchivo"] != null)
                    dgvHistorialRespaldos.Columns["NombreArchivo"].HeaderText = "Nombre del Archivo SQL";

                if (dgvHistorialRespaldos.Columns["RutaDestino"] != null)
                    dgvHistorialRespaldos.Columns["RutaDestino"].HeaderText = "Ruta / Destino";

                if (dgvHistorialRespaldos.Columns["TamanoFormateado"] != null)
                    dgvHistorialRespaldos.Columns["TamanoFormateado"].HeaderText = "Tamaño";

                if (dgvHistorialRespaldos.Columns["TipoDestino"] != null)
                    dgvHistorialRespaldos.Columns["TipoDestino"].HeaderText = "Tipo";

                if (dgvHistorialRespaldos.Columns["EstadoExitoso"] != null)
                    dgvHistorialRespaldos.Columns["EstadoExitoso"].HeaderText = "Estado";

                if (dgvHistorialRespaldos.Columns["TamanoBytes"] != null)
                    dgvHistorialRespaldos.Columns["TamanoBytes"].Visible = false;

                if (dgvHistorialRespaldos.Columns["FechaFormateada"] != null)
                    dgvHistorialRespaldos.Columns["FechaFormateada"].Visible = false;
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivo SQL (*.sql)|*.sql";
                saveFileDialog.FileName = $"Backup_LaptopDeel_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
                saveFileDialog.Title = "Seleccionar carpeta destino para el respaldo";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _rutaSeleccionada = saveFileDialog.FileName;
                    txtRutaLocal.Text = _rutaSeleccionada;
                }
            }
        }

        private async void btnGenerarLocal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_rutaSeleccionada))
            {
                KryptonMessageBox.Show("Por favor seleccione una ruta de destino válida.", "Atención",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            ActivarModoCarga(true);
            try
            {
                bool resultado = await Task.Run(() => _respaldoDAO.GenerarBackupDirectoSql(_rutaSeleccionada));
                if (resultado)
                {
                    KryptonMessageBox.Show($"¡Respaldo local generado con éxito en:\n{_rutaSeleccionada}", "Éxito",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    InicializarRutaPorDefecto();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Ocurrió un error al generar el respaldo: {ex.Message}", "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                ActivarModoCarga(false);
                CargarGrillaHistorial();
            }
        }

        private async void btnConectarGoogle_Click(object sender, EventArgs e)
        {
            ActivarModoCarga(true);
            try
            {
                string email = await _respaldoDAO.AutenticarCuentaGoogleDrive();
                ActualizarEstadoGoogleUI(true, email);
                KryptonMessageBox.Show($"Cuenta de Google vinculada correctamente:\n{email}", "Google Drive Vinculado",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ActualizarEstadoGoogleUI(false, string.Empty);
                KryptonMessageBox.Show($"No se pudo vincular la cuenta de Google: {ex.Message}", "Error OAuth",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                ActivarModoCarga(false);
            }
        }

        private void btnDesconectarGoogle_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = KryptonMessageBox.Show(
                "¿Está seguro de que desea desvincular la cuenta de Google Drive para los respaldos?",
                "Desconectar Cuenta",
                KryptonMessageBoxButtons.YesNo,
                KryptonMessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                _respaldoDAO.DesconectarCuentaGoogleDrive();
                ActualizarEstadoGoogleUI(false, string.Empty);
                KryptonMessageBox.Show("La cuenta de Google ha sido desvinculada correctamente.", "Cuenta Desconectada",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
            }
        }

        private async void btnSubirGoogleDrive_Click(object sender, EventArgs e)
        {
            ActivarModoCarga(true);
            try
            {
                string nombreArchivoNube = $"Backup_LaptopDeel_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
                string rutaTemporal = Path.Combine(Path.GetTempPath(), nombreArchivoNube);

                bool generado = await Task.Run(() => _respaldoDAO.GenerarBackupDirectoSql(rutaTemporal));

                if (generado)
                {
                    bool subido = await _respaldoDAO.SubirArchivoAGoogleDrive(rutaTemporal, nombreArchivoNube);
                    if (subido)
                    {
                        KryptonMessageBox.Show($"¡El respaldo fue subido exitosamente a Google Drive!\nNombre: {nombreArchivoNube}",
                            "Respaldo en la Nube Completo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Ocurrió un error durante el respaldo en la nube: {ex.Message}", "Error de Respaldo",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                ActivarModoCarga(false);
                CargarGrillaHistorial();
            }
        }

        private async void ActivarModoCarga(bool cargando)
        {
            progressBarRespaldo.Visible = cargando;
            btnGenerarLocal.Enabled = !cargando;
            btnExaminar.Enabled = !cargando;

            if (cargando)
            {
                btnConectarGoogle.Enabled = false;
                btnDesconectarGoogle.Enabled = false;
                btnSubirGoogleDrive.Enabled = false;
            }
            else
            {
                bool conectado = _respaldoDAO.ExisteCuentaGoogleVinculada();
                if (conectado)
                {
                    string email = await _respaldoDAO.ObtenerEmailCuentaVinculadaAsync();
                    ActualizarEstadoGoogleUI(true, email);
                }
                else
                {
                    ActualizarEstadoGoogleUI(false, string.Empty);
                }
            }
        }
    }
}