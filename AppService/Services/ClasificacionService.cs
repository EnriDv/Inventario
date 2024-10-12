public class ClasificacionService : IClasificacion
{
    private List<Equipo> _equipos = new List<Equipo>();

    public void Clasificar(Equipo equipo, Categoria categoria)
    {
        equipo.Categoria = categoria;
        _equipos.Add(equipo);
    }

    public List<Equipo> ObtenerEquiposPorCategoria(int categoriaId)
    {
        return _equipos.Where(e => e.Categoria.Id == categoriaId).ToList();
    }
}
