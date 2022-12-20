using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Controllers
{
    public class CommentController : Controller
    {
        [HttpGet]
        public IActionResult LeaveComment(int id)
        {
            //Bloglara yorum yap get
            return View();
        }
        [HttpPost]
        public IActionResult LeaveComment(Comment comment)
        {
            //Bloglara yorum yap post
            return View();
        }

        public IActionResult GetAllComments(int id)
        {
            //bütün yorumları listele
            return View();
        }
        public IActionResult AdminDeleteComments(int id)
        {
            //Admin yorumları siler
            return View();
        }
        

    }
}
