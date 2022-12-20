using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string NameSurname { get; set; }
        public string CommentText { get; set; }
        public string CommentMail { get; set; }
        public DateTime CommentDate { get; set; }
        
        
        public int BlogID { get; set; } 
        public Blog Blog { get; set; }
        

    }
}
