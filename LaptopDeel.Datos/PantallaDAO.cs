using LaptopDeel.Entidades;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;

namespace LaptopDeel.Datos
{
    public class PantallaDAO
    {
        // 1. OBTENER TODOS
        public List<Pantalla> ObtenerTodos()
        {
            var lista = new List<Pantalla>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Pantallas_ObtenerTodos", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var pantalla = new Pantalla
                            {
                                IdPantalla = reader.GetInt32("id_pantalla"),
                                Tipo = reader.IsDBNull(reader.GetOrdinal("tipo")) ? string.Empty : reader.GetString("tipo"),
                                Tamano = reader.IsDBNull(reader.GetOrdinal("tamano")) ? string.Empty : reader.GetString("tamano"),
                                TasaRefresco = reader.IsDBNull(reader.GetOrdinal("tasa_refresco")) ? string.Empty : reader.GetString("tasa_refresco"),
                                Resolucion = reader.IsDBNull(reader.GetOrdinal("resolucion")) ? string.Empty : reader.GetString("resolucion"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };
                            lista.Add(pantalla);
                        }
                    }
                }
            }
            return lista;
        }

        // 2. INSERTAR
        public bool Insertar(Pantalla pantalla)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Pantallas_Insertar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_tipo", pantalla.Tipo);
                    cmd.Parameters.AddWithValue("p_tamano", pantalla.Tamano);
                    cmd.Parameters.AddWithValue("p_tasa_refresco", pantalla.TasaRefresco);
                    cmd.Parameters.AddWithValue("p_resolucion", pantalla.Resolucion);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // 3. ACTUALIZAR
        public bool Actualizar(Pantalla pantalla)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Pantallas_Actualizar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id_pantalla", pantalla.IdPantalla);
                    cmd.Parameters.AddWithValue("p_tipo", pantalla.Tipo);
                    cmd.Parameters.AddWithValue("p_tamano", pantalla.Tamano);
                    cmd.Parameters.AddWithValue("p_tasa_refresco", pantalla.TasaRefresco);
                    cmd.Parameters.AddWithValue("p_resolucion", pantalla.Resolucion);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // 4. DESACTIVAR (Borrado lógico)
        public bool Desactivar(int idPantalla)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Pantallas_Desactivar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id_pantalla", idPantalla);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        // 5. REACTIVAR
        public bool Reactivar(int idPantalla)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Pantallas_Reactivar", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("p_id_pantalla", idPantalla);

                    conexion.Open();
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
    }
}