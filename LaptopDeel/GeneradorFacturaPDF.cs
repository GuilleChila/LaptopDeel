using System;
using System.IO;
using LaptopDeel.Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace LaptopDeel.Servicios
{
    public static class GeneradorFacturaPDF
    {
        public static string GenerarFactura(PedidoVentaDTO pedido, string numFactura, string tipoComprobante, string metodoPago)
        {
            // 1. Ruta de guardado automático en la carpeta 'Descargas' del usuario
            string carpetaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string nombreArchivo = $"Factura_{tipoComprobante.Replace(" ", "_")}_{numFactura}.pdf";
            string rutaCompleta = Path.Combine(carpetaDescargas, nombreArchivo);

            // 2. Cálculos Impositivos exactos con redondeo financiero
            decimal totalGeneral = pedido.TotalVenta;
            decimal subtotalNeto = Math.Round(totalGeneral / 1.21m, 2);
            decimal montoIva = Math.Round(totalGeneral - subtotalNeto, 2);

            // 3. Maquetación del documento PDF
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Lato"));

                    // --- ENCABEZADO Y DATOS DE LA EMPRESA ---
                    page.Header().Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            // Lado Izquierdo: Título Principal e Información Fiscal Emisor
                            row.RelativeItem(2).Column(left =>
                            {
                                left.Item().Text("FACTURA").FontSize(32).Bold().FontColor("#1E293B");
                                left.Item().PaddingTop(6).Text("LaptopDeel S.A").FontSize(11).Bold();
                                left.Item().Text("Santiago del Estero 475");
                                left.Item().Text("Corrientes, Argentina");
                                left.Item().Text("CUIT: 20-46830614-8");
                                left.Item().Text("IVA: Responsable Inscripto");
                            });

                            // Lado Derecho: Metadatos del Comprobante Fiscal
                            row.RelativeItem(1.5f).Column(right =>
                            {
                                right.Item().AlignRight().Text($"N° DE FACTURA: {numFactura}").FontSize(11).Bold();
                                right.Item().AlignRight().Text($"FECHA: {DateTime.Now:dd/MM/yyyy}").FontSize(10);
                                right.Item().AlignRight().Text($"N° DE PEDIDO: {pedido.ClienteAsociado.IdCliente}-{DateTime.Now:yyyyMMdd}").FontSize(10);
                                right.Item().AlignRight().Text($"TIPO: {tipoComprobante}").FontSize(10).Bold();
                            });
                        });

                        col.Item().PaddingTop(15).LineHorizontal(1).LineColor("#CBD5E1");
                    });

                    // --- CUERPO: DATOS DEL CLIENTE ---
                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            // Bloque Facturar A
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("FACTURAR A").Bold().FontSize(11).FontColor("#1E293B");
                                c.Item().Text(pedido.ClienteAsociado.NombreCompleto).Bold();
                                c.Item().Text(pedido.ClienteAsociado.Direccion);
                                c.Item().Text($"DNI / CUIT: {pedido.ClienteAsociado.Dni}");
                                c.Item().Text($"Condición IVA: {pedido.ClienteAsociado.Iva}");
                            });

                            // Bloque Estado de Cobro
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("DETALLES DE PAGO").Bold().FontSize(11).FontColor("#1E293B");
                                c.Item().Text($"Medio de Pago: {metodoPago}");
                                c.Item().Text("Estado: Pagado / Comprobante Emitido");
                            });
                        });

                        col.Item().PaddingVertical(15);

                        // --- TABLA DE PRODUCTOS Y RENGLONES ---
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);   // CANT.
                                columns.RelativeColumn(3);    // DESCRIPCIÓN
                                columns.RelativeColumn(1.5f); // PRECIO UNITARIO
                                columns.RelativeColumn(1.5f); // IMPORTE
                            });

                            // Encabezado de la Tabla
                            tabla.Header(header =>
                            {
                                header.Cell().BorderBottom(1.5f).BorderColor("#1E293B").PaddingVertical(6).Text("CANT.").Bold();
                                header.Cell().BorderBottom(1.5f).BorderColor("#1E293B").PaddingVertical(6).Text("DESCRIPCIÓN").Bold();
                                header.Cell().BorderBottom(1.5f).BorderColor("#1E293B").PaddingVertical(6).AlignRight().Text("PRECIO UNITARIO").Bold();
                                header.Cell().BorderBottom(1.5f).BorderColor("#1E293B").PaddingVertical(6).AlignRight().Text("IMPORTE").Bold();
                            });

                            // Listado de Ítems del Pedido
                            foreach (var item in pedido.ItemsCarrito)
                            {
                                string descripcion = $"{item.Laptop.Marca} {item.Laptop.Modelo}";

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").PaddingVertical(8).Text(item.Cantidad.ToString());
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").PaddingVertical(8).Text(descripcion);
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").PaddingVertical(8).AlignRight().Text($"${item.PrecioUnitarioCongelado:N2}");
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").PaddingVertical(8).AlignRight().Text($"${item.SubtotalItem:N2}");
                            }
                        });

                        col.Item().PaddingTop(15);

                        // --- DESGLOSE DE TOTALES E IMPUESTOS ---
                        col.Item().Row(row =>
                        {
                            row.RelativeItem(); // Espacio en blanco a la izquierda

                            row.ConstantItem(220).Column(totales =>
                            {
                                totales.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("Subtotal:");
                                    r.RelativeItem().AlignRight().Text($"${subtotalNeto:N2}");
                                });

                                totales.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("IVA 21.0%:");
                                    r.RelativeItem().AlignRight().Text($"${montoIva:N2}");
                                });

                                totales.Item().PaddingVertical(5).LineHorizontal(1).LineColor("#CBD5E1");

                                totales.Item().Row(r =>
                                {
                                    r.RelativeItem().Text("TOTAL").Bold().FontSize(14).FontColor("#1E293B");
                                    r.RelativeItem().AlignRight().Text($"${totalGeneral:N2}").Bold().FontSize(14).FontColor("#1E293B");
                                });
                            });
                        });
                    });

                    // --- PIE DE PÁGINA: INFORMACIÓN BANCARIA (SIN LEYENDA / SIN VENCIMIENTO) ---
                    page.Footer().Column(col =>
                    {
                        col.Item().LineHorizontal(0.5f).LineColor("#CBD5E1");
                        col.Item().PaddingTop(10).Row(row =>
                        {
                            row.RelativeItem().Column(banco =>
                            {
                                banco.Item().Text("CONDICIONES Y FORMA DE PAGO").Bold().FontSize(10).FontColor("#1E293B");
                                banco.Item().Text("Banco Santander");
                                banco.Item().Text("CBU: 0720123420000001234567");
                                banco.Item().Text("Alias: LAPTOPDEEL.OFICIAL");
                            });
                        });
                    });
                });
            })
            .GeneratePdf(rutaCompleta);

            return rutaCompleta;
        }
    }
}