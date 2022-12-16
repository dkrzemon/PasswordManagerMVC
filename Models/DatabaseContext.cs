using Microsoft.EntityFrameworkCore;

namespace PasswordManager.Models
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

		public DbSet<AccountModel> AccountModel { get; set; }
	}
}
