using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class SolicitudPrestamoController : ControllerBase
{
    private readonly ISolicitudPrestamoService service;  //readonly para solo lectura
    public SolicitudPrestamoController(ISolicitudPrestamoService servicio)
    {
        service = servicio;
    }

    [HttpGet("verPrestamos")]
    public IEnumerable<SolicitudPrestamo> MostrarPrestamos()
    {
        return service.mostrarSolicitudesPrestamo();
    }

    [HttpPost("detalle")]
    public IActionResult DetallePrestamo([FromBody] int IdSolicitudPrestamo)
    {
        SolicitudPrestamo soli = service.mostrarDetalleSolicitudPrestamo(IdSolicitudPrestamo);
        return Ok($"{soli.UsuarioSolicitante.nombre}, {soli.EquipoSolicitado.Nombre_equipo}, {soli.estadoSolicitud}");
    }
}