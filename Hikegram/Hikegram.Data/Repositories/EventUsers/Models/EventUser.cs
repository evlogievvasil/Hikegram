using Hikegram.Data.Repositories.Common;
using Hikegram.Data.Repositories.Events.Models;
using Hikegram.Data.Repositories.Users;

namespace Hikegram.Data.Repositories.EventUsers.Models
{
  public class EventUser : BaseEntity
  {
    public IEnumerable<Event> Events { get; set; } = new HashSet<Event>();

    public IEnumerable<User> Users { get; set; } = new HashSet<User>();
  }
}