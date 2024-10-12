using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class PrestamoController : ControllerBase
{
    private readonly IPrestamoService service;  //readonly para solo lectura
    public PrestamoController(IPrestamoService s)
    {
        service = s;
    }
    [HttpPost("Devolver")]
    public IActionResult DevolverEquipo(int Id_huella, int Cod_prestamo, string Estado_dev)
     {
            service.Recibir_datos(Id_huella, Cod_prestamo, Estado_dev);
            return Ok("Préstamo devuelto correctamente.");
            
     }

}
