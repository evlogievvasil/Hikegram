using Hikegram.Data.Repositories.Common;
using Hikegram.Data.Repositories.Users;

namespace Hikegram.Data.Repositories.Events.Models
{
  public class Event : BaseEntity
  {
    public string Title { get; set; }

    public int CreatorId { get; set; }
    public User Creator { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? FinishTime { get; set; }
  }
}
