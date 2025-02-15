using System.Diagnostics;
using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using Mission06_Herrera.Models;

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
    public IActionResult MovieSubmission(MovieSubmissionContext.Submission response)
    {
        _context.Submissions.Add(response); // Add record to the database
        _context.SaveChanges();
        
        return View("Confirmation", response);
    }
}