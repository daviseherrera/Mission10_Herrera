using Microsoft.EntityFrameworkCore;

namespace Mission06_Herrera.Models;

public class MovieSubmissionContext : DbContext
{
    public DbSet<Submission> Submissions { get; set; }
    
    public MovieSubmissionContext(DbContextOptions<MovieSubmissionContext> options) : base(options) // Constructor
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Add the configuration for the Submission entity
        modelBuilder.Entity<Submission>()
            .HasKey(s => s.SubmissionId); // Mark the entity's key
    }

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
}