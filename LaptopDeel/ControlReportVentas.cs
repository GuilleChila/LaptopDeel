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
            HabilitarDoubleBuffering();
        }

        private void HabilitarDoubleBuffering()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                           ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        #region EVENTO PRINCIPAL (ARRANQUE)
        private void ControlReporteVentas_Load(object sender, EventArgs e)
        {
            ConfigurarFiltros();
            ConfigurarGraficoPrincipal();
            ConfigurarGrillas();

            // Rango predeterminado (Desde 1 de Enero del año actual hasta Hoy)
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Now;

            // Cargar reportes iniciales
            btnGenerar.PerformClick();
            CargarDatosAnuales();
        }
        #endregion

        #region 1. Configuración de Grillas
        private void ConfigurarGrillas()
        {
            // Grilla de Categorías
            dgvReporteGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteGrilla.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);

            // Grilla Top 5 Clientes
            dgvTop5Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTop5Clientes.DefaultCellStyle.Padding = new Padding(5, 0, 5, 0);
        }

        private void dgvReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvReporteGrilla.Columns[e.ColumnIndex].Name == "btnVerDetalles")
            {
                string categoriaSelec = dgvReporteGrilla.Rows[e.RowIndex].Cells["Categoria"].Value?.ToString() ?? "";
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                FormDetalleCategoria form = new FormDetalleCategoria(categoriaSelec, desde, hasta);
                form.ShowDialog();
            }
        }
        #endregion

        #region 2. Gráficos de Ventas por Categoría y Top 3
        private void ConfigurarGraficoPrincipal()
        {
            chartVentas = new Chart();
            chartVentas.Dock = DockStyle.Fill;
            panelGrafico.Controls.Add(chartVentas);

            if (chartVentas.ChartAreas.Count == 0) chartVentas.ChartAreas.Add(new ChartArea());
            if (chartVentas.Series.Count == 0) chartVentas.Series.Add(new Series("Ventas"));

            ChartArea area = chartVentas.ChartAreas[0];
            Series serie = chartVentas.Series[0];

            chartVentas.BackColor = Color.White;
            area.BackColor = Color.White;
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            area.AxisX.LineColor = Color.LightGray;
            area.AxisY.LineColor = Color.LightGray;
            area.AxisX.LabelStyle.Font = new Font("Segoe UI", 9.5f);
            area.AxisY.LabelStyle.Font = new Font("Segoe UI", 9.5f);
            area.AxisX.LabelStyle.ForeColor = Color.FromArgb(64, 64, 64);
            area.AxisY.LabelStyle.ForeColor = Color.FromArgb(64, 64, 64);

            serie.Color = Color.FromArgb(37, 99, 235); // Royal Blue Modern Slate
            serie["PointWidth"] = "0.55";
            serie.Font = new Font("Segoe UI", 9f, FontStyle.Bold);
            serie.LabelForeColor = Color.FromArgb(64, 64, 64);
        }

        private void CargarTop3EnPanel(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                VentasDAO ventaDao = new VentasDAO();
                DataTable dtTop3 = ventaDao.ObtenerTop3MasVendidas(fechaDesde, fechaHasta);

                Top3Vendidas.Controls.Clear();

                if (dtTop3.Rows.Count > 0)
                {
                    Chart chartTop3 = new Chart { Dock = DockStyle.Fill };
                    chartTop3.ChartAreas.Add(new ChartArea());

                    Legend leyenda = new Legend("LeyendaTop3")
                    {
                        Docking = Docking.Right,
                        Alignment = StringAlignment.Center,
                        Font = new Font("Segoe UI", 10f, FontStyle.Regular)
                    };
                    chartTop3.Legends.Add(leyenda);

                    Series serie = new Series("Top3")
                    {
                        ChartType = SeriesChartType.Pie,
                        IsValueShownAsLabel = true,
                        Label = "#PERCENT",
                        LegendText = "#VALX - #VAL uds."
                    };
                    chartTop3.Series.Add(serie);

                    Title titulo = new Title("Top 3 Notebooks Más Vendidas")
                    {
                        Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                        ForeColor = Color.FromArgb(30, 41, 59)
                    };
                    chartTop3.Titles.Add(titulo);

                    chartTop3.DataSource = dtTop3;
                    chartTop3.Series["Top3"].XValueMember = "Modelo";
                    chartTop3.Series["Top3"].YValueMembers = "Total_Vendidas";
                    chartTop3.DataBind();

                    Top3Vendidas.Controls.Add(chartTop3);
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar el gráfico Top 3: " + ex.Message, "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        #endregion

        #region 3. Cargar Top 5 Clientes (NUEVO REPORTE)
        private void CargarTop5Clientes(DateTime fechaDesde, DateTime fechaHasta)
        {
            try
            {
                VentasDAO dao = new VentasDAO();
                DataTable dtTop5 = dao.ObtenerTop5ClientesMasLaptops(fechaDesde, fechaHasta);

                dgvTop5Clientes.DataSource = null;
                dgvTop5Clientes.Columns.Clear();

                if (dtTop5.Rows.Count > 0)
                {
                    dgvTop5Clientes.DataSource = dtTop5;

                    // Formateo de encabezados y moneda
                    if (dgvTop5Clientes.Columns["Cliente"] != null)
                        dgvTop5Clientes.Columns["Cliente"].HeaderText = "Cliente / Razón Social";

                    if (dgvTop5Clientes.Columns["Laptops_Compradas"] != null)
                    {
                        dgvTop5Clientes.Columns["Laptops_Compradas"].HeaderText = "Laptops Compradas (Uds.)";
                        dgvTop5Clientes.Columns["Laptops_Compradas"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }

                    if (dgvTop5Clientes.Columns["Total_Gastado"] != null)
                    {
                        dgvTop5Clientes.Columns["Total_Gastado"].HeaderText = "Total Invertido ($)";
                        dgvTop5Clientes.Columns["Total_Gastado"].DefaultCellStyle.Format = "C2";
                        dgvTop5Clientes.Columns["Total_Gastado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar el reporte de Top 5 Clientes: " + ex.Message,
                    "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        #endregion

        #region 4. Filtro por Fechas
        private void ConfigurarFiltros()
        {
            Label lblTituloFiltro = new Label
            {
                Text = "Filtrar Tablero Gerencial por Fechas",
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                AutoSize = true,
                Location = new Point(15, 12)
            };

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
                    Title tituloBarras = new Title("Ingresos Totales por Categoría")
                    {
                        Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                        ForeColor = Color.FromArgb(30, 41, 59)
                    };
                    chartVentas.Titles.Add(tituloBarras);

                    chartVentas.DataSource = datosReporte;
                    chartVentas.Series[0].XValueMember = "Categoria";
                    chartVentas.Series[0].YValueMembers = "Ingreso_Total";
                    chartVentas.DataBind();
                    chartVentas.Invalidate();

                    if (dgvReporteGrilla.Columns["btnVerDetalles"] == null)
                    {
                        DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn
                        {
                            Name = "btnVerDetalles",
                            HeaderText = "Acciones",
                            Text = "Ver Facturas",
                            UseColumnTextForButtonValue = true
                        };
                        dgvReporteGrilla.Columns.Add(colBoton);
                    }

                    if (dgvReporteGrilla.Columns["Ingreso_Total"] != null)
                    {
                        dgvReporteGrilla.Columns["Ingreso_Total"].DefaultCellStyle.Format = "C2";
                        dgvReporteGrilla.Columns["Ingreso_Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
                else
                {
                    dgvReporteGrilla.DataSource = null;
                    dgvReporteGrilla.Columns.Clear();
                    chartVentas.Series[0].Points.Clear();
                    chartVentas.Titles.Clear();
                }

                // Cargar reportes complementarios
                CargarTop3EnPanel(fechaDesde, fechaHasta);
                CargarTop5Clientes(fechaDesde, fechaHasta);
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al generar el reporte: " + ex.Message,
                  "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        #endregion

        #region 5. Gráfico Anual
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

            Chart chartAnual = new Chart { Dock = DockStyle.Fill };
            chartAnual.ChartAreas.Add(new ChartArea());

            Series serie = new Series("Anual")
            {
                ChartType = SeriesChartType.Column,
                IsValueShownAsLabel = true,
                Color = Color.FromArgb(37, 99, 235)
            };

            Title titulo = new Title
            {
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59)
            };

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

        #region 6. Exportación Consolidada a Excel
        private void exportarReporte_Click(object sender, EventArgs e)
        {
            if (dgvReporteGrilla.Rows.Count == 0 || dgvReporteGrilla.DataSource == null)
            {
                KryptonMessageBox.Show("No hay datos para exportar.", "Atención",
                  KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Excel Workbook|*.xlsx",
                Title = "Guardar Reporte Gerencial Completo",
                FileName = "Dashboard_Ventas_" + DateTime.Now.ToString("ddMMyyyy") + ".xlsx"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Reporte Gerencial");

                        // 1. Gráfico de Barras (Categorías) en Fila 2
                        using (MemoryStream msBarras = new MemoryStream())
                        {
                            chartVentas.SaveImage(msBarras, ChartImageFormat.Png);
                            msBarras.Position = 0;
                            var picBarras = worksheet.AddPicture(msBarras);
                            picBarras.MoveTo(worksheet.Cell(2, 2));
                            picBarras.Scale(0.8);
                        }

                        // 2. Gráfico de Torta (Top 3) en Fila 25
                        if (Top3Vendidas.Controls.Count > 0 && Top3Vendidas.Controls[0] is Chart chartTop3)
                        {
                            using (MemoryStream msPie = new MemoryStream())
                            {
                                chartTop3.SaveImage(msPie, ChartImageFormat.Png);
                                msPie.Position = 0;
                                var picPie = worksheet.AddPicture(msPie);
                                picPie.MoveTo(worksheet.Cell(25, 2));
                                picPie.Scale(0.8);
                            }
                        }

                        // 3. Tabla Top 5 Clientes en Fila 48
                        worksheet.Cell(48, 2).Value = "TOP 5 CLIENTES CON MÁS LAPTOPS COMPRADAS";
                        worksheet.Cell(48, 2).Style.Font.Bold = true;
                        worksheet.Cell(48, 2).Style.Font.FontSize = 12;

                        if (dgvTop5Clientes.DataSource is DataTable dtTop5)
                        {
                            worksheet.Cell(50, 2).InsertTable(dtTop5);
                        }

                        // 4. Gráfico Anual en Fila 62
                        if (panelGraficoAnual.Controls.Count > 0 && panelGraficoAnual.Controls[0] is Chart chartAnualExport)
                        {
                            using (MemoryStream msAnual = new MemoryStream())
                            {
                                chartAnualExport.SaveImage(msAnual, ChartImageFormat.Png);
                                msAnual.Position = 0;
                                var picAnual = worksheet.AddPicture(msAnual);
                                picAnual.MoveTo(worksheet.Cell(62, 2));
                                picAnual.Scale(0.8);
                            }
                        }

                        workbook.SaveAs(sfd.FileName);

                        KryptonMessageBox.Show("¡El reporte consolidado se exportó correctamente!", "Éxito",
                            KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show("Error al exportar a Excel: " + ex.Message,
                        "Error", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}