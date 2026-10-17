using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class NotebookDAO
    {
        public List<Notebook> ObtenerTodos()
        {
            var lista = new List<Notebook>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Notebooks_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var notebook = new Notebook

                            {
                                IdNotebook = reader.GetInt32("id_notebook"),
                                Marca = reader.IsDBNull(reader.GetOrdinal("marca")) ? string.Empty : reader.GetString("marca"),
                                Modelo = reader.IsDBNull(reader.GetOrdinal("modelo")) ? string.Empty : reader.GetString("modelo"),

                                // Usamos Convert.ToDecimal para que soporte INT, DECIMAL o DOUBLE sin crashear
                                Precio = reader.IsDBNull(reader.GetOrdinal("precio")) ? 0 : Convert.ToDecimal(reader["precio"]),
                                Stock = reader.IsDBNull(reader.GetOrdinal("stock")) ? 0 : reader.GetInt32("stock"),
                                Eliminado = reader.GetBoolean("eliminado"),

                                // Guardamos los IDs reales
                                IdProcesador = reader.GetInt32("id_procesador"),
                                IdRam = reader.GetInt32("id_ram"),
                                IdAlmacenamiento = reader.GetInt32("id_almacenamiento"),
                                IdPantalla = reader.GetInt32("id_pantalla"),
                                IdTarjetaGrafica = reader.GetInt32("id_tarjetaGrafica"),

                                // Guardamos las descripciones del INNER JOIN
                                Procesador = reader.IsDBNull(reader.GetOrdinal("desc_procesador")) ? string.Empty : reader.GetString("desc_procesador"),
                                Ram = reader.IsDBNull(reader.GetOrdinal("desc_ram")) ? string.Empty : reader.GetString("desc_ram"),
                                Almacenamiento = reader.IsDBNull(reader.GetOrdinal("desc_almacenamiento")) ? string.Empty : reader.GetString("desc_almacenamiento"),
                                Pantalla = reader.IsDBNull(reader.GetOrdinal("desc_pantalla")) ? string.Empty : reader.GetString("desc_pantalla"),
                                TarjetaGrafica = reader.IsDBNull(reader.GetOrdinal("desc_tarjetaGrafica")) ? string.Empty : reader.GetString("desc_tarjetaGrafica"),
                                Categorias = reader.IsDBNull(reader.GetOrdinal("categorias")) ? string.Empty : reader.GetString("categorias")
                            };
                            lista.Add(notebook);
                        }
                    }
                }
            }
            return lista;
        }

        public bool Insertar(Notebook notebook, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Notebooks_Insertar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_ram", notebook.IdRam);
                        cmd.Parameters.AddWithValue("@p_id_procesador", notebook.IdProcesador);
                        cmd.Parameters.AddWithValue("@p_id_almacenamiento", notebook.IdAlmacenamiento);
                        cmd.Parameters.AddWithValue("@p_id_pantalla", notebook.IdPantalla);
                        cmd.Parameters.AddWithValue("@p_marca", notebook.Marca);
                        cmd.Parameters.AddWithValue("@p_modelo", notebook.Modelo);
                        cmd.Parameters.AddWithValue("@p_precio", notebook.Precio);
                        cmd.Parameters.AddWithValue("@p_stock", notebook.Stock);
                        cmd.Parameters.AddWithValue("@p_id_tarjetaGrafica", notebook.IdTarjetaGrafica);

                        conexion.Open();

                        // CAMBIO CLAVE: Ejecutamos, atrapamos el ID y se lo asignamos al objeto
                        int nuevoId = Convert.ToInt32(cmd.ExecuteScalar());
                        notebook.IdNotebook = nuevoId;

                        return true;
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

        public bool Actualizar(Notebook notebook, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Notebooks_Actualizar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_notebook", notebook.IdNotebook);
                        cmd.Parameters.AddWithValue("@p_id_ram", notebook.IdRam);
                        cmd.Parameters.AddWithValue("@p_id_procesador", notebook.IdProcesador);
                        cmd.Parameters.AddWithValue("@p_id_almacenamiento", notebook.IdAlmacenamiento);
                        cmd.Parameters.AddWithValue("@p_id_pantalla", notebook.IdPantalla);
                        cmd.Parameters.AddWithValue("@p_marca", notebook.Marca);
                        cmd.Parameters.AddWithValue("@p_modelo", notebook.Modelo);
                        cmd.Parameters.AddWithValue("@p_precio", notebook.Precio);
                        cmd.Parameters.AddWithValue("@p_stock", notebook.Stock);
                        cmd.Parameters.AddWithValue("@p_id_tarjetaGrafica", notebook.IdTarjetaGrafica);

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

        public bool Desactivar(int idNotebook, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Notebooks_Desactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_notebook", idNotebook);

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

        public bool Reactivar(int idNotebook, out string mensajeError)
        {
            mensajeError = string.Empty;
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("SP_Notebooks_Reactivar", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_notebook", idNotebook);

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

        public void GuardarCategoriasDeNotebook(int idNotebook, List<string> nombresCategorias)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();

                // 1. Limpiamos las categorías anteriores de esta notebook
                using (var cmdLimpiar = new MySqlCommand("SP_Notebooks_LimpiarCategorias", conexion))
                {
                    cmdLimpiar.CommandType = CommandType.StoredProcedure;
                    cmdLimpiar.Parameters.AddWithValue("@p_id_notebook", idNotebook);
                    cmdLimpiar.ExecuteNonQuery();
                }

                // 2. Insertamos cada categoría tildada en los CheckBoxes
                foreach (string nombreCat in nombresCategorias)
                {
                    using (var cmdAsignar = new MySqlCommand("SP_Notebooks_AsignarCategoriaPorNombre", conexion))
                    {
                        cmdAsignar.CommandType = CommandType.StoredProcedure;
                        cmdAsignar.Parameters.AddWithValue("@p_id_notebook", idNotebook);
                        cmdAsignar.Parameters.AddWithValue("@p_nombre_categoria", nombreCat);
                        cmdAsignar.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}