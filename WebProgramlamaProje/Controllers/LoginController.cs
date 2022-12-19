using Microsoft.AspNetCore.Mvc;

namespace WebProgramlamaProje.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult AdminLogin()
        {
            return View();
        }
		public IActionResult UserRegister()
		{
			return View();
		}

		public IActionResult UserLogin()
		{
			return View();
		}
		public IActionResult Logout()
		{
			return View();
		}
	}
}
