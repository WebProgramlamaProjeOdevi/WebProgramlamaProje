using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Blogs
    {
        [Key]
        public int BlogID { get; set; }

        public string? BlogName { get; set; }
        public string? Description { get; set; }
        public string? ImageAdress { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public int? AuthorId { get; set; }
        public virtual Authors Authors { get; set; }

        public ICollection<Comments>  Comments { get; set; }

    }
}
