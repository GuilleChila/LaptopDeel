using System;

namespace LaptopDeel.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public int IdSesionActiva { get; set; } = 0;

        public Rol? RolUsuario { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, int idRol, string nombre, string apellido, string correo,
                       string contrasena, DateTime fechaNacimiento, string dni, bool eliminado = false,
                       int idSesionActiva = 0)
        {
            IdUsuario = idUsuario;
            IdRol = idRol;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Contrasena = contrasena;
            FechaNacimiento = fechaNacimiento;
            DNI = dni;
            Eliminado = eliminado;
            IdSesionActiva = idSesionActiva;
        }

        public string NombreCompleto => $"{Nombre} {Apellido}";

        public override string ToString()
        {
            return $"{NombreCompleto} ({Correo})";
        }
    }
}