using cadeteria.Models;
using Microsoft.AspNetCore.Mvc;

namespace cadeteria.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CadeteController : ControllerBase
{
    private readonly ICadeteRepository _dbCadete;
    private readonly ILogger<CadeteController> _logger;


    public CadeteController(ILogger<CadeteController> logger, ICadeteRepository cadete)
    {
        _dbCadete = cadete;
        _logger = logger;
    }

    [HttpGet]
    [Route("lista")]

    public IActionResult Get()
    {
        return Ok(_dbCadete.Get());
    }
    [HttpPost]
    public IActionResult Post([FromBody] Cadetes cadete)
    {
        _dbCadete.Save(cadete);
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Cadetes cadete)
    {
        _dbCadete.Update(id, cadete);
        return Ok();
    }
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        _dbCadete.Delete(id);
        return Ok();
    }
}
