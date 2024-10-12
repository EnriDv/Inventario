public class SolicitudPrestamo
{
    public int IdSolicitud { get; set; }
    public Usuario UsuarioSolicitante { get; set; } = null!;
    public Equipo EquipoSolicitado { get; set; } = null!;
    public DateTime FechaSolicitud { get; set; }
    public DateTime FechaInicioPrestamo { get; set; }
    public DateTime FechaFinPrestamo { get; set; }
    public EstadoSolicitud estadoSolicitud { get; set; }
}

public enum EstadoSolicitud
{
    Aprobado = 1,
    Rechazado = 0,
    Pendiente = -1
}