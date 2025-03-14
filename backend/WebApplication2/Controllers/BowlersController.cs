using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BowlersController : ControllerBase
    {
        private readonly BowlerDbContext _bowlerContext;

        public BowlersController(BowlerDbContext context)
        {
            _bowlerContext = context;
        }

        // GET: api/Bowlers/GetBowlerData
        [HttpGet("GetBowlerData")]
        public IActionResult GetBowlerData()
        {
            // Include the related team data with each bowler.
            var bowlers = _bowlerContext.Bowlers.Include(b => b.Team).Where(b => b.Team.TeamName == "Marlins" || b.Team.TeamName == "Sharks").ToList();
            return Ok(bowlers);
        }
    }
}
