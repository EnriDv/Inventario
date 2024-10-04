using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Prestamos.Services;
using Prestamos;



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
    [HttpGet("EnviarSolicitud{id_Item}")]
    public IActionResult EnviarSoli(int id_Item)
    {
        var result = service.Enviar_Solicitud(id_Item);
        if(result){
            var solicitud = new SolicitudPrestamo();
            solicitudes.Add(solicitud);
            return Ok("agregacion correcta");
        }
        return Ok("agregacion no completada");
    }

    [HttpGet("VerSolicitudes")]
    public IEnumerable<SolicitudPrestamo> VerSoli()
    {
        var result = service.VerSolicitudes(1);
        return solicitudes;
    }
}
