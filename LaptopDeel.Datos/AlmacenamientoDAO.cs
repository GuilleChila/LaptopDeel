using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class AlmacenamientoDAO
    {
        public List<Almacenamiento> ObtenerTodos()
        {
            var lista = new List<Almacenamiento>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_ObtenerTodosAlmacenamientos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var almacenamiento = new Almacenamiento
                            {
                                IdAlmacenamiento = reader.GetInt32("id_almacenamiento"),
                                Tipo = reader.IsDBNull(reader.GetOrdinal("tipo")) ? string.Empty : reader.GetString("tipo"),
                                Capacidad = reader.IsDBNull(reader.GetOrdinal("capacidad")) ? string.Empty : reader.GetString("capacidad"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(almacenamiento);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Almacenamiento almacenamiento, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_InsertarAlmacenamiento", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_tipo", almacenamiento.Tipo);
                        cmd.Parameters.AddWithValue("@p_capacidad", almacenamiento.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; // ¡Atrapamos el error real de la BD!
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }

        public bool Actualizar(Almacenamiento almacenamiento, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_ActualizarAlmacenamiento", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_almacenamiento", almacenamiento.IdAlmacenamiento);
                        cmd.Parameters.AddWithValue("@p_tipo", almacenamiento.Tipo);
                        cmd.Parameters.AddWithValue("@p_capacidad", almacenamiento.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; // ¡Ahora el error viaja a la interfaz!
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }

        public bool Desactivar(int idAlmacenamiento, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_DesactivarAlmacenamiento", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_almacenamiento", idAlmacenamiento);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; // Pasamos el error de MariaDB
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message; // Pasamos cualquier otro error
                    return false;
                }
            }
        }

        public bool Reactivar(int idAlmacenamiento, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_ReactivarAlmacenamiento", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_almacenamiento", idAlmacenamiento);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; // Pasamos el error de MariaDB
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message; // Pasamos cualquier otro error
                    return false;
                }
            }
        }
    }
}