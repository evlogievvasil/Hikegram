using Hikegram.Services.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hikegram.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    [HttpPost()]
    public IActionResult Register(UserCreateRequestModel model)
    {
      if (ModelState.IsValid)
      {
        return BadRequest("Невалидно подадени данни!");
      }

      return Ok();
    }

  }
}
