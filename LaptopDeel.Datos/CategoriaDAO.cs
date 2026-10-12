using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class CategoriaDAO
    {
        public List<Categoria> ObtenerTodos()
        {
            var lista = new List<Categoria>();
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Categorias_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Categoria
                            {
                                IdCategoria = reader.GetInt32("id_categoria"),
                                Nombre = reader.IsDBNull(reader.GetOrdinal("nombre")) ? string.Empty : reader.GetString("nombre"),
                                Descripcion = reader.IsDBNull(reader.GetOrdinal("descripcion")) ? string.Empty : reader.GetString("descripcion"),
                                Eliminado = reader.GetBoolean("eliminado")
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Categoria categoria, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Categorias_Insertar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@p_descripcion", categoria.Descripcion);
                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex) { mensajeError = ex.Message; return false; }
                catch (Exception ex) { mensajeError = "Error: " + ex.Message; return false; }
            }
        }

        public bool Actualizar(Categoria categoria, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Categorias_Actualizar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_categoria", categoria.IdCategoria);
                        cmd.Parameters.AddWithValue("@p_nombre", categoria.Nombre);
                        cmd.Parameters.AddWithValue("@p_descripcion", categoria.Descripcion);
                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex) { mensajeError = ex.Message; return false; }
                catch (Exception ex) { mensajeError = "Error: " + ex.Message; return false; }
            }
        }

        public bool Desactivar(int idCategoria, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Categorias_Desactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_categoria", idCategoria);
                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (MySqlException ex) { mensajeError = ex.Message; return false; }
                catch (Exception ex) { mensajeError = "Error: " + ex.Message; return false; }
            }
        }

        public bool Reactivar(int idCategoria, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Categorias_Reactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_categoria", idCategoria);
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