using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string? BlogName { get; set; }
        public string? Description { get; set; }
        public string? ImageAdress { get; set; }
        public DateTime BlogDate { get; set; }


        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Comment>  Comments { get; set; }

    }
}
