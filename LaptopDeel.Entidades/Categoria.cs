using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;

        public Categoria() { }
        public Categoria(int idCategoria, string nombre, string descripcion, bool eliminado = false)
        {
            IdCategoria = idCategoria;
            Nombre = nombre;
            Descripcion = descripcion;
            Eliminado = eliminado;
        }
        public override string ToString()
        {          
            return Nombre;
        }
    }
}
