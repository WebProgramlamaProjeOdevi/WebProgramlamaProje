using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Repositories;

namespace WebProgramlamaProje.ViewComponents.Comments
{
	public class CommentList : ViewComponent
	{
		CommentRepository commentRepository = new CommentRepository();
		public IViewComponentResult Invoke(int id)
		{
			var comments = commentRepository.GetCommentByID(id);
			return View(comments);
		}
	}
}
