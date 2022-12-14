using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public string NameSurname { get; set; }

        public string CommentText { get; set; }

        public DateTime CommentDate { get; set; }
        public int BlogID { get; set; } 
        public Blogs Blogs { get; set; }
        

    }
}
