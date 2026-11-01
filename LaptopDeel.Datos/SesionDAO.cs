using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class SesionDAO
    {
        public int IniciarSesionLog(int idUsuario)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_RegistrarInicioSesion", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_usuario", idUsuario);

                    var paramOut = new MySqlParameter("@p_id_sesion", MySqlDbType.Int32)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(paramOut);

                    conexion.Open();
                    cmd.ExecuteNonQuery();

                    return Convert.ToInt32(paramOut.Value);
                }
            }
        }

        public void FinalizarSesionLog(int idSesion)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_RegistrarFinSesion", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_id_sesion", idSesion);

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<LogSesionDTO> ObtenerSesionesActivas()
        {
            var lista = new List<LogSesionDTO>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_ObtenerSesionesActivas", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object valTiempo = reader["tiempo_activo"];
                            string tiempoFormateado = valTiempo is TimeSpan ts
                                ? ts.ToString(@"hh\:mm\:ss")
                                : valTiempo?.ToString() ?? "00:00:00";

                            lista.Add(new LogSesionDTO
                            {
                                IdSesion = reader.GetInt32("id_sesion"),
                                Usuario = reader.GetString("usuario"),
                                UltimaActividad = reader.GetDateTime("ultima_actividad"),
                                TiempoActivo = tiempoFormateado
                            });
                        }
                    }
                }
            }

            return lista;
        }
    }
}