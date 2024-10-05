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
    [HttpGet("Items")]
    public IActionResult EnviarNoti()
    {
        service.Enviar_Notificacion();
        return Ok();
    }
}
