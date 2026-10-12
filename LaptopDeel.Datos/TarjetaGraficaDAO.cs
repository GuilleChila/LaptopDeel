using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class TarjetaGraficaDAO
    {
        public List<TarjetaGrafica> ObtenerTodos()
        {
            var lista = new List<TarjetaGrafica>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_TarjetasGraficas_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var tarjeta = new TarjetaGrafica
                            {
                                IdTarjetaGrafica = reader.GetInt32("id_tarjetaGrafica"),
                                Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? string.Empty : reader.GetString("nombre"),
                                Marca = reader.IsDBNull(reader.GetOrdinal("marca")) ? string.Empty : reader.GetString("marca"),                        
                                Capacidad = reader.IsDBNull(reader.GetOrdinal("capacidad")) ? string.Empty : reader["capacidad"].ToString(),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(tarjeta);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(TarjetaGrafica tarjeta, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_TarjetasGraficas_Insertar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_nombre", tarjeta.Nombre);
                        cmd.Parameters.AddWithValue("@p_marca", tarjeta.Marca);
                        cmd.Parameters.AddWithValue("@p_capacidad", tarjeta.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message; return false;
                }
            }
        }

        public bool Actualizar(TarjetaGrafica tarjeta, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_TarjetasGraficas_Actualizar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_tarjetaGrafica", tarjeta.IdTarjetaGrafica);
                        cmd.Parameters.AddWithValue("@p_nombre", tarjeta.Nombre);
                        cmd.Parameters.AddWithValue("@p_marca", tarjeta.Marca);
                        cmd.Parameters.AddWithValue("@p_capacidad", tarjeta.Capacidad);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    mensajeError = ex.Message; return false;
                }
                catch (Exception ex)
                {
                    mensajeError = "Error: " + ex.Message; return false;
                }
            }
        }

        public bool Desactivar(int idTarjetaGrafica, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_TarjetasGraficas_Desactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_tarjetaGrafica", idTarjetaGrafica);
                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex) { mensajeError = ex.Message; return false; }
                catch (Exception ex) { mensajeError = "Error: " + ex.Message; return false; }
            }
        }

        public bool Reactivar(int idTarjetaGrafica, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_TarjetasGraficas_Reactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_tarjetaGrafica", idTarjetaGrafica);
                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex) { mensajeError = ex.Message; return false; }
                catch (Exception ex) { mensajeError = "Error: " + ex.Message; return false; }
            }
        }
    }
}