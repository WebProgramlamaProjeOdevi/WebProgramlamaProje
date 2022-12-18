using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }
		public string AdminEmail { get; set; }
		public string AdminPassword { get; set; }
	}
}
