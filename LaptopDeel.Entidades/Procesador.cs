using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Procesador
    {
        public int IdProcesador { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public string Velocidad { get; set; } = string.Empty;
        public int Nucleos { get; set; }
        public int Hilos { get; set; }
        public bool Eliminado { get; set; } = false;

        public Procesador() { }

        public Procesador(int idProcesador, string marca, string generacion, string velocidad, int nucleos, int hilos, bool eliminado = false)
        {
            IdProcesador = idProcesador;
            Marca = marca;
            Generacion = generacion;
            Velocidad = velocidad;
            Nucleos = nucleos;
            Hilos = hilos;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Marca} {Generacion} ({Nucleos}C/{Hilos}T - {Velocidad})";
        }
    }
}
