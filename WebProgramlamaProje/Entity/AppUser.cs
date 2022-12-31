using Microsoft.AspNetCore.Identity;

namespace WebProgramlamaProje.Entity
{
	public class AppUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string? ProfilePicture { get; set; }
	}
}
