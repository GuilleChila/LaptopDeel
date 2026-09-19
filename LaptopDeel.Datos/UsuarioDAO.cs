using System;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class UsuarioDAO
    {
        public Usuario? IniciarSesion(string correo, string contrasena)
        {
            const string sql = @"
                SELECT u.id_usuario, u.id_rol, u.nombre, u.apellido, u.correo, 
                       u.fecha_nacimiento, u.dni, u.eliminado,
                       r.rol_nombre, r.descripcion AS rol_descripcion, r.eliminado AS rol_eliminado
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
                                    RolName = reader.GetString("rol_nombre"),
                                    Descripcion = reader.GetString("rol_descripcion"),
                                    Eliminado = reader.GetBoolean("rol_eliminado")
                                }
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}