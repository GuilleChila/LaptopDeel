using System;
using System.Collections.Generic;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class VentasDAO
    {
        /// <summary>
        /// Consulta el historial de ventas filtrado y mapeado a objetos VentaHistorialDTO.
        /// </summary>
        /// <param name="idUsuario">ID del vendedor si es rol Vendedor (null para Gerente/Admin)</param>
        /// <param name="fechaInicio">Fecha inicial opcional</param>
        /// <param name="fechaFin">Fecha final opcional</param>
        /// <returns>Lista fuertemente tipada de VentaHistorialDTO</returns>
        public List<VentaHistorialDTO> ObtenerHistorialVentas(int? idUsuario = null, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            var historial = new List<VentaHistorialDTO>();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        v.id_venta,
                        v.fecha_hora AS FechaHora,
                        CONCAT('0001-', LPAD(v.id_venta, 8, '0')) AS NumeroFactura,
                        CONCAT(u.nombre, ' ', u.apellido) AS NombreVendedor,
                        c.dni AS DniCliente,
                        c.nombre_completo AS NombreCliente,
                        v.metodo_pago AS MedioPago,
                        GROUP_CONCAT(CONCAT(n.marca, ' ', n.modelo, ' (x', dv.cantidad, ')') SEPARATOR ', ') AS ProductosComprados,
                        v.monto_total AS PrecioTotal,
                        v.id_usuario
                    FROM ventas v
                    INNER JOIN usuarios u ON v.id_usuario = u.id_usuario
                    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                    INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
                    INNER JOIN notebooks n ON dv.id_notebook = n.id_notebook
                    WHERE v.eliminado = FALSE";

                if (idUsuario.HasValue)
                {
                    query += " AND v.id_usuario = @id_usuario";
                }

                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query += " AND DATE(v.fecha_hora) BETWEEN @fechaInicio AND @fechaFin";
                }

                query += " GROUP BY v.id_venta ORDER BY v.fecha_hora DESC;";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    if (idUsuario.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario.Value);
                    }
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Value.ToString("yyyy-MM-dd"));
                    }

                    conexion.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var dto = new VentaHistorialDTO
                            {
                                IdVenta = reader.GetInt32("id_venta"),
                                FechaHora = reader.GetDateTime("FechaHora"),
                                NumeroFactura = reader.IsDBNull(reader.GetOrdinal("NumeroFactura")) ? string.Empty : reader.GetString("NumeroFactura"),
                                NombreVendedor = reader.IsDBNull(reader.GetOrdinal("NombreVendedor")) ? string.Empty : reader.GetString("NombreVendedor"),
                                DniCliente = reader.IsDBNull(reader.GetOrdinal("DniCliente")) ? string.Empty : reader.GetString("DniCliente"),
                                NombreCliente = reader.IsDBNull(reader.GetOrdinal("NombreCliente")) ? string.Empty : reader.GetString("NombreCliente"),
                                MedioPago = reader.IsDBNull(reader.GetOrdinal("MedioPago")) ? "Efectivo" : reader.GetString("MedioPago"),
                                ProductosComprados = reader.IsDBNull(reader.GetOrdinal("ProductosComprados")) ? string.Empty : reader.GetString("ProductosComprados"),
                                PrecioTotal = reader.IsDBNull(reader.GetOrdinal("PrecioTotal")) ? 0 : Convert.ToDecimal(reader["PrecioTotal"]),
                                IdUsuario = reader.GetInt32("id_usuario")
                            };

                            historial.Add(dto);
                        }
                    }
                }
            }

            return historial;
        }

        /// <summary>
        /// Sobrecarga que retorna un DataTable si se requiere para componentes DataGridView de enlace directo.
        /// </summary>
        public DataTable ObtenerHistorialVentasTabla(int? idUsuario = null, DateTime? fechaInicio = null, DateTime? fechaFin = null)
        {
            DataTable dt = new DataTable();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        v.id_venta,
                        v.fecha_hora AS FechaHora,
                        CONCAT('0001-', LPAD(v.id_venta, 8, '0')) AS NumeroFactura,
                        CONCAT(u.nombre, ' ', u.apellido) AS NombreVendedor,
                        c.dni AS DniCliente,
                        c.nombre_completo AS NombreCliente,
                        v.metodo_pago AS MedioPago,
                        GROUP_CONCAT(CONCAT(n.marca, ' ', n.modelo, ' (x', dv.cantidad, ')') SEPARATOR ', ') AS ProductosComprados,
                        v.monto_total AS PrecioTotal,
                        v.id_usuario
                    FROM ventas v
                    INNER JOIN usuarios u ON v.id_usuario = u.id_usuario
                    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                    INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
                    INNER JOIN notebooks n ON dv.id_notebook = n.id_notebook
                    WHERE v.eliminado = FALSE";

                if (idUsuario.HasValue)
                {
                    query += " AND v.id_usuario = @id_usuario";
                }

                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query += " AND DATE(v.fecha_hora) BETWEEN @fechaInicio AND @fechaFin";
                }

                query += " GROUP BY v.id_venta ORDER BY v.fecha_hora DESC;";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    if (idUsuario.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@id_usuario", idUsuario.Value);
                    }
                    if (fechaInicio.HasValue && fechaFin.HasValue)
                    {
                        cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.Value.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@fechaFin", fechaFin.Value.ToString("yyyy-MM-dd"));
                    }

                    conexion.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        /// <summary>
        /// Obtiene los datos detallados de una venta específica para reimpresión de comprobante o vista detallada.
        /// </summary>
        public DataTable ObtenerDetalleVentaPorId(int idVenta)
        {
            DataTable dt = new DataTable();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        dv.id_notebook,
                        n.marca,
                        n.modelo,
                        dv.cantidad,
                        dv.precio_unitario,
                        dv.subtotal
                    FROM detalle_ventas dv
                    INNER JOIN notebooks n ON dv.id_notebook = n.id_notebook
                    WHERE dv.id_venta = @id_venta AND dv.eliminado = FALSE;";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@id_venta", idVenta);
                    conexion.Open();

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public DataTable ObtenerVentasPorCategoria(DateTime desde, DateTime hasta)
        {
            DataTable tablaResultados = new DataTable();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_ReporteVentasPorCategoria", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_fecha_desde", desde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p_fecha_hasta", hasta.ToString("yyyy-MM-dd"));

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tablaResultados);
                    }
                }
            }
            return tablaResultados;
        }

        public DataTable ObtenerDetalleFacturasPorCategoria(string categoria, DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_DetalleFacturasPorCategoria", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_categoria", categoria);
                    cmd.Parameters.AddWithValue("@p_fecha_desde", desde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p_fecha_hasta", hasta.ToString("yyyy-MM-dd"));

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerTop3MasVendidas(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("sp_Top3NotebooksPorFecha", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@p_fecha_desde", desde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@p_fecha_hasta", hasta.ToString("yyyy-MM-dd"));

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public DataTable ObtenerVentasAnuales()
        {
            DataTable tabla = new DataTable();
            using (var conexion = ConexionBD.ObtenerConexion())
            {
                using (var cmd = new MySqlCommand("SP_ObtenerVentasAnuales", conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        /// <summary>
        /// Consulta los 5 clientes con mayor volumen de compra de laptops en el rango de fechas indicado.
        /// </summary>
        /// <param name="desde">Fecha inicial del rango</param>
        /// <param name="hasta">Fecha final del rango</param>
        /// <returns>DataTable con el ranking de clientes, laptops compradas y total invertido</returns>
        public DataTable ObtenerTop5ClientesMasLaptops(DateTime desde, DateTime hasta)
        {
            DataTable tabla = new DataTable();

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                string query = @"
                    SELECT 
                        c.nombre_completo AS Cliente,
                        SUM(dv.cantidad) AS Laptops_Compradas,
                        SUM(dv.subtotal) AS Total_Gastado
                    FROM ventas v
                    INNER JOIN clientes c ON v.id_cliente = c.id_cliente
                    INNER JOIN detalle_ventas dv ON v.id_venta = dv.id_venta
                    WHERE v.eliminado = FALSE 
                      AND DATE(v.fecha_hora) BETWEEN @fecha_desde AND @fecha_hasta
                    GROUP BY c.id_cliente, c.nombre_completo
                    ORDER BY Laptops_Compradas DESC, Total_Gastado DESC
                    LIMIT 5;";

                using (var cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@fecha_desde", desde.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@fecha_hasta", hasta.ToString("yyyy-MM-dd"));

                    conexion.Open();
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }

            return tabla;
        }
    }
}