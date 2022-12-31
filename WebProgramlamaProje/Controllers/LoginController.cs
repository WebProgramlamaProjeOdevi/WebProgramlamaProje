using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    public class LoginController : Controller
    {
		Context c = new Context();
		AuthorRepository authorRepository = new AuthorRepository();

		[HttpGet]
		public IActionResult AdminLogin()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AdminLogin(Admin admin)
        {

			var adminInfo = c.Admins.FirstOrDefault(x => x.AdminEmail == admin.AdminEmail);
			if (adminInfo != null)
			{
				
				return RedirectToAction("AdminCategoryList", "Category");

			}
			else
			{
				return RedirectToAction("AdminLogin", "Login");
			}
		}
		[HttpGet]
		public IActionResult UserRegister()
		{
			return View();
		}
		[HttpPost]
		public IActionResult UserRegister(Author p)
		{
			authorRepository.AddAuthor(p);
			return RedirectToAction("UserLogin");
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
