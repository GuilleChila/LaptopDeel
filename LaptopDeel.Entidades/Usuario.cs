using System;
using System.Collections.Generic;
using System.Text;

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

        // Propiedad de navegación orientada a objetos
        public Rol? RolUsuario { get; set; }

        public Usuario() { }

        public Usuario(int idUsuario, int idRol, string nombre, string apellido, string correo, string contrasena, DateTime fechaNacimiento, string dni, bool eliminado = false)
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
        }
        public string NombreCompleto => $"{Nombre} {Apellido}";

        public override string ToString()
        {
            return $"{NombreCompleto} ({Correo})";
        }
    }
}
