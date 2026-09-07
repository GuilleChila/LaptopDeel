using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Categoria_Notebook
    {
        public int IdNotebook { get; set; }
        public int IdCategoria { get; set; }
        public bool Eliminado { get; set; } = false;

        // Propiedades de navegación
        public Notebook? Notebook { get; set; }
        public Categoria? Categoria { get; set; }

        public Categoria_Notebook() { }

        public Categoria_Notebook(int idNotebook, int idCategoria, bool eliminado = false)
        {
            IdNotebook = idNotebook;
            IdCategoria = idCategoria;
            Eliminado = eliminado;
        }

    }
}
