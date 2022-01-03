using Hikegram.Services.Users;
using Hikegram.Services.Users.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hikegram.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IUserService _userService;

    public UsersController(IUserService userService)
    {
      _userService = userService;
    }

    [HttpPost()]
    public async Task<IActionResult> Register(UserCreateRequestModel model)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest("Невалидно подадени данни!");
      }

      await _userService.RegisterAsync(model);

      return Ok();
    }
  }
}
