namespace Inventario;

public class SolicitudPrestamo{
    public string cod_Solicitud {get; set;} = null!;
    public string cod_User {get; set;} = null!;
    public string cod_Equipo {get; set;} = null!;
    public DateOnly fecha_Solicitud {get; set;}
    public TimeOnly hra_Solicitud {get; set;}
    public DateOnly? fecha_Prestamo {get; set;}
    public TimeOnly? hra_Prestamo {get; set;}
    public DateOnly? fecha_Devolucion {get; set;}
    public TimeOnly? hra_Devolucion {get; set;}
    public string? observacion {get; set;}
    string estado_solicitud {get; set;} = null!;
    
}