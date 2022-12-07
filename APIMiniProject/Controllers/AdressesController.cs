using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AdressesController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public AdressesController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public void Post([FromBody] AddressModel data)
    {
        _logger.LogInformation("The person was logged as {Address}", data);
    }
}