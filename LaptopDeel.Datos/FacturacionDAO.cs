using System;
using System.Data;
using MySqlConnector;
using LaptopDeel.Entidades;

namespace LaptopDeel.Datos
{
    public class FacturacionDAO
    {
        public bool ProcesarFacturaYVenta(PedidoVentaDTO pedido, string tipoComprobante, string metodoPago,
                                         int idUsuarioOperador, out string numFacturaGenerada, out string mensajeError)
        {
            numFacturaGenerada = string.Empty;
            mensajeError = string.Empty;

            using (var conexion = ConexionBD.ObtenerConexion())
            {
                conexion.Open();
                using (var transaccion = conexion.BeginTransaction())
                {
                    try
                    {
                        int idVentaGenerada = 0;

                        // 1. Registrar Venta en la tabla 'ventas'
                        using (var cmd = new MySqlCommand("sp_RegistrarVentaCompleta", conexion, transaccion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@p_id_cliente", pedido.ClienteAsociado.IdCliente);
                            cmd.Parameters.AddWithValue("@p_id_usuario", idUsuarioOperador);
                            cmd.Parameters.AddWithValue("@p_monto_total", pedido.TotalVenta);
                            cmd.Parameters.AddWithValue("@p_metodo_pago", metodoPago);

                            var paramIdVenta = new MySqlParameter("@p_id_venta_generada", MySqlDbType.Int32)
                            {
                                Direction = ParameterDirection.Output
                            };
                            var paramNumFactura = new MySqlParameter("@p_numero_factura_generada", MySqlDbType.VarChar, 20)
                            {
                                Direction = ParameterDirection.Output
                            };

                            cmd.Parameters.Add(paramIdVenta);
                            cmd.Parameters.Add(paramNumFactura);

                            cmd.ExecuteNonQuery();

                            idVentaGenerada = Convert.ToInt32(paramIdVenta.Value);
                            numFacturaGenerada = paramNumFactura.Value?.ToString() ?? string.Empty;
                        }

                        // 2. Registrar cada renglón en 'detalle_ventas' y descontar stock
                        foreach (var item in pedido.ItemsCarrito)
                        {
                            using (var cmdDetalle = new MySqlCommand("sp_RegistrarDetalleYDescontarStock", conexion, transaccion))
                            {
                                cmdDetalle.CommandType = CommandType.StoredProcedure;
                                cmdDetalle.Parameters.AddWithValue("@p_id_venta", idVentaGenerada);
                                cmdDetalle.Parameters.AddWithValue("@p_id_notebook", item.Laptop.IdNotebook);
                                cmdDetalle.Parameters.AddWithValue("@p_cantidad", item.Cantidad);
                                cmdDetalle.Parameters.AddWithValue("@p_precio_unitario", item.PrecioUnitarioCongelado);

                                cmdDetalle.ExecuteNonQuery();
                            }
                        }

                        // Confirmación atómica de la transacción
                        transaccion.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaccion.Rollback();
                        mensajeError = ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}