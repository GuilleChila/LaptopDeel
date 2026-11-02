using Krypton.Toolkit;
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
    public partial class ControlStockNotebooks : UserControl
    {
        public ControlStockNotebooks()
        {
            InitializeComponent();
        }


        private void ControlStockNotebooks_Load(object sender, EventArgs e)
        {
            try
            {
                // Instanciamos el DAO (asegurate de usar el nombre correcto de tu clase)
                NotebookDAO dao = new NotebookDAO();
                dgvStock.DataSource = dao.ObtenerReporteStock();

                // Formato de moneda
                if (dgvStock.Columns["Precio"] != null)
                {
                    dgvStock.Columns["Precio"].DefaultCellStyle.Format = "C2";
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar el stock: " + ex.Message,
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 1. Verificamos que la columna se llame "Stock_Actual" (como le pusimos en el SP) y no esté vacía
            if (this.dgvStock.Columns[e.ColumnIndex].Name == "Stock_Actual" && e.Value != null)
            {
                int stock;
                // 2. Convertimos el valor a número de forma segura
                if (int.TryParse(e.Value.ToString(), out stock))
                {
                    // 3. Si quedan 5 o menos, disparamos la alerta visual
                    if (stock <= 5)
                    {
                        // Pintamos el fondo de un rojo claro (Salmon) y la letra de rojo oscuro y negrita
                        e.CellStyle.BackColor = Color.Salmon;
                        e.CellStyle.ForeColor = Color.DarkRed;
                        e.CellStyle.Font = new Font(dgvStock.Font, FontStyle.Bold);

                        // TIP: Si quisieras pintar TODA la fila en lugar de solo la celda, usarías esto:
                        // dgvStock.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Salmon;
                    }
                }
            }
        }

       
    }
}