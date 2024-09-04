using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SimpleProjectApi.Models;

[Route("api/[controller]")]
[ApiController]
public class AuthController : Controller
{
    private readonly ApplicationDbContext _context;

     public AuthController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet("/")]
    public IActionResult Login()
    {
        return View();
    }


    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginModel model)
    {
        var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == model.Username && u.Password == model.Password);

        if (user != null)
        {
            return Ok(new { success = true });
        }

        return Unauthorized(new { success = false });
    }
}

public class LoginModel
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}
