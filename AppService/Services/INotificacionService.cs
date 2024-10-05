namespace Inventario.Services;

public interface INotificacionService{
    public void Respuesta_Solicitud();
    public void Enviar_Notificacion();
    public Notificacion Crear_Notificacion();
    public void Detalle_Notificacion();
}

public class NotificacionService: INotificacionService{
    public void Respuesta_Solicitud(){
        return;
    }
    public void Enviar_Notificacion(){
        return;
    }
    public Notificacion Crear_Notificacion(){
        return new Notificacion();
    }
    public void Detalle_Notificacion(){
        return;
    }
}