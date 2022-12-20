using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        public string? CategoryName { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
