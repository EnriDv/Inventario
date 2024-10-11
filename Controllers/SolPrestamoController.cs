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
    [HttpPost("Enviar")]
    public IActionResult EnviarSol([FromBody] SolicitudDTO solicitud)
    {
        service.Enviar_Solicitud(solicitud.Id_Equipo, solicitud.Detalle);
        return Ok("Aloha");
    }


    public class SolicitudDTO
    {
        public int Id_Equipo { get; set; }
        public string Detalle { get; set; }
    }

}


