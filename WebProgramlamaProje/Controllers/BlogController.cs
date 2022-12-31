using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    [Authorize]
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
            BlogRepository blogRepository = new BlogRepository();
            blogRepository.DeleteBlog(id);
            return RedirectToAction("AdminGetAllBlogs");
        }
        public IActionResult AuthorGetBlogs() 
        { 
            //Yazarın blogları listele
            return View(); 
        }

        [HttpGet]
        public IActionResult AuthorAddNewBlog()
        {
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList();
            ViewBag.values = values;
            List<SelectListItem> values2 = (from x in c.Authors.ToList() select new SelectListItem { Text = x.AuthorName, Value = x.AuthorID.ToString() }).ToList();
            ViewBag.values2 = values2;
            return View();
        }
        [HttpPost]
        public IActionResult AuthorAddNewBlog(Blog b)
        {
            //Yazar yeni blog ekle post
            BlogRepository blogRepository = new BlogRepository();
            blogRepository.AddBlog(b);
            return RedirectToAction("AdminGetAllBlogs");
        }
        public IActionResult AuthorDeleteBlog(int id)
        {
            //Yazar blog sil

            return RedirectToAction("AdminGetAllBlogs");
        }
        [HttpGet]
        public IActionResult AuthorUpdateBlog(int id)
        {
            BlogRepository blogRepository = new BlogRepository();
            Blog blog = blogRepository.FindBlog(id);
            Context c = new Context();
            List<SelectListItem> values = (from x in c.Categories.ToList() select new SelectListItem { Text = x.CategoryName, Value = x.CategoryID.ToString() }).ToList();
            ViewBag.values = values;
            List<SelectListItem> values2 = (from x in c.Authors.ToList() select new SelectListItem { Text = x.AuthorName, Value = x.AuthorID.ToString() }).ToList();
            ViewBag.values2 = values2;
            return View(blog);
        }
        [HttpPost]
        public IActionResult AuthorUpdateBlog(Blog p)
        {
            BlogRepository blogRepository = new BlogRepository();
            blogRepository.EditBlog(p);
            return RedirectToAction("AdminGetAllBlogs");
        }       
     
    }
}
