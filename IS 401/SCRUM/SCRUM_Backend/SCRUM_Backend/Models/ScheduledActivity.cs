namespace SCRUM_Backend;

public class ScheduledActivity
{
    public int ScheduleId { get; set; }
    public int ActivityId { get; set; }
    public int ScheduledBy { get; set; }
    public DateTime ScheduledTime { get; set; }
    public string Location { get; set; } = null!;

    public Activity? Activity { get; set; }
    public User? ScheduledByUser { get; set; }
}