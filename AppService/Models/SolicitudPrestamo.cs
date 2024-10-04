namespace Prestamos;

public class SolicitudPrestamo{
    int Id_solicitud {get; set;}
    int Id_Equipo {get; set;}
    string Detalle {get; set;} = null!;
    string Estado_solicitud {get; set;} = null!;
}