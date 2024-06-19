using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WalkIn_Portal_Backend.Models;

namespace WalkIn_Portal_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class LoginController : ControllerBase
    {
        private readonly WalkinPortalContext? _context;
        private readonly IConfiguration _config;

        public LoginController(WalkinPortalContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }


        [HttpPost("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var job = await _context.Jobs.ToListAsync();
            return Ok(job);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add(ExperiencedHasTechnologiesExpertise experiencedHasTechnologiesExpertise)
        {
            _context.ExperiencedHasTechnologiesExpertises.Add(experiencedHasTechnologiesExpertise);
            await _context.SaveChangesAsync();
            return Ok(experiencedHasTechnologiesExpertise);
            //return Ok("Hello");
        }
    }
}
