using System.Diagnostics;

public class PrestamoService: IPrestamoService
{
    List<Prestamo> prestamos =  new List<Prestamo>
    {
        new Prestamo
        {
            Cod_prestamo = 1, 
            Fecha_sol = new DateOnly(2010, 4, 4),
            Hra_sol = new TimeOnly(12, 30, 00),
            Fecha_prestamo = new DateOnly(2010, 4, 6),
            Hra_prestamo = new TimeOnly(8, 10, 00),
            Fecha_dev = null,
            Hra_dev = null,
            Observacion = "Presenta fallos al apagar.",
            Estado_prestamo = "En uso.",
            Estado_dev = ""
        }
    };

    Usuarios usuario = new Usuarios
    {
        Ci = 1,
        Nombres = "Juan",
        Apellidos = "Rocas",
        Tipo_usuario = "Docente",
        Carrera = "Software",
        Id_huella = 22,
        Usr_name = "JuanRocks",
        Password = "ASD123",
        Email = "juan.rocas@ucb.edu.bo"
    };


    public void Recibir_datos(int Id_huella, int Cod_prestamo)
    {
        Verificar_datos(Id_huella, Cod_prestamo);
    }
    
    public void Verificar_datos(int Id_huella, int Cod_prestamo)
    {
        if(Id_huella != usuario.Id_huella)
        {
            Console.WriteLine("Error, fallo de escaneo de huella o usuario no registrado.");
        }

        var prestamo = prestamos.FirstOrDefault(p => p.Cod_prestamo == Cod_prestamo);
        if (prestamo == null)
        {
            Console.WriteLine("Préstamo no encontrado.");
        }

    }
}