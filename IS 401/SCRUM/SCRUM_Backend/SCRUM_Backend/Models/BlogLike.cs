namespace SCRUM_Backend;

public class BlogLike
{
    public int LikeId { get; set; }
    public int PostId { get; set; }
    public int UserId { get; set; }

    public BlogPost? Post { get; set; }
    public User? User { get; set; }
}