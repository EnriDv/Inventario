public interface IGestionarSolicitudService
{
    public void AprobarSolicitud(SolicitudPrestamo solicitud);

    public void RechazarSolicitud(SolicitudPrestamo solicitud);
}