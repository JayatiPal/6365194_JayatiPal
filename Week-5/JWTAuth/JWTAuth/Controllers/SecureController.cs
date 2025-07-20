using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecureController : ControllerBase
    {
        [Authorize]
        [HttpGet("secret")]
        public IActionResult GetSecret()
        {
            var username = User.Identity?.Name;
            return Ok($"Welcome {username}, this is a protected API response.");
        }
    }
}
