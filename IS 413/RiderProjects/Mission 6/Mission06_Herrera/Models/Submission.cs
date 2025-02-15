using System.ComponentModel.DataAnnotations;

namespace Mission06_Herrera.Models;

public class Submission
{
    public int SubmissionId { get; set; }
    
    public string Category { get; set; } = String.Empty;
    public string Title { get; set; } = String.Empty;
    public int Year { get; set; }
    public string Director { get; set; } = String.Empty;
    public string Rating { get; set; } = String.Empty;
    public bool Edited { get; set; }   
    public string LentTo { get; set; } = String.Empty;
    public string Notes { get; set; } = String.Empty;
}