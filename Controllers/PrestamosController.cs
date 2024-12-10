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
}