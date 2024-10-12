using System.Security.Cryptography.X509Certificates;

namespace Inventario;

public class Relacion{
    public List<Equipo> equipos = new List<Equipo>(){};
    public List<Componente> componentes = new List<Componente>(){};
    public List<(string, string)> relaciones = new List<(string, string)>(){}; // ID_EQUIPO IMT , ID_COMPONENTE IMT,
    public Relacion(int n){
        for(int i = 1 ; i <= n ; i++){
            Equipo pruebaEquipo = new Equipo(i);
            Componente pruebaComponent = new Componente(i);
            equipos.Add(pruebaEquipo);
            componentes.Add(pruebaComponent);
        }
    }
}

