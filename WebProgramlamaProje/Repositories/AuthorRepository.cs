using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Repositories
{
	public class AuthorRepository : GenericRepository<Author>
	{
       
        public int DeleteAuthor(int p)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            Author author = authorRepository.Find(x => x.AuthorID == p);
            return authorRepository.TDelete(author);
        }

        public Author FindAuthor(int id)
        {
            AuthorRepository authorRepository = new AuthorRepository();
            return authorRepository.Find(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            AuthorRepository authorRepository = new AuthorRepository();

            Author author = authorRepository.Find(x => x.AuthorID == p.AuthorID);
            author.AuthorName = p.AuthorName;
            return authorRepository.TUpdate(author);
        }
    }
}
