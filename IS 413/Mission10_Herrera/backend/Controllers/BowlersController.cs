using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Herrera.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BowlersController : ControllerBase
{
    private readonly BowlingDbContext _context;

    public BowlersController(BowlingDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bowler>>> Get()
    {
        var bowlers = await _context.Bowlers
            .Include(b => b.Team)
            .Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks")
            .ToListAsync();

        return Ok(bowlers);
    }
}