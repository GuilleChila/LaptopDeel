using System;
using System.Collections.Generic;
using System.Text;

namespace LaptopDeel.Entidades
{
    public class Cliente
    {
        public string IdCliente { get; set; } = string.Empty;
        public string NombreCompleto { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string IVA { get; set; } = "Consumidor Final";
        public bool Eliminado { get; set; } = false;

        public Cliente() { }
        public Cliente(string idCliente, string nombreCompleto, string correo, string telefono, string direccion, string iva, bool eliminado = false)
        {
            IdCliente = idCliente;
            NombreCompleto = nombreCompleto;
            Correo = correo;
            Telefono = telefono;
            Direccion = direccion;
            IVA = iva;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{NombreCompleto} ({IdCliente})";
        }
    }
}
