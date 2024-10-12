namespace Inventario;

public class Componente{
    public string cod_component {get ; set;} = null!;
    public string? cod_imt {get; set;}
    public string Nombre_component {get; set;} = null!;
    public string Descripcion {get; set;} = null!;
    public Componente(int n, string nombre = "", int codIMT = 0 ){
        cod_component = "000" + n;
        if(codIMT == 0){
            cod_imt = null;
        }else{
            cod_imt = "ABC" + codIMT;
        }
        
        if(nombre == ""){
            Nombre_component = "Componente nro_" + n;
        }else{
            Nombre_component = nombre;
        }
        
        Descripcion = "Este es el componente agregado en la fecha: " + DateTime.Now;
    }

}
