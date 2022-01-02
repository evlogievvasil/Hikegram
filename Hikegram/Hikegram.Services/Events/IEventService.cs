using Hikegram.Services.Events.Models;

namespace Hikegram.Services.Events
{
  public interface IEventService
  {
    Task CreateAsync(EventCreateRequestModel model);
  }
}