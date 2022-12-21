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
            ViewBag.id = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult LeaveComment(Comment comment)
        {
			//comment.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            commentRepository.CommentAdd(comment);
            return RedirectToAction("Index", "Home");
        }    
        public IActionResult AdminDeleteComments(int id)
        {
            
            commentRepository.DeleteComment(id);
            return RedirectToAction("AdminGetAllComments", "Comment");
        }
        public IActionResult AdminGetAllComments()
        {
			CommentRepository commentRepository = new CommentRepository();
			return View(commentRepository.TList("Blog"));
		}

    }
}
