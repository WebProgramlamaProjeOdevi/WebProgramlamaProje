using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class BlogRepository : GenericRepository<Blog>
	{
		public List<Blog> BlogGetByID(int id)
		{
			BlogRepository blogRepository = new BlogRepository();
			return blogRepository.List(x=>x.BlogID== id);

		}
	}
}
