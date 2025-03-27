namespace SCRUM_Backend;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string Role { get; set; } = null!; // 'Leader', 'Youth', 'Admin'
    
    // Relationships
    public ICollection<BlogPost>? BlogPosts { get; set; }
    public ICollection<BlogLike>? BlogLikes { get; set; }
    public ICollection<ScheduledActivity>? ScheduledActivities { get; set; }
}