using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class UsuarioDAO
    {
        /// <summary>
        /// Valida las credenciales mediante el procedimiento almacenado sp_IniciarSesion.
        /// </summary>
        public Usuario? IniciarSesion(string correo, string contrasena)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_IniciarSesion", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_correo", correo);
                    cmd.Parameters.AddWithValue("@p_contrasena", contrasena);

                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Usuario
                            {
                                IdUsuario = reader.GetInt32("id_usuario"),
                                IdRol = reader.GetInt32("id_rol"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                Correo = reader.GetString("correo"),
                                FechaNacimiento = reader.GetDateTime("fecha_nacimiento"),
                                DNI = reader.GetString("dni"),
                                Eliminado = reader.GetBoolean("eliminado"),
                                RolUsuario = new Rol
                                {
                                    IdRol = reader.GetInt32("id_rol"),
                                    RolName = reader.GetString("nombre_rol"),
                                    Descripcion = reader.IsDBNull(reader.GetOrdinal("rol_descripcion")) ? "" : reader.GetString("rol_descripcion"),
                                    Eliminado = reader.GetBoolean("rol_eliminado")
                                }
                            };
                        }
                    }
                }
            }

            return null;
        }

        /// <summary>
        /// Obtiene todos los usuarios mediante el procedimiento almacenado sp_ObtenerTodosUsuarios.
        /// </summary>
        public List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_ObtenerTodosUsuarios", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var u = new Usuario
                            {
                                IdUsuario = reader.GetInt32("id_usuario"),
                                IdRol = reader.GetInt32("id_rol"),
                                Nombre = reader.GetString("nombre"),
                                Apellido = reader.GetString("apellido"),
                                Correo = reader.GetString("correo"),
                                Contrasena = reader.GetString("contrasena"),
                                FechaNacimiento = reader.GetDateTime("fecha_nacimiento"),
                                DNI = reader.GetString("dni"),
                                Eliminado = reader.GetBoolean("eliminado")
                            };

                            if (!reader.IsDBNull(reader.GetOrdinal("nombre_rol")))
                            {
                                u.RolUsuario = new Rol
                                {
                                    IdRol = u.IdRol,
                                    RolName = reader.GetString("nombre_rol"),
                                    Descripcion = reader.IsDBNull(reader.GetOrdinal("rol_descripcion")) ? "" : reader.GetString("rol_descripcion"),
                                    Eliminado = reader.GetBoolean("rol_eliminado")
                                };
                            }

                            lista.Add(u);
                        }
                    }
                }
            }

            return lista;
        }

        /// <summary>
        /// Inserta un usuario delegando la validación de duplicados a sp_InsertarUsuario.
        /// </summary>
        public bool Insertar(Usuario usuario)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_InsertarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_id_rol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@p_apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@p_correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@p_contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@p_fecha_nacimiento", usuario.FechaNacimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@p_dni", usuario.DNI);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Modifica un usuario delegando validaciones a sp_ActualizarUsuario.
        /// </summary>
        public bool Actualizar(Usuario usuario)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_ActualizarUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@p_id_usuario", usuario.IdUsuario);
                        cmd.Parameters.AddWithValue("@p_id_rol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@p_nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@p_apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@p_correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@p_contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@p_fecha_nacimiento", usuario.FechaNacimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@p_dni", usuario.DNI);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Aplica la baja lógica marcando eliminado = TRUE vía sp_EliminarLogicoUsuario.
        /// </summary>
        public bool EliminarLogico(int idUsuario)
        {
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    using (var cmd = new MySqlCommand("sp_EliminarLogicoUsuario", conexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_id_usuario", idUsuario);

                        conexion.Open();
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }
}