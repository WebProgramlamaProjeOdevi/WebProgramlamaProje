using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsApiController : ControllerBase
    {
        private readonly BlogsApiContext _context;
        public BlogsApiController(BlogsApiContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async<IActionResult> GET()
        {

        }
    }
}
