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
        solicitudes = new List<SolicitudPrestamo>(){};
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

    [HttpGet("VerSolicitudes{idUser}")]
    public IEnumerable VerSoli(int idUser)
    {
        var result = service.VerSolicitudes(idUser);
        return Ok(solicitudes);
    }
}
