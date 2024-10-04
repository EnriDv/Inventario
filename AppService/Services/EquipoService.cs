public class EquipoService : IEquipoService
{
    public bool RegistrarEquipo( Equipos equipo )
    {
        foreach(Equipos e in EquiposRegistrados)
        {
            if( e.Codigo_Equipo == equipo.Codigo_Equipo)
            {
                return false;
            }
            else if( e.Estado_Equipo != "Disponible")
            {
                return false;
            }
            else
            {
                EquiposRegistrados.Add(equipo);
                return true;
            }
        }
        return false;
    }
    public List<Equipos> MostrarEquipos()
    {
        return EquiposRegistrados;
    }


    public List<Equipos> EquiposRegistrados = new List<Equipos>
    {
        new Equipos
        {
            Id_equipo = 1,
            Codigo_Equipo = "1234",
            Nombre_equipo = "PC1",
            Estado_Equipo = "Disponible",
            Detalle_equipo = "nada"
        },
        new Equipos
        {
            Id_equipo = 2,
            Codigo_Equipo = "2345",
            Nombre_equipo = "PC1",
            Estado_Equipo = "Estropeado",
            Detalle_equipo = "dañado"
        },
        new Equipos
        {
            Id_equipo = 3,
            Codigo_Equipo = "3456",
            Nombre_equipo = "Data1",
            Estado_Equipo = "Disponible",
            Detalle_equipo = "algo rayado"
        },
    };
}