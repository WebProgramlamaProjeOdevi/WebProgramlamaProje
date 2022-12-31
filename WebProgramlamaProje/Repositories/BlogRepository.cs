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

        public int AddBlog(Blog p)
        {
            BlogRepository blogRepository = new BlogRepository();    
            return blogRepository.TAdd(p);
        }


        public int DeleteBlog(int p)
        {
            BlogRepository blogRepository = new BlogRepository();
            Blog blog = blogRepository.Find(x => x.BlogID == p);
            return blogRepository.TDelete(blog);
        }

        public Blog FindBlog(int id)
        {
            BlogRepository blogRepository = new BlogRepository();
            return blogRepository.Find(x => x.BlogID == id);
        }
        public int EditBlog(Blog p)
        {
            BlogRepository blogRepository = new BlogRepository();

            Blog blog = blogRepository.Find(x => x.BlogID == p.BlogID);
            blog.BlogName = p.BlogName;
            blog.CategoryID = p.CategoryID;
            blog.AuthorID = p.AuthorID;
            blog.Description = p.Description;
            blog.ImageAdress= p.ImageAdress;
            blog.BlogDate= p.BlogDate;
            return blogRepository.TUpdate(blog);
        }

    }
}
