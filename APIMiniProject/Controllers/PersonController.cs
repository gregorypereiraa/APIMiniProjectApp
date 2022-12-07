using APIMiniProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIMiniProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public void Post([FromBody] PersonModel data)
    {
        _logger.LogInformation("The person was logged as {Person}", data);
    }
}