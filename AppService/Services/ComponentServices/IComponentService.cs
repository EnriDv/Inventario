public interface IComponentService
{
    bool RegistrarComponente(Componente componente);
    Componente DetalleComponente(int id);
    bool ActualizarComponente(int id);
    bool EliminarComponente(int id);
    bool CambiarComponenteEquipo(int idComponente, int idEquipo);
    List<Componente> MostrarComponentes();
}