namespace Prestamos.Services;

public interface ISolcitudPrestamoService{
    public bool Enviar_Solicitud(SolicitudPrestamo solicitud);
    public List<SolicitudPrestamo> VerSolicitudes(int id_User);
    public bool ModificarSolicitud(int id_Solicitud);
    public bool CancelarSolicitud(int id_Solicitud);
}


public class SolicitudPrestamoService: ISolcitudPrestamoService{
    public bool Enviar_Solicitud(SolicitudPrestamo solicitud){
        return true;
    }
    public List<SolicitudPrestamo> VerSolicitudes(int id_User){
        var Solicitudes = new List<SolicitudPrestamo>(){};
        return Solicitudes;
    }
    public bool ModificarSolicitud(int id_Solicitud){
        return true;
    }
    public bool CancelarSolicitud(int id_Solicitud){
        return true;
    }
}