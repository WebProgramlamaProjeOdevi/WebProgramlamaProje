using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebProgramlamaProje.Entity
{
	public class Context : IdentityDbContext<AppUser>
    {        
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-S43BMFO\\SQLEXPRESS;database=WebProgramlamaDb;integrated security=true;Encrypt=false");
		}
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Author> Authors { get; set; }	
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Comment> Comments { get; set; }

	}
}
