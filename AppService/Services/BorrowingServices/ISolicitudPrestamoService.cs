public interface ISolicitudPrestamoService
{
    bool EnviarSolicitudPrestamo(SolicitudPrestamo soli);
    bool ValidarSolicitud();
    List<SolicitudPrestamo> mostrarSolicitudesPrestamo();
    SolicitudPrestamo DetalleSolicitudPrestamo(int IdSolicitud);
    List<SolicitudPrestamo> HistorialSolicitudPrestamo();
}