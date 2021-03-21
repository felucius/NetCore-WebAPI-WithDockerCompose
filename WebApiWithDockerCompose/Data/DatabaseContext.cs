using Microsoft.EntityFrameworkCore;
using WebApiWithDockerCompose.Model;

namespace WebApiWithDockerCompose.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions options) : base(options)
		{

		}


		// Database set Users
		public DbSet<User> Users { get; set; }
	}
}
