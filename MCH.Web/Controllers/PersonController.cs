using MCH.Contracts.Services;
using MCH.Models.Filters;
using Microsoft.AspNetCore.Mvc;

namespace MCH.Web.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class PersonController : ControllerBase
  {
    private readonly IPersonService _personService;

    public PersonController(IPersonService personService)
    {
      _personService = personService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Get(PersonFilter filter)
    {
      return Ok(await _personService.GetPersonsAsync(filter));
    }
  }
}
