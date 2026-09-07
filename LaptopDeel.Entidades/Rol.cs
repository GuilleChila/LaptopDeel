namespace LaptopDeel.Entidades
{
    public class Rol
    {
        public int IdRol { get; set; }
        public string RolName { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public bool Eliminado { get; set; } = false;
        public Rol() { }
        public Rol(int idRol, string rolName, string descripcion, bool eliminado = false)
        {
            IdRol = idRol;
            RolName = rolName;
            Descripcion = descripcion;
            Eliminado = eliminado;
        }
        public override string ToString()
        {
            return RolName;
        }
    }
}
