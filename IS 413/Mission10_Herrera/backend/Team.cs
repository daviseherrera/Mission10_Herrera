namespace Mission10_Herrera;

public class Team
{
    public int TeamID { get; set; }
    public string? TeamName { get; set; }

    // Optional: if you want to access all the bowlers on this team
    public ICollection<Bowler>? Bowlers { get; set; }
}