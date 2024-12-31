using Microsoft.AspNetCore.Mvc;

namespace NewWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult GetWeather()
    {
        
        return Ok("*******************************\n\n\n\nhello, hny 2025!\n\n\n\n**********************************");
    }
}
