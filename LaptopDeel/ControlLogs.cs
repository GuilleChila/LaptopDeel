using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Krypton.Toolkit;
using LaptopDeel.Datos;
using LaptopDeel.Entidades;

namespace LaptopDeel
{
    public partial class ControlLogs : UserControl
    {
        private readonly SesionDAO _sesionDao = new SesionDAO();
        private List<LogSesionDTO> _listaSesionesCache = new List<LogSesionDTO>();
        private System.Windows.Forms.Timer _timerAutoRefresh = new System.Windows.Forms.Timer();

        public ControlLogs()
        {
            InitializeComponent();
            ConfigurarGrilla();
            ConfigurarTimer();
        }

        private void ConfigurarGrilla()
        {
            dgvSesiones.Columns.Clear();

            dgvSesiones.Columns.Add("colIdSesion", "Id sesion");
            dgvSesiones.Columns["colIdSesion"].DataPropertyName = "IdSesion";
            dgvSesiones.Columns["colIdSesion"].Width = 100;

            dgvSesiones.Columns.Add("colUsuario", "Usuario");
            dgvSesiones.Columns["colUsuario"].DataPropertyName = "Usuario";

            dgvSesiones.Columns.Add("colUltimaActividad", "Ultima actividad");
            dgvSesiones.Columns["colUltimaActividad"].DataPropertyName = "UltimaActividad";
            dgvSesiones.Columns["colUltimaActividad"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            dgvSesiones.Columns["colUltimaActividad"].Width = 200;

            dgvSesiones.Columns.Add("colTiempoActivo", "Tiempo activo");
            dgvSesiones.Columns["colTiempoActivo"].DataPropertyName = "TiempoActivo";
            dgvSesiones.Columns["colTiempoActivo"].Width = 160;

            dgvSesiones.AutoGenerateColumns = false;
        }

        private void ConfigurarTimer()
        {
            // Auto-refresco cada 5 segundos para mantener actualizado el tiempo directo del motor
            _timerAutoRefresh.Interval = 5000;
            _timerAutoRefresh.Tick += (s, e) => CargarSesionesActivas();
        }

        private void ControlLogs_Load(object? sender, EventArgs e)
        {
            CargarSesionesActivas();
            _timerAutoRefresh.Start();
        }

        public void CargarSesionesActivas()
        {
            try
            {
                _listaSesionesCache = _sesionDao.ObtenerSesionesActivas();
                CalcularKPIs();
                AplicarFiltro();
            }
            catch (Exception ex)
            {
                _timerAutoRefresh.Stop();
                KryptonMessageBox.Show($"Error al consultar el monitoreo de sesiones: {ex.Message}", "Error",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void CalcularKPIs()
        {
            lblValActivos.Text = _listaSesionesCache.Count.ToString();
            lblValIniciosHoy.Text = _listaSesionesCache.Count.ToString();

            if (_listaSesionesCache.Count > 0)
            {
                // Cálculo del promedio de segundos
                double totalSegundos = 0;
                foreach (var s in _listaSesionesCache)
                {
                    if (TimeSpan.TryParse(s.TiempoActivo, out TimeSpan ts))
                    {
                        totalSegundos += ts.TotalSeconds;
                    }
                }
                TimeSpan promedio = TimeSpan.FromSeconds(totalSegundos / _listaSesionesCache.Count);
                lblValPromedio.Text = promedio.ToString(@"hh\:mm\:ss");
            }
            else
            {
                lblValPromedio.Text = "00:00:00";
            }
        }

        private void AplicarFiltro()
        {
            string busqueda = txtBuscar.Text.Trim().ToLower();

            var resultado = _listaSesionesCache.Where(s =>
                string.IsNullOrEmpty(busqueda) ||
                (s.Usuario != null && s.Usuario.ToLower().Contains(busqueda)) ||
                s.IdSesion.ToString().Contains(busqueda)
            ).ToList();

            dgvSesiones.DataSource = null;
            dgvSesiones.DataSource = resultado;
        }

        private void txtBuscar_TextChanged(object? sender, EventArgs e)
        {
            AplicarFiltro();
        }

        private void btnRefrescar_Click(object? sender, EventArgs e)
        {
            CargarSesionesActivas();
        }
    }
}