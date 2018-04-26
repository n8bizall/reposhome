using HDTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace HDTest.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }
		private AppDbContext db = new AppDbContext();

		//Studen/List
		public ActionResult List()
		{
			return new JsonNetResult { Data = db.Enrollments.ToList() };
		}

		//Enrollments/Get/2
		public ActionResult Get(int? id)
		{
			if (!ModelState.IsValid)
			{
				var errorMessages = ModelStateErrors.GetModelStateErrors(ModelState);
				return new JsonNetResult { Data = new Msg { Result = "Failed", Message = "ModelState invalid.", Data = errorMessages } };
			}
			if (id == null)
			{
				return new JsonNetResult { Data = new JsonMessage("Failure", "Id is null") };
			}
			Enrollment enrollment = db.Enrollments.Find(id);
			if (enrollment == null)
			{
				return new JsonNetResult { Data = new JsonMessage("Failure", "Id is not found") };
			}
			return new JsonNetResult { Data = enrollment };
		}
	}
}