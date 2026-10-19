using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class ElementoCarrito
    {
        public Notebook Laptop { get; set; }
        public int Cantidad { get; set; }

        // Congelamiento del precio unitario histórico al momento de agregar al carrito
        public decimal PrecioUnitarioCongelado { get; set; }

        public ElementoCarrito(Notebook laptop, int cantidad)
        {
            Laptop = laptop;
            Cantidad = cantidad;
            PrecioUnitarioCongelado = laptop.Precio;
        }

        public decimal SubtotalItem => PrecioUnitarioCongelado * Cantidad;
    }
}
