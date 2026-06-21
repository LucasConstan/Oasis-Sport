namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Bloqueado { get; set; }
        public bool Eliminado { get; set; }

        public List<ComponentePermiso> Permisos { get; set; } = new List<ComponentePermiso>();
    }
}
