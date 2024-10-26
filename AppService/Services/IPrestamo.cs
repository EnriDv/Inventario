public interface IPrestamoService
{
    public List<Equipo> mostrar_equipos();
    public List<Equipo> mostrar_equipos_prestados();
    public bool cambiar_estado_equipo(int idEquipo); 
}