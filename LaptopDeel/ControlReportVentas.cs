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
    public partial class ControlReportVentas : UserControl
    {      
            public ControlReportVentas()
            {
                InitializeComponent();
            }

    

            private void btnGenerar_Click(object sender, EventArgs e)
            {
                // 1. Capturamos las fechas de los DateTimePicker
                // Usamos .Date para ignorar la hora y tomar solo el día exacto
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
                    // 3. Instanciamos el DAO y llamamos al método (Asegurate de usar el nombre correcto de tu DAO)
                    VentasDAO dao = new VentasDAO();
                    DataTable datosReporte = dao.ObtenerVentasPorCategoria(fechaDesde, fechaHasta);

                    // 4. Llenamos la grilla con los resultados
                    dgvReporte.DataSource = datosReporte;

                // Verificamos que no exista ya el botón para no duplicarlo si busca 2 veces
                if (dgvReporte.Columns["btnVerDetalles"] == null)
                {
                    DataGridViewButtonColumn colBoton = new DataGridViewButtonColumn();
                    colBoton.Name = "btnVerDetalles";
                    colBoton.HeaderText = "Acciones";
                    colBoton.Text = "Ver Facturas";
                    colBoton.UseColumnTextForButtonValue = true; // Hace que el texto se vea en el botón
                    dgvReporte.Columns.Add(colBoton);
                }
                // 5. Le damos formato de plata ($) a la columna de ingresos (si la tabla trajo datos)
                if (datosReporte.Rows.Count > 0)
                    {
                        // El nombre "Ingreso_Total" debe coincidir con el alias que pusimos en el SP de MariaDB
                        if (dgvReporte.Columns["Ingreso_Total"] != null)
                        {
                            dgvReporte.Columns["Ingreso_Total"].DefaultCellStyle.Format = "C2";
                        }
                    }
                    else
                    {
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

