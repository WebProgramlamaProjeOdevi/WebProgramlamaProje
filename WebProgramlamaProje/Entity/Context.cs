using Microsoft.EntityFrameworkCore;

namespace WebProgramlamaProje.Entity
{
	public class Context : DbContext
	{
		protected override void OnConfiguring ( DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-S43BMFO\\SQLEXPRESS;database=WebProgramlamaDb;integrated security=true;Encrypt=false");
		}
		public DbSet<Admin> Admins { get; set; }
		public DbSet<Authors> Authors { get; set; }	
		public DbSet<Blogs> Blogs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<City> Cities { get; set; }
		public DbSet<Comments> Comments { get; set; }

	}
}
