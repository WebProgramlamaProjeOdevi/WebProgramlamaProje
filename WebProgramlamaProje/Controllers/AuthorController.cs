using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
