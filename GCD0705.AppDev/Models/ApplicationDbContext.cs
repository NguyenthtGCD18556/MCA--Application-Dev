using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace GCD0705.AppDev.Models
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{
		public ApplicationDbContext()
				: base("DefaultConnection", throwIfV1Schema: false)
		{
		}

		public DbSet<Task> Tasks { get; set; }
		public DbSet<Category> Categories { get; set; }

		public static ApplicationDbContext Create()
		{
			return new ApplicationDbContext();
		}
	}
}