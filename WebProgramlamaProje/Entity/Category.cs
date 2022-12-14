using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public ICollection<Blogs> blogs { get; set; }
    }
}
