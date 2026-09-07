using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class RAM
    {
        public int IdRAM { get; set; }
        public string Capacidad { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public string Velocidad { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public RAM() { }
        public RAM(int idRAM, string capacidad, string tipo, string velocidad, string generacion, bool eliminado = false)
        {
            IdRAM = idRAM;
            Capacidad = capacidad;
            Tipo = tipo;
            Velocidad = velocidad;
            Generacion = generacion;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Capacidad} {Tipo} {Generacion} ({Velocidad})";
        }
    }
}
