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

		public int CommentAdd(Comment comment)
		{
            CommentRepository commentRepository = new CommentRepository();			
            return commentRepository.TAdd(comment);
		}

		public int DeleteComment(int id)
		{
			CommentRepository commentRepository = new CommentRepository();  
			Comment comment = commentRepository.Find(x=>x.CommentID==id);
			return commentRepository.TDelete(comment);
		}
	}
}
