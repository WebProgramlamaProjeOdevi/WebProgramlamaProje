using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Display()
        {
            return View();
        }
    }
}
