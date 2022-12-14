using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Blogs
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? imageadress { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int? AuthorId { get; set; }
        public virtual Authors Authors { get; set; }

        public ICollection<Comments>  comments { get; set; }

    }
}
