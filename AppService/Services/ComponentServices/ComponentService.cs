public class ComponenteService
{
    bool RegistrarComponente(Componente componente)
    {
        return true;
    }
    Componente DetalleComponente(int id)
    {
        return new Componente();
    }
    bool ActualizarComponente(int id)
    {
        return true;
    }
    bool EliminarComponente(int id)
    {
        return true;
    }
    bool CambiarComponenteEquipo(int idComponente, int idEquipo)
    {
        return true;
    }
    List<Componente> MostrarComponentes()
    {
        return new List<Componente>();
    }
}