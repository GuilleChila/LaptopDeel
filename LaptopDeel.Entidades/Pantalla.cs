using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    internal class Pantalla
    {
        public int IdPantalla { get; set; }
        public string Tipo { get; set; } = string.Empty;
        public string Tamano { get; set; } = string.Empty;
        public string TasaRefresco { get; set; } = string.Empty;
        public bool Tactil { get; set; } = false;
        public bool Eliminado { get; set; } = false;

        public Pantalla() { }
        public Pantalla(int idPantalla, string tipo, string tamano, string tasaRefresco, bool tactil, bool eliminado = false)
        {
            IdPantalla = idPantalla;
            Tipo = tipo;
            Tamano = tamano;
            TasaRefresco = tasaRefresco;
            Tactil = tactil;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            string esTactil = Tactil ? "Táctil" : "No Táctil";
            return $"{Tamano}\" {Tipo} {TasaRefresco} ({esTactil})";
        }

    }
}
