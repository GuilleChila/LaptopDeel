using System;
using System.Collections.Generic;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class UsuarioDAO
    {
        /// <summary>
        /// Valida las credenciales de un usuario y obtiene su perfil junto con su Rol.
        /// </summary>
        public Usuario? IniciarSesion(string correo, string contrasena)
        {
            const string sql = @"
                SELECT u.id_usuario, u.id_rol, u.nombre, u.apellido, u.correo, 
                       u.fecha_nacimiento, u.dni, u.eliminado,
                       r.nombre_rol, r.descripcion AS rol_descripcion, r.eliminado AS rol_eliminado
                FROM usuarios u
                INNER JOIN rols r ON u.id_rol = r.id_rol
                WHERE u.correo = @correo 
                  AND u.contrasena = @pass 
                  AND u.eliminado = FALSE;";

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand(sql, conexion))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@pass", contrasena);

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
        /// Obtiene todos los usuarios registrados en la base de datos (activos e inactivos).
        /// </summary>
        public List<Usuario> ObtenerTodos()
        {
            var lista = new List<Usuario>();

            const string query = @"
                SELECT u.id_usuario, u.id_rol, u.nombre, u.apellido, u.correo, 
                       u.contrasena, u.fecha_nacimiento, u.dni, u.eliminado,
                       r.nombre_rol, r.descripcion AS rol_descripcion, r.eliminado AS rol_eliminado
                FROM usuarios u
                LEFT JOIN rols r ON u.id_rol = r.id_rol;";

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var cmd = new MySqlCommand(query, conexion))
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

            return lista;
        }

        /// <summary>
        /// Inserta un nuevo registro de usuario en la base de datos.
        /// </summary>
        public bool Insertar(Usuario usuario)
        {
            const string query = @"
                INSERT INTO usuarios (id_rol, nombre, apellido, correo, contrasena, fecha_nacimiento, dni, eliminado)
                VALUES (@id_rol, @nombre, @apellido, @correo, @contrasena, @fecha_nacimiento, @dni, FALSE);";

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", usuario.FechaNacimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@dni", usuario.DNI);

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
        /// Modifica los datos personales y de acceso de un usuario existente.
        /// </summary>
        public bool Actualizar(Usuario usuario)
        {
            const string query = @"
                UPDATE usuarios 
                SET id_rol = @id_rol,
                    nombre = @nombre,
                    apellido = @apellido,
                    correo = @correo,
                    contrasena = @contrasena,
                    fecha_nacimiento = @fecha_nacimiento,
                    dni = @dni
                WHERE id_usuario = @id_usuario;";

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", usuario.IdUsuario);
                        cmd.Parameters.AddWithValue("@id_rol", usuario.IdRol);
                        cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                        cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);
                        cmd.Parameters.AddWithValue("@correo", usuario.Correo);
                        cmd.Parameters.AddWithValue("@contrasena", usuario.Contrasena);
                        cmd.Parameters.AddWithValue("@fecha_nacimiento", usuario.FechaNacimiento.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@dni", usuario.DNI);

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
        /// Aplica la baja lógica marcando eliminado = TRUE en la base de datos.
        /// </summary>
        public bool EliminarLogico(int idUsuario)
        {
            const string query = "UPDATE usuarios SET eliminado = TRUE WHERE id_usuario = @id_usuario;";

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    using (var cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario);
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