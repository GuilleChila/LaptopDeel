using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormFacturacion : KryptonForm
    {
        public PedidoVentaDTO PedidoDraft { get; private set; }

        // 1. Constructor principal que recibe el DTO de transferencia
        public FormFacturacion(PedidoVentaDTO pedidoDraft)
        {
            InitializeComponent();
            PedidoDraft = pedidoDraft;

            this.Text = "LaptopDeel - Módulo de Facturación y Cobro";
            this.StartPosition = FormStartPosition.CenterScreen;

            KryptonMessageBox.Show(
                $"Módulo de Facturación iniciado para el cliente: {PedidoDraft.ClienteAsociado.NombreCompleto}\n" +
                $"Cantidad de ítems en pedido: {PedidoDraft.ItemsCarrito.Count}\n" +
                $"Monto Total: ${PedidoDraft.TotalVenta:N0}",
                "Facturación Activa",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }

        // 2. Sobrecarga opcional para mantener compatibilidad previa (si se invoca con Cliente y lista de Notebooks)
        public FormFacturacion(Cliente cliente, List<Notebook> carrito)
        {
            InitializeComponent();

            this.Text = "LaptopDeel - Módulo de Facturación y Cobro";
            this.StartPosition = FormStartPosition.CenterScreen;

            KryptonMessageBox.Show(
                $"Módulo de Facturación iniciado para el cliente: {cliente.NombreCompleto}\n" +
                $"Equipos a facturar: {carrito.Count}",
                "Facturación Activa",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }
    }
}