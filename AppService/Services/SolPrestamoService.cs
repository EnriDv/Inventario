public class SolPrestamoService: ISolPrestamoService
{
//base de datos falsa
    List<int> listaEquipos = new List<int> { 1, 2, 3, 4, 5 };
    int n_sol_prestamo = 0;

    List<SolPrestamo> Solicitudes = new List<SolPrestamo> 
    {
        new SolPrestamo
        {
            Id_solicitud = 1,
            Id_Equipo = 1, 
            Detalle = "Descripcion1.",
            Estado_solicitud = "En espera."
        },

    };
    public void Enviar_Solicitud(int Id_Equipo, string Detalle)
    {
        Recibir_Solicitud(Id_Equipo, Detalle);
    }
    public void Recibir_Solicitud(int Id_Equipo, string Detalle)
    {
        Detalle = Detalle.Replace(" ", "");
        if(Detalle == "" || Id_Equipo == 0)
        {
            Console.WriteLine("Campos vacios.");
            return;
        }
        else
        {
            Validar_Solicitud(Id_Equipo, Detalle);
        }
    }
    public void Validar_Solicitud(int Id_Equipo, string Detalle)
    {
        if(!listaEquipos.Contains(Id_Equipo))
        {
            Console.WriteLine("El item ingresado no existe en la base de datos");
            return;
        }
        else
        {
            Almacenar_Solicitud(Id_Equipo, Detalle);
        }
    }
    public void Almacenar_Solicitud(int Id_Eq, string Det)
    {
        n_sol_prestamo++;
        SolPrestamo NuevaSoli = new SolPrestamo 
        {
            Id_solicitud = n_sol_prestamo,
            Id_Equipo = Id_Eq, 
            Detalle = Det,
            Estado_solicitud = "En espera."
        };
    }
}