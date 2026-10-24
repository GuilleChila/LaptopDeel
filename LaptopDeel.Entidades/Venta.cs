using System;
using System.Collections.Generic;

namespace LaptopDeel.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }

        // Atributo fiscal del comprobante correlativo (Ej: 0001-00000001)
        public string NumeroFactura { get; set; } = string.Empty;

        public DateTime FechaHora { get; set; } = DateTime.Now;
        public string IdCliente { get; set; } = string.Empty; // DNI / CUIT del Cliente
        public int IdUsuario { get; set; } // PK Vendedor/Usuario que registró la venta
        public decimal MontoTotal { get; set; }
        public string MetodoPago { get; set; } = string.Empty; // Efectivo, Tarjeta, Transferencia
        public bool Eliminado { get; set; } = false;

        // Propiedades de navegación de la arquitectura orientada a objetos
        public Cliente? Cliente { get; set; }
        public Usuario? Usuario { get; set; }
        public List<DetalleVenta> Detalles { get; set; } = new List<DetalleVenta>();

        public Venta() { }

        public Venta(int idVenta, string numeroFactura, DateTime fechaHora, string idCliente,
                     int idUsuario, decimal montoTotal, string metodoPago, bool eliminado = false)
        {
            IdVenta = idVenta;
            NumeroFactura = numeroFactura;
            FechaHora = fechaHora;
            IdCliente = idCliente;
            IdUsuario = idUsuario;
            MontoTotal = montoTotal;
            MetodoPago = metodoPago;
            Eliminado = eliminado;
        }

        // Sobrecarga histórica sin numeroFactura para compatibilidad
        public Venta(int idVenta, DateTime fechaHora, string idCliente, int idUsuario,
                     decimal montoTotal, string metodoPago, bool eliminado = false)
            : this(idVenta, string.Empty, fechaHora, idCliente, idUsuario, montoTotal, metodoPago, eliminado)
        {
        }

        public override string ToString()
        {
            string facturaStr = string.IsNullOrWhiteSpace(NumeroFactura) ? $"#{IdVenta}" : NumeroFactura;
            return $"Venta Factura {facturaStr} - {FechaHora:dd/MM/yyyy HH:mm} - Total: ${MontoTotal:N2}";
        }
    }
}