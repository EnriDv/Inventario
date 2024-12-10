public class PrestamoService : IPrestamoService
{
    public bool CrearPrestamo(Prestamo prestamo)
    {
        return true;
    }
    public Prestamo DetallePrestamo(int idPrestamo)
    {
        return new Prestamo();
    }
    public List<Prestamo> HistorialPrestamo()
    {
        return new List<Prestamo>();
    }
    public bool DevolverPrestamo()
    {
        return true;
    }
}