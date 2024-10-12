public interface IAprobacionSolicitudService
{
    public void AprobarSolicitud(SolicitudPrestamo solicitud);

    public void RechazarSolicitud(SolicitudPrestamo solicitud);
}