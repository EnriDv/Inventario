using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class EquipoController : ControllerBase
{
    private readonly IEquipoService service;  //readonly para solo lectura
    public EquipoController(IEquipoService s)
    {
        service = s;
    }
}