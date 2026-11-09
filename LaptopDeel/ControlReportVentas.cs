using ClosedXML.Excel;
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
using ClosedXML.Excel;
using System.IO;

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
        // Variables globales para el gráfico anual
        private DataTable dtVentasAnuales;
        private bool mostrandoCantidades = true; // Empieza en true por defecto


        private void ControlReporteVentas_Load(object sender, EventArgs e)
        {
            Label lblTituloFiltro = new Label();
            lblTituloFiltro.Text = "Filtrar reportes por fechas";
            lblTituloFiltro.Font = new Font("Segoe UI", 11f, FontStyle.Bold);
            lblTituloFiltro.ForeColor = Color.FromArgb(0, 102, 204); // El azul del Dashboard
            lblTituloFiltro.AutoSize = true;
            lblTituloFiltro.Location = new Point(15, 15); // Jugá con X e Y para ubicarlo donde más te guste

            // Lo agregamos físicamente a tu panel de filtros
            panelFiltro.Controls.Add(lblTituloFiltro);
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
            CargarTop3EnPanel(dtpDesde.Value, dtpHasta.Value);

            dgvReporteGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //Reporte Anual
            CargarDatosAnuales();

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
                    // --- LA SOLUCIÓN: Limpiar columnas antes de cargar los datos nuevos ---
                    dgvReporteGrilla.DataSource = null;
                    dgvReporteGrilla.Columns.Clear();
                    dgvReporteGrilla.DataSource = datosReporte;

                    // Título integrado para el gráfico de barras
                    chartVentas.Titles.Clear();
                    System.Windows.Forms.DataVisualization.Charting.Title tituloBarras = new System.Windows.Forms.DataVisualization.Charting.Title("Ingresos Totales por Categoría");
                    tituloBarras.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                    tituloBarras.ForeColor = Color.FromArgb(0, 102, 204);
                    chartVentas.Titles.Add(tituloBarras);

                    chartVentas.DataSource = null;
                    chartVentas.Series[0].Points.Clear();

                    // Actualizamos el gráfico
                    chartVentas.DataSource = datosReporte;
                    chartVentas.Series[0].XValueMember = "Categoria";
                    chartVentas.Series[0].YValueMembers = "Ingreso_Total";
                    chartVentas.DataBind();
                    chartVentas.Invalidate();

                    // Agregamos el botón al final
                    if (dgvReporteGrilla.Columns["btnVerDetalles"] == null)
                    {
                        DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                        colBoton.Name = "btnVerDetalles";
                        colBoton.HeaderText = "Acciones";
                        colBoton.Text = "Ver Facturas";
                        colBoton.UseColumnTextForButtonValue = true;
                        dgvReporteGrilla.Columns.Add(colBoton);
                    }

                    // Aplicamos el formato de moneda
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
                    dgvReporteGrilla.Columns.Clear(); // Limpiamos también acá por si quedó el botón
                    chartVentas.Series[0].Points.Clear();
                    chartVentas.Titles.Clear();
                }

                // Llamamos al Top 3 una sola vez, afuera del if/else
                CargarTop3EnPanel(fechaDesde, fechaHasta);
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
            if (e.RowIndex >= 0 && dgvReporteGrilla.Columns[e.ColumnIndex].Name == "btnVerDetalles")
            {
                // Capturamos el nombre de la categoría de la fila seleccionada
                string categoriaSelec = dgvReporteGrilla.Rows[e.RowIndex].Cells["Categoria"].Value.ToString();
                DateTime desde = dtpDesde.Value.Date;
                DateTime hasta = dtpHasta.Value.Date;

                // TODO: Acá vamos a llamar a la nueva ventana pasándole estos 3 datos
                FormDetalleCategoria form = new FormDetalleCategoria(categoriaSelec, desde, hasta);
                form.ShowDialog();
            }
        }

        private void CargarTop3EnPanel(DateTime fechaDesde, DateTime fechaHasta) // <-- ACÁ ESTÁ EL CAMBIO
        {

            try
            {
                VentasDAO ventaDao = new VentasDAO();
                DataTable dtTop3 = ventaDao.ObtenerTop3MasVendidas(fechaDesde, fechaHasta);

                // Validamos que haya datos antes de dibujar la torta
                if (dtTop3.Rows.Count > 0)
                {
                    Chart chartTop3 = new Chart();
                    chartTop3.Dock = DockStyle.Fill;

                    ChartArea chartArea = new ChartArea();
                    chartTop3.ChartAreas.Add(chartArea);

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
                    // Si no hay datos, limpiamos el panel para que no quede el gráfico viejo
                    Top3Vendidas.Controls.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el gráfico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Necesario para manejar las imágenes en memoria

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

                        // --- 1. GRÁFICO DE BARRAS (Arriba de todo) ---
                        using (MemoryStream msBarras = new MemoryStream())
                        {
                            chartVentas.SaveImage(msBarras, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                            msBarras.Position = 0;
                            var picBarras = worksheet.AddPicture(msBarras);
                            // Lo ubicamos en la Fila 2, Columna 2 (B2)
                            picBarras.MoveTo(worksheet.Cell(2, 2));
                            picBarras.Scale(0.8);
                        }

                        // --- 2. GRILLA DE DATOS (En el medio) ---
                        int filaInicioTabla = 25; // Empezamos en la fila 25 para no tapar el gráfico
                        int colExcel = 2; // Empezamos en la columna B para que quede alineado

                        // Imprimimos los Títulos
                        for (int i = 0; i < dgvReporteGrilla.Columns.Count; i++)
                        {
                            if (dgvReporteGrilla.Columns[i].Name != "btnVerDetalles")
                            {
                                worksheet.Cell(filaInicioTabla, colExcel).Value = dgvReporteGrilla.Columns[i].HeaderText;
                                worksheet.Cell(filaInicioTabla, colExcel).Style.Font.Bold = true;
                                worksheet.Cell(filaInicioTabla, colExcel).Style.Fill.BackgroundColor = XLColor.FromArgb(0, 102, 204);
                                worksheet.Cell(filaInicioTabla, colExcel).Style.Font.FontColor = XLColor.White;
                                colExcel++;
                            }
                        }

                        // Imprimimos las Filas de datos
                        for (int i = 0; i < dgvReporteGrilla.Rows.Count; i++)
                        {
                            colExcel = 2;
                            for (int j = 0; j < dgvReporteGrilla.Columns.Count; j++)
                            {
                                if (dgvReporteGrilla.Columns[j].Name != "btnVerDetalles")
                                {
                                    var valorCelda = dgvReporteGrilla.Rows[i].Cells[j].Value;
                                    worksheet.Cell(filaInicioTabla + i + 1, colExcel).Value = valorCelda != null ? valorCelda.ToString() : "";
                                    colExcel++;
                                }
                            }
                        }
                        worksheet.Columns().AdjustToContents();

                        // --- 3. GRÁFICO DE TORTA (Abajo de todo) ---
                        // Calculamos automáticamente en qué fila ponerlo para que quede debajo de la tabla
                        int filaInicioPie = filaInicioTabla + dgvReporteGrilla.Rows.Count + 4;

                        if (Top3Vendidas.Controls.Count > 0 && Top3Vendidas.Controls[0] is System.Windows.Forms.DataVisualization.Charting.Chart chartTop3)
                        {
                            using (MemoryStream msPie = new MemoryStream())
                            {
                                chartTop3.SaveImage(msPie, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
                                msPie.Position = 0;
                                var picPie = worksheet.AddPicture(msPie);
                                // Lo ubicamos dinámicamente debajo de la tabla, alineado en la columna B
                                picPie.MoveTo(worksheet.Cell(filaInicioPie, 2));
                                picPie.Scale(0.8);
                            }
                        }

                        workbook.SaveAs(sfd.FileName);

                        KryptonMessageBox.Show("¡El Dashboard se organizó y exportó correctamente!", "Éxito",
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

        // 1. EL MÉTODO QUE CREA EL GRÁFICO
        private void GenerarGraficoAnual()
        {
            // Limpiamos tu nuevo panel por si el gerente apretó el botón de cambiar vista
            panelGraficoAnual.Controls.Clear();

            // Creamos el control Chart desde cero
            Chart chartAnual = new Chart();
            chartAnual.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chartAnual.ChartAreas.Add(chartArea);

            Series serie = new Series("Anual");
            serie.ChartType = SeriesChartType.Column; // Gráfico de columnas (verticales)
            serie.IsValueShownAsLabel = true;

            System.Windows.Forms.DataVisualization.Charting.Title titulo = new System.Windows.Forms.DataVisualization.Charting.Title();
            titulo.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            titulo.ForeColor = Color.FromArgb(0, 102, 204);

            // Evaluamos qué mostrar según el botón
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

            // Inyectamos el gráfico recién creado en tu panel nuevo
            panelGraficoAnual.Controls.Add(chartAnual);
        }
        private void CargarDatosAnuales()
        {
            try
            {
                VentasDAO dao = new VentasDAO();
                dtVentasAnuales = dao.ObtenerVentasAnuales();

                if (dtVentasAnuales.Rows.Count > 0)
                {
                    GenerarGraficoAnual(); // <-- ACÁ LLAMAMOS AL NUEVO NOMBRE
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Error al cargar ventas anuales: " + ex.Message);
            }
        }
   

        private void btnAlternarAnual_Click_1(object sender, EventArgs e)
        {
            mostrandoCantidades = !mostrandoCantidades;

            if (dtVentasAnuales != null && dtVentasAnuales.Rows.Count > 0)
            {
                GenerarGraficoAnual(); // <-- ACÁ LLAMAMOS AL NUEVO NOMBRE
            }
        }
    }
}

