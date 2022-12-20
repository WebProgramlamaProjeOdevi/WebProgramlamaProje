using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        public string CityName { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
