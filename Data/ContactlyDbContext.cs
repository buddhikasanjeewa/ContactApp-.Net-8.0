using Angaular17WebApi1.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Angaular17WebApi1.Data
{
	public class ContactlyDbContext : DbContext
	{
		public ContactlyDbContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<Contact> Contacts { get; set; }
    }
}
