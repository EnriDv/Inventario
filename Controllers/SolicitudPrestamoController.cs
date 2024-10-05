using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Inventario.Services;
using Inventario;



[ApiController]
[Route("[controller]")]
public class SolicitudPrestamoController : ControllerBase
{
    private readonly ISolcitudPrestamoService service;
    private readonly List<SolicitudPrestamo> solicitudes;

    public SolicitudPrestamoController(ISolcitudPrestamoService s)
    {
        service = s;
        solicitudes = new List<SolicitudPrestamo>(){
            new SolicitudPrestamo(),
            new SolicitudPrestamo(),
            new SolicitudPrestamo()
        };
    }
    [HttpPost("EnviarSolicitud")]
    public IActionResult EnviarSoli([FromBody] SolicitudPrestamo solicitud)
    {
        var result = service.Enviar_Solicitud(solicitud);
        if(result){
            solicitudes.Add(solicitud);
            return Ok("agregacion correcta");
        }
        return Ok("agregacion no completada");
    }

    [HttpGet("VerSolicitudes{id}")]
    public IEnumerable<SolicitudPrestamo> VerSoli(int id)
    {
        var result = service.VerSolicitudes(id);
        return result;
    }
}
