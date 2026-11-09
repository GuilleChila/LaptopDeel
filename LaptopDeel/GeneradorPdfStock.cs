using System;
using System.Collections.Generic;
using System.IO;
using LaptopDeel.Entidades;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace LaptopDeel
{
    public static class GeneradorPdfStock
    {
        public static string ExportarReporteStock(List<Notebook> listaEquipos, decimal montoTotalExistencias)
        {
            string carpetaDescargas = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string nombreArchivo = $"Reporte_Stock_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string rutaCompleta = Path.Combine(carpetaDescargas, nombreArchivo);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(35);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Lato"));

                    // --- ENCABEZADO INSTITUCIONAL ---
                    page.Header().Column(col =>
                    {
                        col.Item().Row(row =>
                        {
                            row.RelativeItem(2).Column(left =>
                            {
                                left.Item().Text("REPORTE DE STOCK").FontSize(24).Bold().FontColor("#1E293B");
                                left.Item().Text("LaptopDeel S.A.").FontSize(11).Bold();
                                left.Item().Text("Santiago del Estero 475, Corrientes, Argentina");
                                left.Item().Text("CUIT: 20-46830614-8");
                            });

                            row.RelativeItem(1.5f).Column(right =>
                            {
                                right.Item().AlignRight().Text("EMISIÓN DE INVENTARIO").FontSize(9).Bold().FontColor("#64748B");
                                right.Item().AlignRight().Text($"{DateTime.Now:dd/MM/yyyy HH:mm} hs").FontSize(11).Bold();
                                right.Item().AlignRight().Text($"Total de Modelos: {listaEquipos.Count}").FontSize(10);
                            });
                        });

                        col.Item().PaddingTop(10).LineHorizontal(1.5f).LineColor("#2563EB");
                    });

                    // --- CONTENIDO PRINCIPAL ---
                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Item().Background("#F8FAFC").Border(1).BorderColor("#CBD5E1").Padding(10).Row(row =>
                        {
                            row.RelativeItem().Text("TOTAL INVENTARIO VALORIZADO").Bold().FontSize(11).FontColor("#1E293B");
                            row.RelativeItem().AlignRight().Text($"Monto Total de Existencias: ${montoTotalExistencias:N2}").Bold().FontSize(12).FontColor("#2563EB");
                        });

                        col.Item().PaddingVertical(10);

                        // Tabla de Notebooks
                        col.Item().Table(tabla =>
                        {
                            tabla.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn(1.5f); // Marca
                                columns.RelativeColumn(2.5f); // Modelo
                                columns.RelativeColumn(1.8f); // Categoría
                                columns.RelativeColumn(1.0f); // Stock
                                columns.RelativeColumn(2.0f); // Estado de Stock
                            });

                            tabla.Header(header =>
                            {
                                header.Cell().Background("#1E293B").Padding(6).Text("MARCA").Bold().FontColor(Colors.White);
                                header.Cell().Background("#1E293B").Padding(6).Text("MODELO").Bold().FontColor(Colors.White);
                                header.Cell().Background("#1E293B").Padding(6).Text("CATEGORÍA").Bold().FontColor(Colors.White);
                                header.Cell().Background("#1E293B").Padding(6).AlignRight().Text("STOCK").Bold().FontColor(Colors.White);
                                header.Cell().Background("#1E293B").Padding(6).Text("ESTADO DE STOCK").Bold().FontColor(Colors.White);
                            });

                            foreach (var item in listaEquipos)
                            {
                                string estadoTexto = "🟢 Normal";
                                string colorFondoCell = "#DCFCE7"; // Verde Claro
                                string colorTextoCell = "#15803D"; // Verde Oscuro

                                if (item.Stock == 0)
                                {
                                    estadoTexto = "🔴 Stock Agotado";
                                    colorFondoCell = "#FEE2E2"; // Rojo Claro
                                    colorTextoCell = "#B91C1C"; // Rojo Oscuro
                                }
                                else if (item.Stock < 3)
                                {
                                    estadoTexto = "🟠 Stock Bajo";
                                    colorFondoCell = "#FFEDD5"; // Anaranjado Claro
                                    colorTextoCell = "#C2410C"; // Anaranjado Oscuro
                                }
                                else if (item.Stock < 7)
                                {
                                    estadoTexto = "🟡 Stock Medio";
                                    colorFondoCell = "#FEF9C3"; // Amarillo Claro
                                    colorTextoCell = "#A16207"; // Amarillo Oscuro
                                }

                                string cat = string.IsNullOrWhiteSpace(item.Categorias) ? "General" : item.Categorias;

                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").Padding(6).Text(item.Marca);
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").Padding(6).Text(item.Modelo);
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").Padding(6).Text(cat);
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").Padding(6).AlignRight().Text(item.Stock.ToString()).Bold();
                                tabla.Cell().BorderBottom(0.5f).BorderColor("#E2E8F0").Background(colorFondoCell).Padding(6).Text(estadoTexto).Bold().FontColor(colorTextoCell);
                            }
                        });
                    });

                    // --- PIE DE PÁGINA ---
                    page.Footer().Column(col =>
                    {
                        col.Item().LineHorizontal(0.5f).LineColor("#CBD5E1");
                        col.Item().PaddingTop(8).Row(row =>
                        {
                            row.RelativeItem().Text("LaptopDeel S.A. - Control e Inventario de Stock").FontSize(9).FontColor("#64748B");
                            row.RelativeItem().AlignRight().Text(x =>
                            {
                                x.Span("Página ");
                                x.CurrentPageNumber();
                                x.Span(" de ");
                                x.TotalPages();
                            });
                        });
                    });
                });
            })
            .GeneratePdf(rutaCompleta);

            return rutaCompleta;
        }

        public static string GenerarReporteStock(List<Notebook> listaEquipos, decimal montoTotalExistencias)
        {
            return ExportarReporteStock(listaEquipos, montoTotalExistencias);
        }
    }
}