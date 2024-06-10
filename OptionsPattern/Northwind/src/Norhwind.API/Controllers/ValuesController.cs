using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Norhwind.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ValuesController : ControllerBase
{
    private readonly DatabaseOptions _databaseOptions;

    public ValuesController(IOptions<DatabaseOptions> databaseOptions)
    {
        _databaseOptions = databaseOptions.Value;
    }

    [HttpGet]
    public IActionResult GetDatabaseOptions()
    {
        return Ok(_databaseOptions);
    }
}
