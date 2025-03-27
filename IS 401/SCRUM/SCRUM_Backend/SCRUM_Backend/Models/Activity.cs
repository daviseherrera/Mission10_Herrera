namespace SCRUM_Backend;

public class Activity
{
    public int ActivityId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Category { get; set; } = null!; // 'Spiritual', 'Social', etc.

    public ICollection<BlogPost>? BlogPosts { get; set; }
    public ICollection<ScheduledActivity>? ScheduledActivities { get; set; }
}