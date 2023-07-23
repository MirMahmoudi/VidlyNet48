using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VidlyNet48.Presentation.Models.IdentityModels
{
	// You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.

	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MembershipType> MembershipTypes { get; set; }
		public DbSet<Genre> Genres { get; set; }

		public ApplicationDbContext()
			: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}