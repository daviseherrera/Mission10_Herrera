namespace SCRUM_Backend;

public class Ward
{
    public int WardId { get; set; }
    public string WardName { get; set; } = null!;
    public int LeaderId { get; set; }

    public User? Leader { get; set; }
}