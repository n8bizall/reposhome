using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HDTest.Models
{
	public class Enrollment
	{
		public int EnrollmentID { get; set; }
		public int StudentID { get; set; }
		public string Course { get; set; }

		public virtual Student Student { get; set; }
	}
}