namespace Hikegram.Services.Events.Models
{
  public class EventCreateRequestModel
  {
    public string Title { get; set; }

    public int CreatorId { get; set; }

    public string Location { get; set; }

    public string Description { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? FinishTime { get; set; }
  }
}