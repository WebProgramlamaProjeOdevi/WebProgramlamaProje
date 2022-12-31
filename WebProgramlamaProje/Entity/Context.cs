using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebProgramlamaProje.Entity
{
	public class Context : IdentityDbContext<AppUser>
    {        
        protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Encrypt=false");
		}
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Author> Authors { get; set; }	
		public DbSet<Blog> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Comment> Comments { get; set; }

	}
}
