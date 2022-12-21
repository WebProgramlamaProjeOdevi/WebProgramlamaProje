using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    public class AuthorController : Controller
    {
        public IActionResult AuthorList()
        {
            AuthorRepository authorRepository = new AuthorRepository();
            var authors = authorRepository.TList();
            return View(authors);
        }
        
        public IActionResult DeleteAuthor(int id)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            authorRepository.DeleteAuthor(id);
            return RedirectToAction("AuthorList");

        }

        [HttpGet]
        public IActionResult EditAuthor(int id)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            Author author = authorRepository.FindAuthor(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult EditAuthor(Author p)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            authorRepository.EditAuthor(p);
            return RedirectToAction("AuthorList");
        }
    }
}
