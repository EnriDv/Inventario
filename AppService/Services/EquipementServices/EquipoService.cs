public class EquipoService : IEquipoService
{
    public bool RegistrarEquipo(Equipo equipo)
    {
        List<Equipo> EquiposRegistrados = new List<Equipo>();
        foreach (Equipo e in EquiposRegistrados)
        {
            
        }
        EquiposRegistrados.Add(equipo);
        return true;
    }

    public Equipo DetalleEquipo(int id)
    {
        return new Equipo();
    }
    public bool ActualizarEquipo(int id)
    {
        return true;
    }

    public bool EliminarEquipo(int id)
    {
        return true;
    }

    public List<Equipo> MostrarEquipos()
    {
        return new List<Equipo>();
    }

    public bool cambiar_estado_equipo(int idEquipo)
    {
        return true;
    }

    /*
    public List<Equipo> EquiposRegistrados = new List<Equipo>
    {
        new Equipo
        {
            Id_equipo = 1,
            Codigo_Equipo = "1234",
            Nombre_equipo = "PC1",
            Estado_Equipo = "Disponible",
            Detalle_equipo = "nada"
        },
        new Equipo
        {
            Id_equipo = 2,
            Codigo_Equipo = "2345",
            Nombre_equipo = "PC1",
            Estado_Equipo = "Estropeado",
            Detalle_equipo = "dañado"
        },
        new Equipo
        {
            Id_equipo = 3,
            Codigo_Equipo = "3456",
            Nombre_equipo = "Data1",
            Estado_Equipo = "Disponible",
            Detalle_equipo = "algo rayado"
        },
    };
    */
}