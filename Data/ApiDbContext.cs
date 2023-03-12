using System;
using realestate.Models;
using Microsoft.EntityFrameworkCore;
namespace realestate.Data
{
//Hi i aM BIG GREEN MAN
	public class ApiDbContext : DbContext
	{
		public DbSet<Category> Categories { get; set; }
		
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		optionsBuilder.UseSqlServer();
		}
    }
	
}

