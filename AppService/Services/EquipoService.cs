public class EquipoService : IEquipoService
{
    private List<Equipo> _equipos = new List<Equipo>();

    public void AgregarEquipo(Equipo equipo)
    {

        if (_equipos.Any(e => e.Id == equipo.Id))
        {
            throw new System.Exception("El equipo ya existe.");
        }
        _equipos.Add(equipo);
    }

    public void ActualizarEquipo(Equipo equipoActualizado)
    {
        var equipo = _equipos.FirstOrDefault(e => e.Id == equipoActualizado.Id);
        if (equipo == null)
        {
            throw new System.Exception("El equipo no existe.");
        }

        equipo.Nombre = equipoActualizado.Nombre;
        equipo.Categoria = equipoActualizado.Categoria;
    }

    public void EliminarEquipo(int id)
    {
        var equipo = _equipos.FirstOrDefault(e => e.Id == id);
        if (equipo == null)
        {
            throw new System.Exception("El equipo no existe.");
        }
        _equipos.Remove(equipo);
    }

    public Equipo ObtenerEquipoPorId(int id)
    {
        var equipo = _equipos.FirstOrDefault(e => e.Id == id);
        if (equipo == null)
        {
            throw new System.Exception("El equipo no existe.");
        }
        return equipo;
    }

    public List<Equipo> ObtenerTodosLosEquipos()
    {
        return _equipos.ToList();
    }

    public List<Equipo> ObtenerEquiposPorCategoria(int categoriaId)
    {
        return _equipos.Where(e => e.Categoria.Id == categoriaId).ToList();
    }
}

