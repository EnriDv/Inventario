namespace Inventario.Services;

public interface ISolcitudPrestamoService{
    public bool Enviar_Solicitud(SolicitudPrestamo solicitud);
    public List<SolicitudPrestamo> VerSolicitudes(int id_User);
    public bool ModificarSolicitud(int id_Solicitud);
    public bool CancelarSolicitud(int id_Solicitud);
}


public class SolicitudPrestamoService: ISolcitudPrestamoService{
    public List<SolicitudPrestamo> solicitudes = new List<SolicitudPrestamo>(){};

    public bool Enviar_Solicitud(SolicitudPrestamo solicitud){
        return true;
    }
    public List<SolicitudPrestamo> VerSolicitudes(int id_User){
        List<SolicitudPrestamo> resultado = new List<SolicitudPrestamo>(){};
        foreach (var solicitud in solicitudes)
        {
            if(solicitud.cod_User == id_User.ToString()){
                resultado.Add(solicitud);
            }
        }
        return resultado;
    }
    public bool ModificarSolicitud(int id_Solicitud){
        return true;
    }
    public bool CancelarSolicitud(int id_Solicitud){
        return true;
    }
}