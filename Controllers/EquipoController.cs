using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class EquipoController : ControllerBase
{
    public IEnumerable<Equipos>? list;
    private readonly IEquipoService service;  //readonly para solo lectura
    public EquipoController(IEquipoService s)
    {
        service = s;
    }

    [HttpGet("seeEquipos")]
    public IEnumerable<Equipos> MostrarEquipos()
    {
        //list = service.MostrarEquipos();
        return service.MostrarEquipos();
    }

    [HttpPost("addEquipo")]
    public IActionResult RegistrarEquipo([FromBody] Equipos nuevoEquipo)
    {
        if(service.RegistrarEquipo(nuevoEquipo))
        {
            return Ok("Se registro Correctamente el Usuario.");
        }
        return Ok("Ha ocurrido un error al registrar el usuario.");
    }
}