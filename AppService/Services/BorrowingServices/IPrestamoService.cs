public interface IPrestamoService
{
    bool CrearPrestamo(Prestamo prestamo);
    Prestamo DetallePrestamo(int idPrestamo);
    List<Prestamo> HistorialPrestamo();
    bool DevolverPrestamo();
}