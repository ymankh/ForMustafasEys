using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForMustafasEys.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Jacoub_sController : ControllerBase
    {
        // Yaman is a man

        public async Task<IActionResult> getname() {
            return Ok();
        }
    }
}
