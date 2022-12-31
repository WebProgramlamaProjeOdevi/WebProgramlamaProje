using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebProgramlamaProje.Models;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            BlogRepository blogRepository = new BlogRepository();
            return View(blogRepository.TList("Author"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AllBlogs() 
        {
            BlogRepository blogRepository = new BlogRepository();
            return View(blogRepository.TList("Author"));
        }

        public IActionResult BlogDetails(int id) 
        {
            BlogRepository blogRepository = new BlogRepository();
            ViewBag.id = id;
            var blogDetailList = blogRepository.BlogGetByID(id);
            return View(blogDetailList);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}