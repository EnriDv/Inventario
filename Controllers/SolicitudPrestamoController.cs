using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Services;
using Prestamos;



[ApiController]
[Route("[controller]")]
public class SolicitudPrestamoController : ControllerBase
{
    private readonly ISolcitudPrestamoService service;
    public SolicitudPrestamoController(ISolcitudPrestamoService s)
    {
        service = s;
    }
    [HttpGet("EnviarSolicitud")]
    public IActionResult EnviarSoli(SolicitudPrestamo soli)
    {
        var result = service.Enviar_Solicitud(soli);
        return Ok(result);
    }

    [HttpGet("VerSolicitudes")]
    public IActionResult VerSoli(int idUser)
    {
        var result = service.VerSolicitudes(idUser);
        return Ok(result);
    }
}
