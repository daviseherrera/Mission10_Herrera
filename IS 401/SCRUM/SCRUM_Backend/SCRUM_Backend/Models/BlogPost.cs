namespace SCRUM_Backend;

public class BlogPost
{
    public int PostId { get; set; }
    public int UserId { get; set; }
    public int ActivityId { get; set; }
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public DateTime CreatedAt { get; set; }

    public User? User { get; set; }
    public Activity? Activity { get; set; }
    public ICollection<BlogLike>? Likes { get; set; }
}