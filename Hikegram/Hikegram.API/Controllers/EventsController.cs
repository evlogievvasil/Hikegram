using Hikegram.Services.Events;
using Hikegram.Services.Events.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hikegram.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class EventsController : ControllerBase
  {
    private readonly IEventService _eventService;
    public EventsController(IEventService eventService)
    {
      _eventService = eventService;
    }

    [HttpPost()]
    public async Task<IActionResult> CreateAsync(EventCreateRequestModel model)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest("Невалидно подадени данни!");
      }

      await _eventService.CreateAsync(model);

      return Ok();
    }
  }
}
