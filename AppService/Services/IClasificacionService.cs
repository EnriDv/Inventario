public interface IClasificacion
{
    void Clasificar(Equipo equipo, Categoria categoria);
    List<Equipo> ObtenerEquiposPorCategoria(int categoriaId);
}
