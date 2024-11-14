public class SolicitudPrestamoDTO
{
    public string NombreUsuario { get; set; } = null!;
    public string carrera {get; set;} = null!;
    public string correoElectronico { get; set; } = null!;
    public string NombreEquipo { get; set; } = null!;
    public string Estado_Equipo {get; set;} = null!;
    public string Detalle_equipo {get; set;} = null!;
    public DateTime FechaSolicitud { get; set; }
    public DateTime FechaInicioPrestamo { get; set; }
    public DateTime FechaFinPrestamo { get; set; }
    public EstadoSolicitud estadoSolicitud { get; set; }
}