using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class DetalleVenta
    {
        public int IdDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdNotebook { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; } // Precio congelado al vender
        public decimal Subtotal => Cantidad * PrecioUnitario; // Propiedad calculada
        public bool Eliminado { get; set; } = false;

        // Propiedades de navegación
        public Venta? Venta { get; set; }
        public Notebook? Notebook { get; set; }

        public DetalleVenta() { }

        public DetalleVenta(int idDetalle, int idVenta, int idNotebook, int cantidad, decimal precioUnitario, bool eliminado = false)
        {
            IdDetalle = idDetalle;
            IdVenta = idVenta;
            IdNotebook = idNotebook;
            Cantidad = cantidad;
            PrecioUnitario = precioUnitario;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"Detalle #{IdDetalle} - Cant: {Cantidad} - Subtotal: ${Subtotal:N2}";
        }
    }
}
