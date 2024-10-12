namespace Inventario.Services;

public interface IEquipoService{
    public void CrearEquipo(Equipo entrada);
}

public class EquipoService: IEquipoService{
    public void CrearEquipo(Equipo entrada){
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