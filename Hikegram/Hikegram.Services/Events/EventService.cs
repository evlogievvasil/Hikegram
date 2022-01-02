using AutoMapper;
using Hikegram.Data.Repositories.Events;
using Hikegram.Data.Repositories.Events.Models;
using Hikegram.Services.Common;
using Hikegram.Services.Events.Models;

namespace Hikegram.Services.Events
{
  public class EventService : BaseService, IEventService
  {
    private readonly IEventRepository _eventRepository;

    public EventService(IMapper mapper,
      IEventRepository eventRepository) : base(mapper)
    {
      _eventRepository = eventRepository;
    }

    public async Task CreateAsync(EventCreateRequestModel model)
    {
      if (model == null)
      {
        throw new ArgumentNullException("Невалидно подаден елемент за създаване.");
      }

      var entity = _mapper.Map<Event>(model);

      await _eventRepository.Insert(entity);
    }
  }
}
