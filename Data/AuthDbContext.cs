using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Angaular17WebApi1.Data
{
	public class AuthDbContext : IdentityDbContext<IdentityUser>
	{
		public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
		{
		}

		//public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
		//{
		//}


	}
}
