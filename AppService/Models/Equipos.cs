namespace Inventario;

public class Equipo{
    public string cod_Equipo {get; set;} = null!;
    public string cod_Imt {get; set;} = null!;
    public string cod_Ucb {get; set;} = null!;
    public string Nombre_equipo {get; set;} = null!;
    public string Descripcion_equipo {get; set;} = null!;
    public bool Estado {get; set;} 
    public Equipo(int n){
        cod_Equipo = "000"+ n;
        cod_Imt = "ABC" + n;
        cod_Ucb = "UCB-M" + n;
        Nombre_equipo = "Equipo nro_" + n;
        Descripcion_equipo = "Este es el equipo creado en la fecha: " + DateTime.Now;
    }
}