using Hikegram.Data.Repositories.Events.Models;

namespace Hikegram.Data.Repositories.Events
{
  public interface IEventRepository
  {
    Task<IEnumerable<Event>> GetAll();
    Task<Event?> Get(int id);
    Task Insert(Event entity);
    Task Update(Event entity);
    Task Delete(Event entity);
  }
}