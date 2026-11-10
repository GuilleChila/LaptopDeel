using ClosedXML.Excel;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace LaptopDeel
{
    public partial class ControlReportVentas : UserControl
    {
        // --- VARIABLES GLOBALES ---
        private Chart chartVentas;
        private DataTable dtVentasAnuales;
        private bool mostrandoCantidades = true;

        public ControlReportVentas()
        {
            InitializeComponent();
        }

        #region EVENTO PRINCIPAL (ARRANQUE)
        private void ControlReporteVentas_Load(object sender, EventArgs e)
        {
            // 1. Ejecutamos las configuraciones visuales limpias
            ConfigurarFiltros();
            ConfigurarGraficoPrincipal();
            ConfigurarGrilla();

            // 2. Establecemos las fechas por defecto (Desde 1 de Enero hasta Hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Now;

            // 3. Disparamos los clics automáticos para cargar todo
            btnGenerar.PerformClick();
            CargarDatosAnuales();
        }
        #endregion

        #region 1. panelGrafico
        private void ConfigurarGraficoPrincipal()
        {
            chartVentas = new Chart();
            chartVentas.Dock = DockStyle.Fill;
            panelGrafico.Controls.Add(chartVentas);

            if (chartVentas.ChartAreas.Count == 0) chartVentas.ChartAreas.Add(new ChartArea());
            if (chartVentas.Series.Count == 0) chartVentas.Series.Add(new Series("Ventas"));

            ChartArea area = chartVentas.ChartAreas[0];
            Series serie = chartVentas.Series[0];

            // Limpieza del fondo y líneas
            chartVentas.BackColor = Color.White;
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            // Estilo de los ejes
            area.AxisX.LineColor = Color.LightGray;
            area.AxisY.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9.5f);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9.5f);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(64, 64, 64);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(64, 64, 64);

            // Estilo de las Barras y Etiquetas
            serie.Color = Color.FromArgb(52, 152, 219);
            serie["PointWidth"] = "0.55";
            serie.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            serie.LabelForeColor = Color.FromArgb(64, 64, 64);
        }
        #endregion

        #region 2. dgvReporteGrilla
        private void ConfigurarGrilla()
        {
            dgvReporteGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Margen interno pedido para que el texto de las celdas respire
            dgvReporteGrilla.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReporteGrilla.Columns[e.ColumnIndex].Name == "btnVerDetalles")
            {
                string categoriaSelec = dgvReporteGrilla.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                FormDetalleCategoria form = new FormDetalleCategoria(categoriaSelec, desde, hasta);
                form.ShowDialog();
            }
        }
        #endregion

        #region 3. Top3Vendidas Panel
        private void CargarTop3EnPanel(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                VentasDAO ventaDao = new VentasDAO();
                DataTable dtTop3 = ventaDao.ObtenerTop3MasVendidas(fechaDesde, fechaHasta);

                if (dtTop3.Rows.Count > 0)
                {
                    Chart chartTop3 = new Chart();
                    chartTop3.Dock = DockStyle.Fill;
                    chartTop3.ChartAreas.Add(new ChartArea());

                    Legend leyenda = new Legend("LeyendaTop3");
                    leyenda.Docking = Docking.Right;
                    leyenda.Alignment = StringAlignment.Center;
                    leyenda.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                    chartTop3.Legends.Add(leyenda);

                    Series serie = new Series("Top3");
                    serie.ChartType = SeriesChartType.Pie;
                    serie.IsValueShownAsLabel = true;
                    serie.Label = "#PERCENT";
                    serie.LegendText = "#VALX - #VAL uds.";
                    chartTop3.Series.Add(serie);

                    Title titulo = new Title("Top 3 Notebooks Más Vendidas");
                    titulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                    titulo.ForeColor = Color.FromArgb(0, 120, 215);
                    chartTop3.Titles.Add(titulo);

                    chartTop3.DataSource = dtTop3;
                    chartTop3.Series["Top3"].XValueMember = "Modelo";
                    chartTop3.Series["Top3"].YValueMembers = "Total_Vendidas";
                    chartTop3.DataBind();

                    Top3Vendidas.Controls.Clear();
                    Top3Vendidas.Controls.Add(chartTop3);
                }
                else
                {
                    Top3Vendidas.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region 4. panelFiltro (y Botón Generar)
        private void ConfigurarFiltros()
        {
            Label lblTituloFiltro = new Label();
            lblTituloFiltro.Text = "Filtrar reportes por fechas";
            lblTituloFiltro.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            lblTituloFiltro.ForeColor = Color.FromArgb(0, 102, 204);
            lblTituloFiltro.AutoSize = true;
            lblTituloFiltro.Location = new Point(15, 15);

            panelFiltro.Controls.Add(lblTituloFiltro);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

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

                if (datosReporte.Rows.Count > 0)
                {
                    dgvReporteGrilla.DataSource = null;
                    dgvReporteGrilla.Columns.Clear();
                    dgvReporteGrilla.DataSource = datosReporte;

                    chartVentas.Titles.Clear();
                    Title tituloBarras = new Title("Ingresos Totales por Categoría");
                    tituloBarras.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                    tituloBarras.ForeColor = Color.FromArgb(0, 102, 204);
                    chartVentas.Titles.Add(tituloBarras);

                    chartVentas.DataSource = null;
                    chartVentas.Series[0].Points.Clear();

                    chartVentas.DataSource = datosReporte;
                    chartVentas.Series[0].XValueMember = "Categoria";
                    chartVentas.Series[0].YValueMembers = "Ingreso_Total";
                    chartVentas.DataBind();
                    chartVentas.Invalidate();

                    if (dgvReporteGrilla.Columns["btnVerDetalles"] == null)
                    {
                        DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                        colBoton.Name = "btnVerDetalles";
                        colBoton.HeaderText = "Acciones";
                        colBoton.Text = "Ver Facturas";
                        colBoton.UseColumnTextForButtonValue = true;
                        dgvReporteGrilla.Columns.Add(colBoton);
                    }

                    if (dgvReporteGrilla.Columns["Ingreso_Total"] != null)
                    {
                        dgvReporteGrilla.Columns["Ingreso_Total"].DefaultCellStyle.Format = "C2";
                    }
                }
                else
                {
                    KryptonMessageBox.Show("No se encontraron ventas en el rango de fechas seleccionado.",
                      "Sin Datos", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                    dgvReporteGrilla.DataSource = null;
                    dgvReporteGrilla.Columns.Clear();
                    chartVentas.Series[0].Points.Clear();
                    chartVentas.Titles.Clear();
                }

                // Llamamos al Top 3 una sola vez
                CargarTop3EnPanel(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al generar el reporte: " + ex.Message,
                  "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        #endregion

        #region 5. panelGraficoAnual Panel
        private void CargarDatosAnuales()
        {
            try
            {
                VentasDAO dao = new VentasDAO();
                dtVentasAnuales = dao.ObtenerVentasAnuales();

                if (dtVentasAnuales.Rows.Count > 0)
                {
                    GenerarGraficoAnual();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar ventas anuales: " + ex.Message);
            }
        }

        private void GenerarGraficoAnual()
        {
            panelGraficoAnual.Controls.Clear();

            Chart chartAnual = new Chart();
            chartAnual.Dock = DockStyle.Fill;
            chartAnual.ChartAreas.Add(new ChartArea());

            Series serie = new Series("Anual");
            serie.ChartType = SeriesChartType.Column;
            serie.IsValueShownAsLabel = true;

            Title titulo = new Title();
            titulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(0, 102, 204);

            if (mostrandoCantidades)
            {
                titulo.Text = "Cantidad de Notebooks Vendidas por Mes";
                serie.YValueMembers = "Cantidad";
                serie.LabelFormat = "";
                btnAlternarAnual.Text = "Ver por Ingresos ($)";
            }
            else
            {
                titulo.Text = "Ingresos Totales por Mes";
                serie.YValueMembers = "Ingreso_Total";
                serie.LabelFormat = "C0";
                btnAlternarAnual.Text = "Ver por Cantidades (Uds.)";
            }

            chartAnual.Titles.Add(titulo);
            chartAnual.Series.Add(serie);

            chartAnual.DataSource = dtVentasAnuales;
            chartAnual.Series["Anual"].XValueMember = "Mes";
            chartAnual.DataBind();

            panelGraficoAnual.Controls.Add(chartAnual);
        }

        private void btnAlternarAnual_Click(object sender, EventArgs e)
        {
            mostrandoCantidades = !mostrandoCantidades;

            if (dtVentasAnuales != null && dtVentasAnuales.Rows.Count > 0)
            {
                GenerarGraficoAnual();
            }
        }
        #endregion

        #region 6. EXPORTACIÓN A EXCEL
        private void exportarReporte_Click(object sender, EventArgs e)
        {
            if (dgvReporteGrilla.Rows.Count == 0 || dgvReporteGrilla.DataSource == null)
            {
                KryptonMessageBox.Show("No hay datos para exportar.", "Atención",
                  KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Workbook|*.xlsx";
            sfd.Title = "Guardar Reporte Completo";
            sfd.FileName = "Dashboard_Ventas_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Reporte Gerencial");

                        // --- 1. Gráfico de Barras (Categorías) en Fila 2 ---
                        using (MemoryStream msBarras = new MemoryStream())
                        {
                            chartVentas.SaveImage(msBarras, ChartImageFormat.Png);
                            msBarras.Position = 0;
                            var picBarras = worksheet.AddPicture(msBarras);
                            picBarras.MoveTo(worksheet.Cell(2, 2));
                            picBarras.Scale(0.8);
                        }

                        // --- 2. Gráfico de Torta (Top 3) en Fila 25 ---
                        int filaInicioPie = 25; // Dejamos 23 filas de distancia para que no se pisen

                        if (Top3Vendidas.Controls.Count > 0 && Top3Vendidas.Controls[0] is Chart chartTop3)
                        {
                            using (MemoryStream msPie = new MemoryStream())
                            {
                                chartTop3.SaveImage(msPie, ChartImageFormat.Png);
                                msPie.Position = 0;
                                var picPie = worksheet.AddPicture(msPie);
                                picPie.MoveTo(worksheet.Cell(filaInicioPie, 2));
                                picPie.Scale(0.8);
                            }
                        }

                        // --- 3. Gráfico Anual en Fila 48 ---
                        int filaInicioAnual = 48; // Otras 23 filas de distancia

                        if (panelGraficoAnual.Controls.Count > 0 && panelGraficoAnual.Controls[0] is Chart chartAnualExport)
                        {
                            using (MemoryStream msAnual = new MemoryStream())
                            {
                                chartAnualExport.SaveImage(msAnual, ChartImageFormat.Png);
                                msAnual.Position = 0;
                                var picAnual = worksheet.AddPicture(msAnual);
                                picAnual.MoveTo(worksheet.Cell(filaInicioAnual, 2));
                                picAnual.Scale(0.8);
                            }
                        }

                        workbook.SaveAs(sfd.FileName);

                        KryptonMessageBox.Show("¡Los gráficos se exportaron correctamente!", "Éxito",
                            KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show("Error al exportar: " + ex.Message,
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                }
            }
        }
        #endregion


    }
}