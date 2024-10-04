using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class NotificacionController : ControllerBase
{
    private readonly INotificacionService service;  //readonly para solo lectura
    public NotificacionController(INotificacionService s)
    {
        service = s;
    }


    [HttpGet("noti")]
    public IActionResult MostrarEquipos()
    {
        service.Respuesta_Solicitud();
        return Ok();
    }
}