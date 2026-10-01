using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Pantalla
    {
        public int IdPantalla { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Tamano { get; set; } = string.Empty;
        public string TasaRefresco { get; set; } = string.Empty;
        public string Resolucion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public Pantalla() { }
        public Pantalla(int idPantalla, string tipo, string tamano, string tasaRefresco, string resolucion, bool eliminado = false)
        {
            IdPantalla = idPantalla;
            Tipo = tipo;
            Tamano = tamano;
            TasaRefresco = tasaRefresco;
            Resolucion = resolucion;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Tamano}\" {Tipo} {TasaRefresco} ({Resolucion})";
        }

    }
}
