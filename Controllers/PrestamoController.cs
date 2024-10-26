using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;



[ApiController]
[Route("[controller]")]
public class PrestamoController : ControllerBase
{
    private readonly IPrestamoService serviceprestamo;  //readonly para solo lectura
    public PrestamoController(IPrestamoService servicioprestamo)
    {
        serviceprestamo = servicioprestamo;
    }

    [HttpGet("equipos")]
    public IEnumerable<Equipo> MostrarEquipos()
    {
        return serviceprestamo.mostrar_equipos();
    }

    [HttpGet("equipos-prestados")]
    public IEnumerable<Equipo> MostrarEquiposPrestados()
    {
        return serviceprestamo.mostrar_equipos_prestados();
    }

    [HttpPost("devolver-equipo")]
    public IActionResult DetallePrestamo([FromBody] string idEquipo)
    {
        bool verificar = serviceprestamo.cambiar_estado_equipo(int.Parse(idEquipo));
        if(verificar)
        {
            return Ok("Se devolvio el equipo correctamente");
        }
        return BadRequest(new { mensaje = "No se pudo devolver el equipo, verifique el ID del equipo." }); 
    }

}