using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime FechaHora { get; set; } = DateTime.Now;
        public string IdCliente { get; set; } = string.Empty; // DNI / CUIT del Cliente
        public int IdUsuario { get; set; } // Vendedor/Usuario que registró la venta
        public decimal MontoTotal { get; set; }
        public string MetodoPago { get; set; } = string.Empty; // Efectivo, Tarjeta, Transferencia
        public bool Eliminado { get; set; } = false;

        // Propiedades de navegación
        public Cliente? Cliente { get; set; }
        public Usuario? Usuario { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public Venta() { }
        public Venta(int idVenta, DateTime fechaHora, string idCliente, int idUsuario,
                     decimal montoTotal, string metodoPago, bool eliminado = false)
        {
            IdVenta = idVenta;
            FechaHora = fechaHora;
            IdCliente = idCliente;
            IdUsuario = idUsuario;
            MontoTotal = montoTotal;
            MetodoPago = metodoPago;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"Venta #{IdVenta} - {FechaHora:dd/MM/yyyy HH:mm} - Total: ${MontoTotal:N2}";
        }
    }
}
