using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Ram
    {
        public int IdRam { get; set; }
        public string Capacidad { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public Ram() { }
        public Ram(int idRam, string capacidad, string generacion, bool eliminado = false)
        {
            IdRam = idRam;
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
