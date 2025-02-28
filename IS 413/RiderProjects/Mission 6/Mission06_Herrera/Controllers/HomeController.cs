using System.Diagnostics;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Mission06_Herrera.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Mission06_Herrera.Controllers;

public class HomeController : Controller
{
    private MovieSubmissionContext _context;
    
    public HomeController(MovieSubmissionContext temp) // Constructor
    {
        _context = temp;
    }
    
    public IActionResult Index()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult GetToKnowJoel()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult MovieSubmission()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> MovieSubmission(MovieSubmissionContext.Submission response)
    {
        // Ensure LentTo and Notes are stored as NULL instead of empty strings
        response.LentTo = string.IsNullOrWhiteSpace(response.LentTo) ? null : response.LentTo;
        response.Notes = string.IsNullOrWhiteSpace(response.Notes) ? null : response.Notes;

        int retryCount = 3; // Number of retries
        while (retryCount > 0)
        {
            try
            {
                _context.Submissions.Add(response); // Add record to the database
                await _context.SaveChangesAsync(); // Use async to avoid blocking
                return View("Confirmation", response);
            }
            catch (Microsoft.Data.Sqlite.SqliteException ex) when (ex.SqliteErrorCode == 5) // SQLite Error 5: Database is locked
            {
                retryCount--;
                if (retryCount == 0)
                    throw; // Re-throw the exception if retries are exhausted
                await Task.Delay(100); // Wait for 100ms before retrying
            }
        }
        return View("Error"); // Fallback in case of failure
    }
}