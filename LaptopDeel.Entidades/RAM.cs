using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class RAM
    {
        public int IdRAM { get; set; }
        public string Capacidad { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public RAM() { }
        public RAM(int idRAM, string capacidad, string generacion, bool eliminado = false)
        {
            IdRAM = idRAM;
            Capacidad = capacidad;
            Generacion = generacion;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Capacidad} {Generacion}";
        }
    }
}
