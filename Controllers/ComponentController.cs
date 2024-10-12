using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;
using Inventario.Services;
using Inventario;


[ApiController]
[Route("[controller]")]
public class ComponentController : ControllerBase
{
    private readonly IComponentService service;  
    public ComponentController(IComponentService servicio)
    {
        service = servicio;
    }

    [HttpPost("CrearComponente")]
    public IActionResult Crear([FromBody] Entrada entrada)
    {
        var result = service.CrearComponente(entrada.Secuencia, entrada.nombre, entrada.IMT); 
        return Ok(result);
    }
    [HttpGet("VerComponentes")]
    public IEnumerable<Componente> Ver1()
    {
        var result = service.verComponentesTodos(); 
        return result;
    }
    [HttpGet("VerComponente")]
    public IEnumerable<Componente> Ver2(int id)
    {
        var result = service.verComponentesEquipo(id); 
        return result;
    }
}

public class Entrada {
    public int Secuencia {get; set;}
    public string nombre {get; set;} = null!;
    public int IMT {get; set;}
}
