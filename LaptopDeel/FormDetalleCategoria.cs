using LaptopDeel.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LaptopDeel
{
    public partial class FormDetalleCategoria : Form
    {
        // Modificamos el constructor para que pida la categoría y las fechas
        public FormDetalleCategoria(string categoria, DateTime desde, DateTime hasta)
        {
            InitializeComponent();

            // Le ponemos un título lindo a la ventana
            this.Text = $"Detalle de Facturas - {categoria} ({desde.ToShortDateString()} al {hasta.ToShortDateString()})";

            // Llamamos al DAO y llenamos la grilla apenas se abre la ventana
            VentasDAO dao = new VentasDAO();
            dgvDetalles.DataSource = dao.ObtenerDetalleFacturasPorCategoria(categoria, desde, hasta);

            // Opcional: Darle formato de plata a la columna Subtotal y Precio
            if (dgvDetalles.Columns["Subtotal"] != null) dgvDetalles.Columns["Subtotal"].DefaultCellStyle.Format = "C2";
            if (dgvDetalles.Columns["Precio_Unitario"] != null) dgvDetalles.Columns["Precio_Unitario"].DefaultCellStyle.Format = "C2";
        }

      
    }
}
