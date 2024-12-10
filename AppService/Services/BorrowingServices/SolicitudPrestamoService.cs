public class SolicitudPrestamoService : ISolicitudPrestamoService
{
    public bool EnviarSolicitudPrestamo(SolicitudPrestamo soli)
    {
        return true;
    }
    public bool ValidarSolicitud()
    {
        return true;
    }
    public List<SolicitudPrestamo> mostrarSolicitudesPrestamo()
    {
        return Solicitudes;
    }
    public SolicitudPrestamo DetalleSolicitudPrestamo(int IdSolicitud)
    {
        foreach(SolicitudPrestamo soli in Solicitudes)
        {
            if (soli.EquipoSolicitado.idEquipo == IdSolicitud)
            {
                return soli;
            }
        }
        return new SolicitudPrestamo();
    }

    public List<SolicitudPrestamo> HistorialSolicitudPrestamo()
    {
        return new List<SolicitudPrestamo>();
    }
    
List<SolicitudPrestamo> Solicitudes = new List<SolicitudPrestamo>
{
    new SolicitudPrestamo{
        IdSolicitud = 1,
        UsuarioSolicitante = new Usuario{nombre = "Juan", carrera = "Medicinas" },
        EquipoSolicitado = new Equipo {idEquipo= 1, Nombre_equipo = "PC1", Estado_Equipo = "Disponible", Detalle_equipo="rayón en la pantalla"},
        FechaSolicitud = new DateTime(2024, 10, 5),
        FechaInicioPrestamo= new DateTime(2024, 10, 7),
        FechaFinPrestamo = new DateTime(2024, 12, 20),
        estadoSolicitud = EstadoSolicitud.Pendiente
    },
    new SolicitudPrestamo{
        IdSolicitud = 2,
        UsuarioSolicitante = new Usuario{nombre = "María", carrera = "Ingeniería Civil" },
        EquipoSolicitado = new Equipo {idEquipo= 2, Nombre_equipo = "Proyector", Estado_Equipo = "Disponible", Detalle_equipo="Conexión HDMI dañada"},
        FechaSolicitud = new DateTime(2024, 10, 6),
        FechaInicioPrestamo= new DateTime(2024, 10, 8),
        FechaFinPrestamo = new DateTime(2024, 11, 15),
        estadoSolicitud = EstadoSolicitud.Pendiente
    },
    new SolicitudPrestamo{
        IdSolicitud = 3,
        UsuarioSolicitante = new Usuario{nombre = "Carlos", carrera = "Arquitectura" },
        EquipoSolicitado = new Equipo { idEquipo= 3, Nombre_equipo = "Cámara DSLR", Estado_Equipo = "Disponible", Detalle_equipo="Sin lente adicional"},
        FechaSolicitud = new DateTime(2024, 10, 9),
        FechaInicioPrestamo= new DateTime(2024, 10, 10),
        FechaFinPrestamo = new DateTime(2024, 11, 30),
        estadoSolicitud = EstadoSolicitud.Pendiente
    },
    new SolicitudPrestamo{
        IdSolicitud = 4,
        UsuarioSolicitante = new Usuario{nombre = "Ana", carrera = "Diseño Gráfico" },
        EquipoSolicitado = new Equipo {Nombre_equipo = "Tablet Gráfica", Estado_Equipo = "Disponible", Detalle_equipo="Lápiz digital desgastado"},
        FechaSolicitud = new DateTime(2024, 10, 10),
        FechaInicioPrestamo= new DateTime(2024, 10, 12),
        FechaFinPrestamo = new DateTime(2024, 12, 15),
        estadoSolicitud = EstadoSolicitud.Pendiente
    }
};

}