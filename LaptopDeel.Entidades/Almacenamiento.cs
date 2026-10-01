using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Almacenamiento
    {
        public int IdAlmacenamiento { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Capacidad { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public Almacenamiento() { }
        public Almacenamiento(int idAlmacenamiento, string tipo, string capacidad, bool eliminado = false)
        {
            IdAlmacenamiento = idAlmacenamiento;
            Tipo = tipo;
            Capacidad = capacidad;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Tipo} {Capacidad}";
        }
    }
}
