using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Migrations;

namespace WebProgramlamaProje.Controllers
{
	[Authorize(Roles = "admin")]
	public class AdminController : Controller
	{
		public IActionResult Display()
		{
			return View();
		}
	}
}
