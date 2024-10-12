namespace Inventario.Services;

public interface IComponentService{
    public string CrearComponente(int CodigoSecuencia, string nombre, int codIMT);
    public List<Componente> verComponentesEquipo(int id);
    public List<Componente> verComponentesTodos();
}

public class ComponentService: IComponentService{
    public Relacion DB = new Relacion(10){};
    public string CrearComponente(int CodigoSecuencia, string nombre, int codIMT){
        Componente componente = new Componente(CodigoSecuencia, nombre, codIMT);
        DB.componentes.Add(componente);
        return "Agregacion Exitosa";
    }

    public List<Componente> verComponentesEquipo(int id){
        List<Componente> componentes = DB.componentes;
        List<Componente> result = new List<Componente>(){};
        foreach (var relacion in DB.relaciones)
        {
            if(relacion.Item1 == id.ToString()){
                foreach (var componente in DB.componentes)
                {
                    if(componente.cod_imt == relacion.Item1 || componente.cod_component == relacion.Item2){
                        componentes.Add(componente);
                    }
                }
            }
        }
        return result;
    }

    public List<Componente> verComponentesTodos(){
        return DB.componentes;
    }
}