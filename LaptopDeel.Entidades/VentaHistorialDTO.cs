using System;

namespace LaptopDeel.Entidades
{
    public class VentaHistorialDTO
    {
        // Propiedades base
        public int IdVenta { get; set; }
        public DateTime FechaHora { get; set; }
        public string NumeroFactura { get; set; } = string.Empty;
        public string NombreVendedor { get; set; } = string.Empty;
        public string DniCliente { get; set; } = string.Empty;
        public string NombreCliente { get; set; } = string.Empty;
        public string MedioPago { get; set; } = "Efectivo";
        public string ProductosComprados { get; set; } = string.Empty;
        public decimal PrecioTotal { get; set; }
        public int IdUsuario { get; set; }

        // =========================================================================
        // PROPIEDADES ALIAS / COMPATIBILIDAD (Evitan errores CS1061 en la UI)
        // =========================================================================
        public DateTime FechaEmision
        {
            get => FechaHora;
            set => FechaHora = value;
        }

        public string Cliente
        {
            get => NombreCliente;
            set => NombreCliente = value;
        }

        public string Vendedor
        {
            get => NombreVendedor;
            set => NombreVendedor = value;
        }

        public decimal Total
        {
            get => PrecioTotal;
            set => PrecioTotal = value;
        }

        // =========================================================================
        // CONSTRUCTORES
        // =========================================================================
        public VentaHistorialDTO() { }

        public VentaHistorialDTO(int idVenta, DateTime fechaHora, string numeroFactura,
                                 string nombreVendedor, string dniCliente, string nombreCliente,
                                 string productosComprados, decimal precioTotal, int idUsuario,
                                 string medioPago = "Efectivo")
        {
            IdVenta = idVenta;
            FechaHora = fechaHora;
            NumeroFactura = numeroFactura;
            NombreVendedor = nombreVendedor;
            DniCliente = dniCliente;
            NombreCliente = nombreCliente;
            ProductosComprados = productosComprados;
            PrecioTotal = precioTotal;
            IdUsuario = idUsuario;
            MedioPago = medioPago;
        }
    }
}