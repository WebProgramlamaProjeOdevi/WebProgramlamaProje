using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        public IActionResult AdminCategoryList()
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            var categories = categoryRepository.TList();
            return View(categories);
        }

        public IActionResult AddNewCategory(Category p)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.AddCategory(p);
            return RedirectToAction("AdminCategoryList");
        }
        public IActionResult DeleteCategory(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.DeleteCategory(id);
            return RedirectToAction("AdminCategoryList");

        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            Category category = categoryRepository.FindCategory(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            categoryRepository.EditCategory(p);
            return RedirectToAction("AdminCategoryList");
        }
    }
}
