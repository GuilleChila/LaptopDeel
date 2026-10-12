using System;

namespace LaptopDeel.Entidades
{
    public class Notebook
    {
        public int IdNotebook { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;

        // Propiedades descriptivas (Para mostrar texto legible en la grilla en vez de IDs)
        public string Procesador { get; set; } = string.Empty;
        public string Ram { get; set; } = string.Empty;
        public string Almacenamiento { get; set; } = string.Empty;
        public string Pantalla { get; set; } = string.Empty;
        public string TarjetaGrafica { get; set; } = string.Empty;
        public string Categorias { get; set; } = string.Empty;

        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public bool Eliminado { get; set; } = false;

        // Claves Foráneas de Módulos de Hardware (Respetando tu IdRam en mayúsculas)
        public int IdProcesador { get; set; }
        public int IdRam { get; set; }
        public int IdAlmacenamiento { get; set; }
        public int IdPantalla { get; set; }
        public int IdTarjetaGrafica { get; set; }

        // 1. Constructor vacío (Vital para que el DAO y los formularios sean más fáciles de usar)
        public Notebook() { }

        // 2. Tu constructor original intacto
        public Notebook(int idNotebook, string marca, string modelo, int idProcesador, int idRam, int idAlmacenamiento, int idPantalla, int idTarjetaGrafica, decimal precio, int stock, bool eliminado = false)
        {
            IdNotebook = idNotebook;
            Marca = marca;
            Modelo = modelo;
            IdProcesador = idProcesador;
            IdRam = idRam;
            IdAlmacenamiento = idAlmacenamiento;
            IdPantalla = idPantalla;
            IdTarjetaGrafica = idTarjetaGrafica;
            Precio = precio;
            Stock = stock;
            Eliminado = eliminado;
        }

        // Tu método ToString() intacto
        public override string ToString()
        {
            return $"{Marca} {Modelo} - ${Precio:N2} (Stock: {Stock})";
        }
        
    }
}