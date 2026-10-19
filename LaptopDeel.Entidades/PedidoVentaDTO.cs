using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class PedidoVentaDTO
    {
        // Snapshot / Fotografía inmutable del cliente al momento del armado
        public Cliente ClienteAsociado { get; set; }
        public List<ElementoCarrito> ItemsCarrito { get; set; } = new List<ElementoCarrito>();
        public decimal TotalVenta { get; set; }
        public DateTime FechaBorrador { get; set; } = DateTime.Now;

        public PedidoVentaDTO(Cliente cliente, List<ElementoCarrito> items, decimal total)
        {
            ClienteAsociado = cliente;
            ItemsCarrito = items;
            TotalVenta = total;
        }
    }
}
