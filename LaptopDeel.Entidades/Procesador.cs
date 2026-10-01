using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Procesador
    {
        public int IdProcesador { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Generacion { get; set; } = string.Empty;
        public string Velocidad { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public Procesador() { }

        public Procesador(int idProcesador, string nombre, string marca, string generacion, string velocidad, bool eliminado = false)
        {
            IdProcesador = idProcesador;
            Nombre = nombre;
            Marca = marca;
            Generacion = generacion;
            Velocidad = velocidad;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Nombre} {Marca} {Generacion} ({Velocidad})";
        }
    }
}
