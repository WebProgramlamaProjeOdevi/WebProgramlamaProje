using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Authors
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<Blogs> blogs { get; set; }
    }
}
