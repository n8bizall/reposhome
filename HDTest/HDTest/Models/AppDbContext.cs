using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HDTest.Models
{
	public class AppDbContext: DbContext
	{
		public AppDbContext() : base("LocalMySqlServer") { }

		public DbSet<Student> Students { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Class> Classes { get; set; }
	}
}