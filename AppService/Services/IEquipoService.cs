public interface IEquipoService
{
    void AgregarEquipo(Equipo equipo);
    void ActualizarEquipo(Equipo equipoActualizado);
    void EliminarEquipo(int id);
    Equipo ObtenerEquipoPorId(int id);
    List<Equipo> ObtenerTodosLosEquipos();
    List<Equipo> ObtenerEquiposPorCategoria(int categoriaId);
}
