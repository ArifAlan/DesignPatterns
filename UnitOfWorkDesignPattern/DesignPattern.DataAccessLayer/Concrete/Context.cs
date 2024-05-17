using DesignPattern.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.Concrete
{
	public class Context : DbContext
	{
		//public Context(DbContextOptions<Context> options) : base(options)
		//{

		//}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Initial Catalog=DesignPattern1;Integrated Security=True;");
		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Process> Processes { get; set; }
	}
}
