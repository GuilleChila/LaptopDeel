using System;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class DashboardDAO
    {
        public KpiDashboardDTO ObtenerKPIsGerencia()
        {
            var dto = new KpiDashboardDTO();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_Dashboard_ObtenerKPIsGerencia", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    conexion.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dto.ClientesActivos = reader.IsDBNull(reader.GetOrdinal("ClientesActivos")) ? 0 : reader.GetInt32("ClientesActivos");
                            dto.TotalVentasMesActual = reader.IsDBNull(reader.GetOrdinal("TotalVentasMesActual")) ? 0m : reader.GetDecimal("TotalVentasMesActual");
                            dto.PorcentajeVariacionVentas = reader.IsDBNull(reader.GetOrdinal("PorcentajeVariacionVentas")) ? 0m : reader.GetDecimal("PorcentajeVariacionVentas");
                            dto.ModelosStockCritico = reader.IsDBNull(reader.GetOrdinal("ModelosStockCritico")) ? 0 : reader.GetInt32("ModelosStockCritico");
                        }
                    }
                }
            }

            return dto;
        }
    }
}
