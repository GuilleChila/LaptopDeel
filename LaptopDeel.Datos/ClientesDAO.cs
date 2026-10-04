using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class ClientesDAO
    {
        public List<Cliente> ObtenerTodos()
        {
            var lista = new List<Cliente>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_ObtenerTodosClientes", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var cliente = new Cliente
                            {
                                IdCliente = reader.GetInt32("id_cliente"),
                                Dni = reader.IsDBNull(reader.GetOrdinal("dni")) ? string.Empty : reader.GetString("dni"),
                                NombreCompleto = reader.IsDBNull(reader.GetOrdinal("nombre_completo")) ? string.Empty : reader.GetString("nombre_completo"),
                                Correo = reader.IsDBNull(reader.GetOrdinal("correo")) ? string.Empty : reader.GetString("correo"),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("telefono")) ? string.Empty : reader.GetString("telefono"),
                                Direccion = reader.IsDBNull(reader.GetOrdinal("direccion")) ? string.Empty : reader.GetString("direccion"),
                                Iva = reader.IsDBNull(reader.GetOrdinal("iva")) ? "Consumidor Final" : reader.GetString("iva"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(cliente);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Cliente cliente, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_InsertarCliente", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_dni", cliente.Dni);
                        cmd.Parameters.AddWithValue("@p_nombre_completo", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@p_correo", cliente.Correo);
                        cmd.Parameters.AddWithValue("@p_telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@p_direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@p_iva", cliente.Iva);

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

        public bool Actualizar(Cliente cliente, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_ActualizarCliente", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_cliente", cliente.IdCliente);
                        cmd.Parameters.AddWithValue("@p_dni", cliente.Dni);
                        cmd.Parameters.AddWithValue("@p_nombre_completo", cliente.NombreCompleto);
                        cmd.Parameters.AddWithValue("@p_correo", cliente.Correo);
                        cmd.Parameters.AddWithValue("@p_telefono", cliente.Telefono);
                        cmd.Parameters.AddWithValue("@p_direccion", cliente.Direccion);
                        cmd.Parameters.AddWithValue("@p_iva", cliente.Iva);

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

        public bool Desactivar(int idCliente, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_DesactivarCliente", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_cliente", idCliente);

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

        public bool Reactivar(int idCliente, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_ReactivarCliente", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_cliente", idCliente);

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