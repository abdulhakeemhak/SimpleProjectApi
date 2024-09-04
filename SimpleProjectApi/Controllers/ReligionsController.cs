using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleProjectApi.Models;

namespace SimpleProjectApi.Controllers
{
    [Route("religions")]
    [ApiController]
    public class ReligionsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReligionsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: /Religions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Religion>>> GetReligions()
        {
            return await _context.Religions.ToListAsync();
        }
    }
}
