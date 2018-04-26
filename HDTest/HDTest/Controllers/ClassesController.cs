using HDTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Utility;

namespace HDTest.Controllers
{
    public class ClassesController : Controller
    {
        // GET: Classes
        public ActionResult Index()
        {
            return View();
        }

		private AppDbContext db = new AppDbContext();

		//CLasses/List
		public ActionResult List()
		{
			return new JsonNetResult { Data = db.Classes.ToList() };
		}

		//CLasses/Get/2
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
			Class clas = db.Classes.Find(id);
			if (clas == null)
			{
				return new JsonNetResult { Data = new JsonMessage("Failure", "Id is not found") };
			}
			return new JsonNetResult { Data = clas };
		}
	}
}