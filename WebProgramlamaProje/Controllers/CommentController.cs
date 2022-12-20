using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.Controllers
{
    public class CommentController : Controller
    {
        CommentRepository commentRepository = new CommentRepository();
        [HttpGet]
        public PartialViewResult LeaveComment(int id)
        {
            var comments = commentRepository.GetCommentByID(id);
            return PartialView(comments);
        }
        [HttpPost]
        public IActionResult LeaveComment(Comment comment)
        {
			comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
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
