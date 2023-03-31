using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pioneer_Online_Library.Core.Data;
using Pioneer_Online_Library.Domain.Model;


namespace Pioneer_Online_Library.Infrastructure
{
	public class PioneerDbContext : IdentityDbContext<AppUser>
	{
		public PioneerDbContext(DbContextOptions<PioneerDbContext> option) : base(option)
		{
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{

			 modelBuilder.Seed();
			base.OnModelCreating(modelBuilder);


		}


		public DbSet<Book> Books { get; set; } = null!;
		public DbSet<Review> Reviews { get; set; } = null!;
		public DbSet<AppUser> AppUsers { get; set; } = null!;


	}
}
