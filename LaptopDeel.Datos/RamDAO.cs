using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class RamDAO
    {
        public List<Ram> ObtenerTodos()
        {
            var lista = new List<Ram>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Rams_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var ram = new Ram
                            {
                                IdRam = reader.GetInt32("id_ram"),
                                Generacion = reader.IsDBNull(reader.GetOrdinal("generacion")) ? string.Empty : reader.GetString("generacion"),
                                Capacidad = reader.IsDBNull(reader.GetOrdinal("capacidad")) ? string.Empty : reader.GetString("capacidad"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(ram);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Ram ram, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Rams_Insertar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_generacion", ram.Generacion);
                        cmd.Parameters.AddWithValue("@p_capacidad", ram.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }

        public bool Actualizar(Ram ram, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Rams_Actualizar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_ram", ram.IdRam);
                        cmd.Parameters.AddWithValue("@p_generacion", ram.Generacion);
                        cmd.Parameters.AddWithValue("@p_capacidad", ram.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }

        public bool Desactivar(int idRam, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Rams_Desactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_ram", idRam);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }

        public bool Reactivar(int idRam, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Rams_Reactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_ram", idRam);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message;
                    return false;
                }
            }
        }
    }
}