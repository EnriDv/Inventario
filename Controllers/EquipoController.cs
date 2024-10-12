using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[ApiController]
[Route("api/equipos")]
public class EquipoController : ControllerBase
{
    private readonly IEquipoService _equipoService;
    private readonly IClasificacion _clasificacionService;

    public EquipoController(IEquipoService equipoService, IClasificacion clasificacionService)
    {
        _equipoService = equipoService;
        _clasificacionService = clasificacionService;
    }

    // Método para agregar un nuevo equipo
    [HttpPost("agregar")]
    public IActionResult AgregarEquipo([FromBody] Equipo equipo)
    {
        if (equipo == null)
        {
            return BadRequest("El equipo no puede ser nulo.");
        }

        try
        {
            _equipoService.AgregarEquipo(equipo);
            return Ok("Equipo agregado con éxito.");
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    // Otros métodos (Actualizar, Eliminar, Obtener)
    [HttpPut("actualizar")]
    public IActionResult ActualizarEquipo([FromBody] Equipo equipoActualizado)
    {
        if (equipoActualizado == null)
        {
            return BadRequest("El equipo actualizado no puede ser nulo.");
        }

        try
        {
            _equipoService.ActualizarEquipo(equipoActualizado);
            return Ok("Equipo actualizado con éxito.");
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("eliminar/{id}")]
    public IActionResult EliminarEquipo(int id)
    {
        try
        {
            _equipoService.EliminarEquipo(id);
            return Ok("Equipo eliminado con éxito.");
        }
        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("{id}")]
    public IActionResult ObtenerEquipoPorId(int id)
    {
        try
        {
            var equipo = _equipoService.ObtenerEquipoPorId(id);
            return Ok(equipo);
        }
        catch (System.Exception ex)
        {
            return NotFound(ex.Message);
        }
    }

    [HttpGet]
    public IActionResult ObtenerTodosLosEquipos()
    {
        var equipos = _equipoService.ObtenerTodosLosEquipos();
        return Ok(equipos);
    }

    [HttpGet("por-categoria/{categoriaId}")]
    public IActionResult ObtenerEquiposPorCategoria(int categoriaId)
    {
        var equipos = _equipoService.ObtenerEquiposPorCategoria(categoriaId);
        return Ok(equipos);
    }
}



