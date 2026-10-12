using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class ProcesadorDAO
    {
        public List<Procesador> ObtenerTodos()
        {
            var lista = new List<Procesador>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Procesadores_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var procesador = new Procesador
                            {
                                IdProcesador = reader.GetInt32("id_procesador"),
                                Marca = reader.IsDBNull(reader.GetOrdinal("marca")) ? string.Empty : reader.GetString("marca"),
                                Generacion = reader.IsDBNull(reader.GetOrdinal("generacion")) ? string.Empty : reader.GetString("generacion"),
                                Velocidad = reader.IsDBNull(reader.GetOrdinal("velocidad")) ? string.Empty : reader.GetString("velocidad"), // <-- Corregido a "velocidad"
                                Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? string.Empty : reader.GetString("nombre"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(procesador);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Procesador procesador, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Procesadores_Insertar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_marca", procesador.Marca);
                        cmd.Parameters.AddWithValue("@p_generacion", procesador.Generacion);
                        cmd.Parameters.AddWithValue("@p_velocidad", procesador.Velocidad); // <-- Coincide con la BD
                        cmd.Parameters.AddWithValue("@p_nombre", procesador.Nombre);

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

        public bool Actualizar(Procesador procesador, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Procesadores_Actualizar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_procesador", procesador.IdProcesador);
                        cmd.Parameters.AddWithValue("@p_marca", procesador.Marca);
                        cmd.Parameters.AddWithValue("@p_generacion", procesador.Generacion);
                        cmd.Parameters.AddWithValue("@p_velocidad", procesador.Velocidad); // <-- Coincide con la BD
                        cmd.Parameters.AddWithValue("@p_nombre", procesador.Nombre);

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

        public bool Desactivar(int idProcesador, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Procesadores_Desactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_procesador", idProcesador);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
            }
        }

        public bool Reactivar(int idProcesador, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Procesadores_Reactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_procesador", idProcesador);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception ex)
                {
                    mensajeError = ex.Message;
                    return false;
                }
            }
        }
    }
}