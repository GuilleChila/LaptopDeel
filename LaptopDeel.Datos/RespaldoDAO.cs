using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class RespaldoDAO
    {
        private static readonly string[] Scopes = {
            DriveService.Scope.DriveFile,
            "https://www.googleapis.com/auth/userinfo.email"
        };
        private static readonly string ApplicationName = "LaptopDeel Database Backup";

        private static readonly string RutaTokenFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "LaptopDeel_DriveTokens");

        private static readonly string RutaHistorialJson = Path.Combine(RutaTokenFolder, "historial_respaldos.json");
        private static readonly string RutaEmailCache = Path.Combine(RutaTokenFolder, "user_email.txt");

        private List<RespaldoDTO> _historialMemoria = new List<RespaldoDTO>();

        public RespaldoDAO()
        {
            CargarHistorialPersistente();
        }

        private void CargarHistorialPersistente()
        {
            try
            {
                if (File.Exists(RutaHistorialJson))
                {
                    string json = File.ReadAllText(RutaHistorialJson);
                    _historialMemoria = JsonSerializer.Deserialize<List<RespaldoDTO>>(json) ?? new List<RespaldoDTO>();
                }
                else
                {
                    _historialMemoria = new List<RespaldoDTO>();
                }
            }
            catch
            {
                _historialMemoria = new List<RespaldoDTO>();
            }
        }

        private void GuardarHistorialPersistente()
        {
            try
            {
                if (!Directory.Exists(RutaTokenFolder))
                {
                    Directory.CreateDirectory(RutaTokenFolder);
                }

                string json = JsonSerializer.Serialize(_historialMemoria, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(RutaHistorialJson, json);
            }
            catch { }
        }

        public List<RespaldoDTO> ObtenerHistorialRespaldos()
        {
            return new List<RespaldoDTO>(_historialMemoria);
        }

        public bool GenerarBackupDirectoSql(string rutaCompletaDestino)
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine("-- ========================================================");
                sb.AppendLine("-- LAPTOPDEEL - RESPALDO AUTOMÁTICO DE BASE DE DATOS");
                sb.AppendLine($"-- Fecha de Generación: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                sb.AppendLine($"-- Motor Objetivo: MariaDB / MySQL");
                sb.AppendLine("-- ========================================================");
                sb.AppendLine("CREATE DATABASE IF NOT EXISTS `laptopdeel_db` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci;");
                sb.AppendLine("USE `laptopdeel_db`;");
                sb.AppendLine();
                sb.AppendLine("SET FOREIGN_KEY_CHECKS = 0;");
                sb.AppendLine("SET SQL_MODE = 'NO_AUTO_VALUE_ON_ZERO';");
                sb.AppendLine("SET NAMES utf8mb4;");
                sb.AppendLine();

                using (var conexion = ConexionBD.ObtenerConexion())
                {
                    conexion.Open();

                    List<string> tablas = new List<string>();
                    using (var cmdTablas = new MySqlCommand("SHOW TABLES;", conexion))
                    {
                        using (var reader = cmdTablas.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                tablas.Add(reader.GetString(0));
                            }
                        }
                    }

                    foreach (string tabla in tablas)
                    {
                        sb.AppendLine($"-- --------------------------------------------------------");
                        sb.AppendLine($"-- Estructura de la tabla `{tabla}`");
                        sb.AppendLine($"-- --------------------------------------------------------");
                        sb.AppendLine($"DROP TABLE IF EXISTS `{tabla}`;");

                        using (var cmdCreate = new MySqlCommand($"SHOW CREATE TABLE `{tabla}`;", conexion))
                        {
                            using (var reader = cmdCreate.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string createSql = reader.GetString(1);
                                    sb.AppendLine($"{createSql};");
                                    sb.AppendLine();
                                }
                            }
                        }

                        sb.AppendLine($"-- Volcado de datos para la tabla `{tabla}`");
                        using (var cmdData = new MySqlCommand($"SELECT * FROM `{tabla}`;", conexion))
                        {
                            using (var reader = cmdData.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var valores = new List<string>();
                                    for (int i = 0; i < reader.FieldCount; i++)
                                    {
                                        if (reader.IsDBNull(i))
                                        {
                                            valores.Add("NULL");
                                        }
                                        else
                                        {
                                            Type tipo = reader.GetFieldType(i);

                                            if (tipo == typeof(string))
                                            {
                                                string val = reader.GetString(i)
                                                    .Replace(@"\", @"\\")
                                                    .Replace("'", @"\'")
                                                    .Replace("\r", @"\r")
                                                    .Replace("\n", @"\n");
                                                valores.Add($"'{val}'");
                                            }
                                            else if (tipo == typeof(DateTime))
                                            {
                                                DateTime dt = reader.GetDateTime(i);
                                                valores.Add($"'{dt:yyyy-MM-dd HH:mm:ss}'");
                                            }
                                            else if (tipo == typeof(bool))
                                            {
                                                valores.Add(reader.GetBoolean(i) ? "1" : "0");
                                            }
                                            else if (tipo == typeof(decimal) || tipo == typeof(float) || tipo == typeof(double))
                                            {
                                                valores.Add(Convert.ToString(reader[i], CultureInfo.InvariantCulture)!);
                                            }
                                            else
                                            {
                                                valores.Add(reader[i].ToString()!);
                                            }
                                        }
                                    }

                                    sb.AppendLine($"INSERT INTO `{tabla}` VALUES ({string.Join(", ", valores)});");
                                }
                            }
                        }
                        sb.AppendLine();
                    }

                    sb.AppendLine("SET FOREIGN_KEY_CHECKS = 1;");
                }

                File.WriteAllText(rutaCompletaDestino, sb.ToString(), new UTF8Encoding(false));

                FileInfo fi = new FileInfo(rutaCompletaDestino);
                bool esUsb = rutaCompletaDestino.StartsWith("E:", StringComparison.OrdinalIgnoreCase) ||
                             rutaCompletaDestino.StartsWith("F:", StringComparison.OrdinalIgnoreCase) ||
                             rutaCompletaDestino.StartsWith("G:", StringComparison.OrdinalIgnoreCase) ||
                             rutaCompletaDestino.StartsWith("H:", StringComparison.OrdinalIgnoreCase);

                _historialMemoria.Insert(0, new RespaldoDTO
                {
                    FechaHora = DateTime.Now,
                    NombreArchivo = fi.Name,
                    RutaDestino = fi.DirectoryName ?? string.Empty,
                    TamanoBytes = fi.Length,
                    TipoDestino = esUsb ? "USB" : "Local",
                    EstadoExitoso = true
                });

                GuardarHistorialPersistente();
                return true;
            }
            catch (Exception ex)
            {
                _historialMemoria.Insert(0, new RespaldoDTO
                {
                    FechaHora = DateTime.Now,
                    NombreArchivo = Path.GetFileName(rutaCompletaDestino),
                    RutaDestino = Path.GetDirectoryName(rutaCompletaDestino) ?? string.Empty,
                    TamanoBytes = 0,
                    TipoDestino = "Local",
                    EstadoExitoso = false
                });

                GuardarHistorialPersistente();
                throw new Exception($"Error durante la generación directa del script SQL: {ex.Message}", ex);
            }
        }

        #region Integración con Google Drive API v3

        public bool ExisteCuentaGoogleVinculada()
        {
            return Directory.Exists(RutaTokenFolder) && Directory.GetFiles(RutaTokenFolder).Length > 0;
        }

        public void DesconectarCuentaGoogleDrive()
        {
            if (Directory.Exists(RutaTokenFolder))
            {
                Directory.Delete(RutaTokenFolder, true);
            }
        }

        public async Task<string> ObtenerEmailCuentaVinculadaAsync()
        {
            try
            {
                if (!ExisteCuentaGoogleVinculada()) return string.Empty;

                if (File.Exists(RutaEmailCache))
                {
                    string emailGuardado = File.ReadAllText(RutaEmailCache).Trim();
                    if (!string.IsNullOrEmpty(emailGuardado)) return emailGuardado;
                }

                DriveService service = await ObtenerServicioDriveAsync();
                var request = service.About.Get();
                request.Fields = "user(emailAddress)";
                var about = await request.ExecuteAsync();

                string emailReal = about.User?.EmailAddress ?? string.Empty;
                if (!string.IsNullOrEmpty(emailReal))
                {
                    if (!Directory.Exists(RutaTokenFolder)) Directory.CreateDirectory(RutaTokenFolder);
                    File.WriteAllText(RutaEmailCache, emailReal);
                }
                return emailReal;
            }
            catch
            {
                return string.Empty;
            }
        }

        private async Task<DriveService> ObtenerServicioDriveAsync()
        {
            string credPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "client_secret.json");

            if (!File.Exists(credPath))
            {
                throw new FileNotFoundException("No se encontró el archivo 'client_secret.json' en el directorio de la aplicación.");
            }

            UserCredential credential;
            using (var stream = new FileStream(credPath, FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "gerente_user",
                    CancellationToken.None,
                    new FileDataStore(RutaTokenFolder, true));
            }

            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public async Task<string> AutenticarCuentaGoogleDrive()
        {
            try
            {
                DriveService service = await ObtenerServicioDriveAsync();

                var request = service.About.Get();
                request.Fields = "user(emailAddress)";
                var about = await request.ExecuteAsync();

                string emailReal = about.User?.EmailAddress ?? string.Empty;
                if (!string.IsNullOrEmpty(emailReal))
                {
                    if (!Directory.Exists(RutaTokenFolder)) Directory.CreateDirectory(RutaTokenFolder);
                    File.WriteAllText(RutaEmailCache, emailReal);
                }

                return emailReal;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error de autenticación con Google Drive: {ex.Message}", ex);
            }
        }

        public async Task<bool> SubirArchivoAGoogleDrive(string rutaArchivoLocal, string nombreEnNube)
        {
            try
            {
                if (!File.Exists(rutaArchivoLocal)) return false;

                DriveService service = await ObtenerServicioDriveAsync();

                var fileMetadata = new Google.Apis.Drive.v3.Data.File()
                {
                    Name = nombreEnNube,
                    MimeType = "text/plain"
                };

                FilesResource.CreateMediaUpload request;
                using (var stream = new FileStream(rutaArchivoLocal, FileMode.Open, FileAccess.Read))
                {
                    request = service.Files.Create(fileMetadata, stream, "text/plain");
                    request.Fields = "id";
                    await request.UploadAsync();
                }

                FileInfo fi = new FileInfo(rutaArchivoLocal);

                _historialMemoria.Insert(0, new RespaldoDTO
                {
                    FechaHora = DateTime.Now,
                    NombreArchivo = nombreEnNube,
                    RutaDestino = "Google Drive:/My Drive/",
                    TamanoBytes = fi.Length,
                    TipoDestino = "Nube (Google Drive)",
                    EstadoExitoso = true
                });

                GuardarHistorialPersistente();
                return true;
            }
            catch (Exception ex)
            {
                _historialMemoria.Insert(0, new RespaldoDTO
                {
                    FechaHora = DateTime.Now,
                    NombreArchivo = nombreEnNube,
                    RutaDestino = "Google Drive",
                    TamanoBytes = 0,
                    TipoDestino = "Nube (Google Drive)",
                    EstadoExitoso = false
                });

                GuardarHistorialPersistente();
                throw new Exception($"Error al subir el archivo a Google Drive: {ex.Message}", ex);
            }
        }

        #endregion
    }
}