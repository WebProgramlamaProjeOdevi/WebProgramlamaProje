using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class CommentRepository : GenericRepository<Comment>
	{
		public List<Comment> GetCommentByID(int id)
		{
			CommentRepository commentRepository = new CommentRepository();
			return commentRepository.List(x => x.BlogID == id);

		}
	}
}
