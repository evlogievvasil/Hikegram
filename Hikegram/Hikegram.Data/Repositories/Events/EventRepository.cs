using Hikegram.Data.Repositories.Common;
using Hikegram.Data.Repositories.Events.Models;

namespace Hikegram.Data.Repositories.Events
{
  public class EventRepository : Repository<Event>, IEventRepository
  {
    public EventRepository(HikegramDbContext context) : base(context)
    {
    }
  }
}