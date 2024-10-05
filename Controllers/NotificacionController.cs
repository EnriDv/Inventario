using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Inventario.Services;


[ApiController]
[Route("[controller]")]
public class NotificacionController : ControllerBase
{
    private readonly INotificacionService service;  
    public NotificacionController(INotificacionService s)
    {
        service = s;
    }
    [HttpGet("NotificacionVacia")]
    public IActionResult NotificacionVacia()
    {
        var result = service.Crear_Notificacion(); 
        return Ok(result);
    }
}
