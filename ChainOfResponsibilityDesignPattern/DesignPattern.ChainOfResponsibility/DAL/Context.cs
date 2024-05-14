﻿using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB; Initial Catalog=DesignPattern1;Integrated Security=True;");
		}
		public DbSet<CustomerProcess> CustomerProcesses { get; set; }
	}
}
