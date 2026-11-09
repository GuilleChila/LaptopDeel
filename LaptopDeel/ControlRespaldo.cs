using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlRespaldo : UserControl
    {
        private readonly RespaldoDAO _respaldoDao;
        private string _rutaSeleccionada = string.Empty;

        public ControlRespaldo()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _respaldoDao = new RespaldoDAO();

            ConfigurarGrillaHistorial();
            InicializarRutaPorDefecto();
            CargarHistorialRespaldos();
        }

        /// <summary>
        /// Establece una ruta por defecto en la carpeta de documentos del usuario y genera un nombre inicial estandarizado.
        /// </summary>
        private void InicializarRutaPorDefecto()
        {
            string carpetaBackups;

            try
            {
                string carpetaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Verificar si la carpeta de Documentos existe y es accesible localmente
                if (!string.IsNullOrEmpty(carpetaDocumentos) && Directory.Exists(carpetaDocumentos))
                {
                    carpetaBackups = Path.Combine(carpetaDocumentos, "LaptopDeel_Backups");
                }
                else
                {
                    // Fallback a la carpeta de perfil de usuario si OneDrive/Documentos no está disponible
                    string perfilUsuario = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                    carpetaBackups = Path.Combine(perfilUsuario, "LaptopDeel_Backups");
                }

                if (!Directory.Exists(carpetaBackups))
                {
                    Directory.CreateDirectory(carpetaBackups);
                }
            }
            catch (Exception)
            {
                // Fallback defensivo final en el directorio ejecutable de la aplicación
                carpetaBackups = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LaptopDeel_Backups");
                if (!Directory.Exists(carpetaBackups))
                {
                    Directory.CreateDirectory(carpetaBackups);
                }
            }

            _rutaSeleccionada = carpetaBackups;
            ActualizarCampoRutaVisual();
        }

        private void ActualizarCampoRutaVisual()
        {
            string nombreSugerido = $"Backup_LaptopDeel_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
            txtRutaLocal.Text = Path.Combine(_rutaSeleccionada, nombreSugerido);
        }

        /// <summary>
        /// Configura el diseño estandarizado (Slate Blue) para el DataGridView de historial.
        /// </summary>
        private void ConfigurarGrillaHistorial()
        {
            dgvHistorialRespaldos.Columns.Clear();
            dgvHistorialRespaldos.Columns.Add("colFecha", "Fecha / Hora");
            dgvHistorialRespaldos.Columns.Add("colArchivo", "Nombre del Archivo SQL");
            dgvHistorialRespaldos.Columns.Add("colRuta", "Ruta / Destino");
            dgvHistorialRespaldos.Columns.Add("colTamano", "Tamaño");
            dgvHistorialRespaldos.Columns.Add("colTipo", "Tipo");
            dgvHistorialRespaldos.Columns.Add("colEstado", "Estado");

            dgvHistorialRespaldos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Carga los registros de copias de seguridad anteriores realizadas en la sesión o BD.
        /// </summary>
        private void CargarHistorialRespaldos()
        {
            try
            {
                dgvHistorialRespaldos.Rows.Clear();
                List<RespaldoDTO> historial = _respaldoDao.ObtenerHistorialRespaldos();

                foreach (var item in historial)
                {
                    int index = dgvHistorialRespaldos.Rows.Add(
                        item.FechaFormateada,
                        item.NombreArchivo,
                        item.RutaDestino,
                        item.TamanoFormateado,
                        item.TipoDestino,
                        item.EstadoExitoso ? "🟢 Exitoso" : "🔴 Fallido"
                    );

                    if (!item.EstadoExitoso)
                    {
                        dgvHistorialRespaldos.Rows[index].Cells["colEstado"].Style.ForeColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                // Silencioso o log preventivo si es primera ejecución sin tabla de historial
            }
        }

        #region Eventos de Botones - Respaldo Local / USB

        /// <summary>
        /// Abre un explorador de carpetas que permite elegir discos locales o unidades de memoria flash USB.
        /// </summary>
        private void btnExaminar_Click(object? sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Seleccione la carpeta o unidad flash USB donde desea guardar la copia de seguridad:";
                dialog.ShowNewFolderButton = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _rutaSeleccionada = dialog.SelectedPath;
                    ActualizarCampoRutaVisual();
                }
            }
        }

        /// <summary>
        /// Genera el respaldo SQL de manera asíncrona para no congelar la interfaz de usuario.
        /// </summary>
        private async void btnGenerarLocal_Click(object? sender, EventArgs e)
        {
            string rutaCompletaArchivo = txtRutaLocal.Text.Trim();

            if (string.IsNullOrEmpty(rutaCompletaArchivo))
            {
                KryptonMessageBox.Show("Por favor, seleccione una ruta de destino válida.",
                    "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            string? directorio = Path.GetDirectoryName(rutaCompletaArchivo);
            if (!Directory.Exists(directorio))
            {
                KryptonMessageBox.Show("La carpeta o unidad de destino seleccionada no existe o fue desconectada.",
                    "Error de almacenamiento", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                return;
            }

            EstablecerEstadoProcesando(true);

            try
            {
                // Ejecución asíncrona del backup directo C# en la Capa de Datos
                bool exito = await Task.Run(() => _respaldoDao.GenerarBackupDirectoSql(rutaCompletaArchivo));

                if (exito)
                {
                    KryptonMessageBox.Show($"¡Respaldo generado correctamente!\n\nUbicación: {rutaCompletaArchivo}",
                        "Copia de Seguridad Exitosa", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                    ActualizarCampoRutaVisual(); // Genera nuevo nombre timestamp para el siguiente clic
                    CargarHistorialRespaldos();
                }
                else
                {
                    KryptonMessageBox.Show("Ocurrió un error al intentar exportar la base de datos.",
                        "Error de Respaldo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error inesperado durante la copia local: {ex.Message}",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                EstablecerEstadoProcesando(false);
            }
        }

        #endregion

        #region Eventos de Botones - Google Drive (Nube)

        private async void btnConectarGoogle_Click(object? sender, EventArgs e)
        {
            EstablecerEstadoProcesando(true);
            try
            {
                // Proceso de vinculación OAuth 2.0
                string? correoVinculado = await Task.Run(() => _respaldoDao.AutenticarCuentaGoogleDrive());

                if (!string.IsNullOrEmpty(correoVinculado))
                {
                    lblEstadoGoogle.Text = $"🟢 Vinculado como {correoVinculado}";
                    lblEstadoGoogle.StateCommon.ShortText.Color1 = Color.FromArgb(16, 185, 129);
                    KryptonMessageBox.Show("Cuenta de Google vinculada correctamente para copias en la nube.",
                        "Éxito", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                }
                else
                {
                    KryptonMessageBox.Show("No se completó la autenticación con la cuenta de Google.",
                        "Atención", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error al conectar con Google Drive: {ex.Message}",
                    "Error de Conexión", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                EstablecerEstadoProcesando(false);
            }
        }

        private async void btnSubirGoogleDrive_Click(object? sender, EventArgs e)
        {
            EstablecerEstadoProcesando(true);
            try
            {
                // Genera un archivo temporal para volcar la BD y enviarlo a la nube
                string nombreArchivo = $"Backup_LaptopDeel_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
                string tempPath = Path.Combine(Path.GetTempPath(), nombreArchivo);

                bool generado = await Task.Run(() => _respaldoDao.GenerarBackupDirectoSql(tempPath));

                if (generado)
                {
                    bool subido = await Task.Run(() => _respaldoDao.SubirArchivoAGoogleDrive(tempPath, nombreArchivo));

                    if (File.Exists(tempPath)) File.Delete(tempPath); // Limpieza de archivo temporal

                    if (subido)
                    {
                        KryptonMessageBox.Show("Copia de seguridad generada y subida exitosamente a Google Drive.",
                            "Respaldo en la Nube Completado", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                        CargarHistorialRespaldos();
                    }
                    else
                    {
                        KryptonMessageBox.Show("No se pudo subir el archivo a Google Drive. Asegúrese de haber vinculado su cuenta.",
                            "Error de Subida", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Error durante la operación en la nube: {ex.Message}",
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
            finally
            {
                EstablecerEstadoProcesando(false);
            }
        }

        #endregion

        /// <summary>
        /// Habilita o deshabilita los botones de la UI y muestra la barra de progreso mientras corre una operación asíncrona.
        /// </summary>
        private void EstablecerEstadoProcesando(bool procesando)
        {
            progressBarRespaldo.Visible = procesando;
            btnGenerarLocal.Enabled = !procesando;
            btnExaminar.Enabled = !procesando;
            btnConectarGoogle.Enabled = !procesando;
            btnSubirGoogleDrive.Enabled = !procesando;
            this.Cursor = procesando ? Cursors.WaitCursor : Cursors.Default;
        }
    }
}