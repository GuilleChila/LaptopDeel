using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Notebook
    {
        public int IdNotebook { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;

        // Claves Foráneas de Módulos de Hardware
        public int IdProcesador { get; set; }
        public int IdRAM { get; set; }
        public int IdAlmacenamiento { get; set; }
        public int IdPantalla { get; set; }

        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Eliminado { get; set; } = false;

        // Propiedades de navegación de Hardware
        public Procesador? Procesador { get; set; }
        public RAM? RAM { get; set; }
        public Almacenamiento? Almacenamiento { get; set; }
        public Pantalla? Pantalla { get; set; }

        public Notebook() { }
        public Notebook(int idNotebook, string marca, string modelo, int idProcesador,int idRAM, int idAlmacenamiento, int idPantalla, decimal precio,int stock, bool eliminado = false)
        {
            IdNotebook = idNotebook;
            Marca = marca;
            Modelo = modelo;
            IdProcesador = idProcesador;
            IdRAM = idRAM;
            IdAlmacenamiento = idAlmacenamiento;
            IdPantalla = idPantalla;
            Precio = precio;
            Stock = stock;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Marca} {Modelo} - ${Precio:N2} (Stock: {Stock})";
        }
    }
}
