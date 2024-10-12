public class Usuario
{
    public int idUsuario { get; set; }
    public string nombre { get; set; } = null!;
    public string carrera {get; set;} = null!;
    public string correoElectronico { get; set; } = null!;
    public RolUsuario Rol { get; set; }
}

public enum RolUsuario
{
    Administrador,
    Usuario,
    SuperUsuario
}