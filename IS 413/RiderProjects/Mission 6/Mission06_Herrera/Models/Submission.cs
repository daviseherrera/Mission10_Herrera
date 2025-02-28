using System.ComponentModel.DataAnnotations;

namespace Mission06_Herrera.Models;

public class Submission
{
    public int SubmissionId { get; set; }

    [Required]  // Ensures Category is required
    public string Category { get; set; } = string.Empty;

    [Required]  // Ensures Title is required
    public string Title { get; set; } = string.Empty;

    [Required]  // Ensures Year is required
    public int Year { get; set; }

    [Required]  // Ensures Director is required
    public string Director { get; set; } = string.Empty;

    [Required]  // Ensures Rating is required
    public string Rating { get; set; } = string.Empty;

    public bool Edited { get; set; }   

    public string? LentTo { get; set; }  // Nullable (optional)

    public string? Notes { get; set; }   // Nullable (optional)
}