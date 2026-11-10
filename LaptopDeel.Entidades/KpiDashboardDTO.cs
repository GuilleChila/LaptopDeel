namespace LaptopDeel.Entidades
{
    public class KpiDashboardDTO
    {
        public int ClientesActivos { get; set; }
        public decimal TotalVentasMesActual { get; set; }
        public decimal PorcentajeVariacionVentas { get; set; }
        public int ModelosStockCritico { get; set; }
    }
}
