using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class FormFacturacion : KryptonForm
    {
        private Cliente _cliente;
        private List<Notebook> _carrito;

        public FormFacturacion(Cliente cliente, List<Notebook> carrito)
        {
            InitializeComponent();
            _cliente = cliente;
            _carrito = carrito;

            this.Text = "LaptopDeel - Módulo de Facturación y Cobro";
            this.StartPosition = FormStartPosition.CenterScreen;

            KryptonMessageBox.Show(
                $"Módulo de Facturación iniciado para el cliente: {_cliente.NombreCompleto}\nEquipos a facturar: {_carrito.Count}",
                "Facturación Activa",
                KryptonMessageBoxButtons.OK,
                KryptonMessageBoxIcon.Information
            );
        }
    }
}