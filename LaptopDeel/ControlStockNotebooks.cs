using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlStockNotebooks : UserControl
    {
        private NotebookDAO _notebookDAO;
        private List<Notebook> _listaNotebooks;
        private DataTable _dtStock;

        public ControlStockNotebooks()
        {
            InitializeComponent();
            _notebookDAO = new NotebookDAO();
            _listaNotebooks = new List<Notebook>();
        }

        private void ControlStockNotebooks_Load(object sender, EventArgs e)
        {
            CargarOpcionesFiltro();
            CargarDatosStock();
        }

        private void CargarOpcionesFiltro()
        {
            cmbFiltroStock.Items.Clear();
            cmbFiltroStock.Items.AddRange(new string[] {
                "Todos los Niveles",
                "🟢 Stock Normal (Stock >= 7)",
                "🟡 Stock Medio (Stock < 7)",
                "🟠 Stock Bajo (Stock < 3)",
                "🔴 Stock Agotado (Stock = 0)"
            });
            cmbFiltroStock.SelectedIndex = 0;
        }

        public void CargarDatosStock()
        {
            try
            {
                _listaNotebooks = _notebookDAO.ObtenerTodos().Where(n => !n.Eliminado).ToList();

                EstructurarDataTable();
                PoblarDataTable(_listaNotebooks);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar el reporte de stock: " + ex.Message,
                    "Error de Conexión", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void EstructurarDataTable()
        {
            _dtStock = new DataTable();
            _dtStock.Columns.Add("Marca", typeof(string));
            _dtStock.Columns.Add("Modelo", typeof(string));
            _dtStock.Columns.Add("Categoria", typeof(string));
            _dtStock.Columns.Add("Stock", typeof(int));
            _dtStock.Columns.Add("Estado_Stock", typeof(string));
            _dtStock.Columns.Add("PrecioUnitario", typeof(decimal));
        }

        private void PoblarDataTable(List<Notebook> laptops)
        {
            _dtStock.Rows.Clear();

            foreach (var n in laptops)
            {
                string estadoTexto = "🟢 Normal";
                if (n.Stock == 0)
                {
                    estadoTexto = "🔴 Stock Agotado";
                }
                else if (n.Stock < 3)
                {
                    estadoTexto = "🟠 Stock Bajo";
                }
                else if (n.Stock < 7)
                {
                    estadoTexto = "🟡 Stock Medio";
                }

                string categoria = string.IsNullOrWhiteSpace(n.Categorias) ? "General" : n.Categorias;

                _dtStock.Rows.Add(
                    n.Marca,
                    n.Modelo,
                    categoria,
                    n.Stock,
                    estadoTexto,
                    n.Precio
                );
            }

            dgvStock.DataSource = _dtStock;
            ConfigurarFormatoGrilla();
            AplicarFiltros();
        }

        private void ConfigurarFormatoGrilla()
        {
            if (dgvStock.Columns.Count == 0) return;

            if (dgvStock.Columns["PrecioUnitario"] != null)
            {
                dgvStock.Columns["PrecioUnitario"].Visible = false;
            }

            if (dgvStock.Columns["Marca"] != null) dgvStock.Columns["Marca"].HeaderText = "Marca";
            if (dgvStock.Columns["Modelo"] != null) dgvStock.Columns["Modelo"].HeaderText = "Modelo";
            if (dgvStock.Columns["Categoria"] != null) dgvStock.Columns["Categoria"].HeaderText = "Categoría";
            if (dgvStock.Columns["Stock"] != null) dgvStock.Columns["Stock"].HeaderText = "Stock";
            if (dgvStock.Columns["Estado_Stock"] != null) dgvStock.Columns["Estado_Stock"].HeaderText = "Estado de stock";
        }

        private void dgvStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvStock.Rows.Count) return;

            string nombreColumna = dgvStock.Columns[e.ColumnIndex].Name;

            if (nombreColumna == "Stock" || nombreColumna == "Estado_Stock")
            {
                int stock = -1;
                bool tieneStockValido = false;

                if (dgvStock.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
                {
                    if (drv.Row.Table.Columns.Contains("Stock") && drv["Stock"] != DBNull.Value)
                    {
                        stock = Convert.ToInt32(drv["Stock"]);
                        tieneStockValido = true;
                    }
                }

                if (tieneStockValido)
                {
                    Color backColor;
                    Color foreColor;

                    if (stock == 0) // ROJO: Sin Stock
                    {
                        backColor = Color.FromArgb(254, 226, 226);
                        foreColor = Color.FromArgb(185, 28, 28);
                    }
                    else if (stock < 3) // ANARANJADO: Stock Bajo
                    {
                        backColor = Color.FromArgb(255, 237, 213);
                        foreColor = Color.FromArgb(194, 65, 12);
                    }
                    else if (stock < 7) // AMARILLO: Stock Medio
                    {
                        backColor = Color.FromArgb(254, 249, 195);
                        foreColor = Color.FromArgb(161, 98, 7);
                    }
                    else // VERDE: Stock Normal (>= 7)
                    {
                        backColor = Color.FromArgb(220, 252, 231);
                        foreColor = Color.FromArgb(21, 128, 61);
                    }

                    // Aplicar estilos a la celda en estado normal y seleccionado
                    e.CellStyle.BackColor = backColor;
                    e.CellStyle.ForeColor = foreColor;
                    e.CellStyle.SelectionBackColor = backColor;
                    e.CellStyle.SelectionForeColor = foreColor;
                    e.CellStyle.Font = new Font(dgvStock.Font, FontStyle.Bold);
                }
            }
        }

        private void AplicarFiltros()
        {
            if (_dtStock == null) return;

            List<string> filtros = new List<string>();

            string textoBuscar = txtBuscar.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrEmpty(textoBuscar))
            {
                filtros.Add($"(Marca LIKE '%{textoBuscar}%' OR Modelo LIKE '%{textoBuscar}%')");
            }

            if (cmbFiltroStock.SelectedIndex == 1) // Stock Normal (>= 7)
            {
                filtros.Add("Stock >= 7");
            }
            else if (cmbFiltroStock.SelectedIndex == 2) // Stock Medio (< 7)
            {
                filtros.Add("Stock < 7 AND Stock >= 3");
            }
            else if (cmbFiltroStock.SelectedIndex == 3) // Stock Bajo (< 3)
            {
                filtros.Add("Stock < 3 AND Stock > 0");
            }
            else if (cmbFiltroStock.SelectedIndex == 4) // Stock Agotado (= 0)
            {
                filtros.Add("Stock = 0");
            }

            _dtStock.DefaultView.RowFilter = string.Join(" AND ", filtros);
            CalcularMontoTotalExistencias();
        }

        private void CalcularMontoTotalExistencias()
        {
            decimal montoTotal = 0;
            foreach (DataRowView rowView in _dtStock.DefaultView)
            {
                int stock = Convert.ToInt32(rowView["Stock"]);
                decimal precio = Convert.ToDecimal(rowView["PrecioUnitario"]);
                montoTotal += (stock * precio);
            }


            lblMontoTotalExistencias.Text = $"Monto Total de Existencias: {montoTotal:C2} ";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) => AplicarFiltros();
        private void cmbFiltroStock_SelectedIndexChanged(object sender, EventArgs e) => AplicarFiltros();

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                List<Notebook> listaAExportar = new List<Notebook>();

                foreach (DataRowView rowView in _dtStock.DefaultView)
                {
                    DataRow row = rowView.Row;
                    listaAExportar.Add(new Notebook
                    {
                        Marca = row["Marca"].ToString(),
                        Modelo = row["Modelo"].ToString(),
                        Categorias = row["Categoria"].ToString(),
                        Stock = Convert.ToInt32(row["Stock"]),
                        Precio = Convert.ToDecimal(row["PrecioUnitario"])
                    });
                }

                decimal totalCalculado = listaAExportar.Sum(x => x.Stock * x.Precio);

                string rutaPdfGenerado = GeneradorPdfStock.ExportarReporteStock(listaAExportar, totalCalculado);

                KryptonMessageBox.Show($"¡Reporte de stock generado con éxito!\n\n📄 Guardado en:\n{rutaPdfGenerado}",
                                       "Reporte PDF Emitido", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                if (File.Exists(rutaPdfGenerado))
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(rutaPdfGenerado) { UseShellExecute = true });
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Ocurrió un error al generar el PDF de stock:\n{ex.Message}",
                                       "Error PDF", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
    }
}