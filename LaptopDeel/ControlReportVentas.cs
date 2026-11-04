using Krypton.Toolkit;
using LaptopDeel.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LaptopDeel
{
    public partial class ControlReportVentas : UserControl
    {
        public ControlReportVentas()
        {
            InitializeComponent();
        }

        // Declaramos el gráfico a nivel clase
        private Chart chartVentas;

        private void ControlReporteVentas_Load(object sender, EventArgs e)
        {
            // Lo creamos por código
            chartVentas = new Chart();
            chartVentas.Dock = DockStyle.Fill; // Para que ocupe todo el espacio central
            panelGrafico.Controls.Add(chartVentas);
            // Configuramos el área y le sacamos la cuadrícula
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.Enabled = false;
            chartVentas.ChartAreas.Add(area);

            // Configuramos la serie de barras
            Series serie = new Series("Ingresos ($)");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;
            serie.LabelFormat = "C0";
            chartVentas.Series.Add(serie);

            // --- NUEVO: CARGA AUTOMÁTICA DESDE EL 1 DE ENERO ---
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Now;
            btnGenerar.PerformClick(); // Simula el clic del usuario
                                       // ------------------------------------------------

            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

            // 2. Validamos que las fechas tengan sentido lógica
            if (fechaDesde > fechaHasta)
            {
                KryptonMessageBox.Show("La fecha 'Desde' no puede ser mayor a la fecha 'Hasta'.",
                    "Rango Inválido", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            try
            {
                VentasDAO dao = new VentasDAO();
                DataTable datosReporte = dao.ObtenerVentasPorCategoria(fechaDesde, fechaHasta);

                // 1. PRIMERO evaluamos si hay datos
                if (datosReporte.Rows.Count > 0)
                {
                    // 2. SOLO si hay datos, actualizamos la grilla y el gráfico
                    dgvReporte.DataSource = datosReporte;

                    chartVentas.DataSource = datosReporte;
                    chartVentas.Series[0].XValueMember = "Categoria";
                    chartVentas.Series[0].YValueMembers = "Ingreso_Total";
                    chartVentas.DataBind();

                    // 3. Agregamos el botón si no existe
                    if (dgvReporte.Columns["btnVerDetalles"] == null)
                    {
                        DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                        colBoton.Name = "btnVerDetalles";
                        colBoton.HeaderText = "Acciones";
                        colBoton.Text = "Ver Facturas";
                        colBoton.UseColumnTextForButtonValue = true;
                        dgvReporte.Columns.Add(colBoton);
                    }

                    // 4. Aplicamos el formato de moneda
                    if (dgvReporte.Columns["Ingreso_Total"] != null)
                    {
                        dgvReporte.Columns["Ingreso_Total"].DefaultCellStyle.Format = "C2";
                    }
                }
                else
                {
                    // Si no hay datos, mostramos el cartel PERO no borramos lo que ya estaba en pantalla
                    KryptonMessageBox.Show("No se encontraron ventas en ese rango de fechas.",
                        "Sin datos", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al generar el reporte: " + ex.Message,
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que hayan hecho clic en la columna del botón y no en el encabezado
            if (e.RowIndex >= 0 && dgvReporte.Columns[e.ColumnIndex].Name == "btnVerDetalles")
            {
                // Capturamos el nombre de la categoría de la fila seleccionada
                string categoriaSelec = dgvReporte.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                // TODO: Acá vamos a llamar a la nueva ventana pasándole estos 3 datos
                FormDetalleCategoria form = new FormDetalleCategoria(categoriaSelec, desde, hasta);
                form.ShowDialog();
            }
        }

       
    }
}

