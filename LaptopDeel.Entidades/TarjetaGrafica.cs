namespace LaptopDeel.Entidades
{
    public class TarjetaGrafica
    {
        public int IdTarjeta { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Marca { get; set; } = string.Empty;
        public string Capacidad { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;
        public TarjetaGrafica() { }
        public TarjetaGrafica(int idTarjeta, string nombre, string marca, string capacidad, bool eliminado = false)
        {
            IdTarjeta = idTarjeta;
            Nombre = nombre;
            Marca = marca;
            Capacidad = capacidad;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return $"{Nombre} {Marca} {Capacidad}";
        }
    }
}
