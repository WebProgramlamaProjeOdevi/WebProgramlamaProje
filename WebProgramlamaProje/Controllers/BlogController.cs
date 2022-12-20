using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult AdminGetAllBlogs()
        {
            //Bütün blogları listele
            BlogRepository blogRepository = new BlogRepository();
            return View(blogRepository.TList("Category"));
        }

        public IActionResult DeleteBlog(int id)
        {
            //Blogları sil
            return View();
        }
        public IActionResult AuthorGetBlogs() 
        { 
            //Yazarın blogları listele
            return View(); 
        }
        [HttpGet]
        public IActionResult AuthorAddNewBlog(Blog blog)
        {
            //Yazar yeni blog ekle get
            return View();
        }
        [HttpPost]
        public IActionResult AuthorAddNewBlog(int id)
        {
            //Yazar yeni blog ekle post
            return RedirectToAction("AuthorGetBlogs");
        }
        public IActionResult AuthorDeleteBlog(int id)
        {
            //Yazar blog sil
            return RedirectToAction("AuthorGetBlogs");
        }
        [HttpGet]
        public IActionResult AuthorUpdateBlog(int id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult AuthorUpdateBlog(Blog p)
        {
            return RedirectToAction("AuthorGetBlogs");
        }
    }
}
