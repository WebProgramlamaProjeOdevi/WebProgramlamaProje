using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; } 
        public string AuthorName { get; set; }
        public string AuthorPassword { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
