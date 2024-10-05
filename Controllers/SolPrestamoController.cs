using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class RegistrarPrestamoController : ControllerBase
{
    private readonly ISolPrestamoService service;  //readonly para solo lectura
    public RegistrarPrestamoController(ISolPrestamoService enviar)
    {
        service = enviar;
    }
    [HttpGet("Enviar")]
    public IActionResult EnviarSol(int Id_Equipo, string Detalle)
    {
        service.Enviar_Solicitud(Id_Equipo, Detalle);
        return Ok();
    }
}
