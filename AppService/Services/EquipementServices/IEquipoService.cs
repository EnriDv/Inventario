public interface IEquipoService
{
    bool RegistrarEquipo(Equipo equipo);
    Equipo DetalleEquipo(int id);
    bool ActualizarEquipo(int id);
    bool EliminarEquipo(int id);
    List<Equipo> MostrarEquipos();
}