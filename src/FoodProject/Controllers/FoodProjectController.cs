using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodProject.Controllers
{
	public class FoodProjectController : Controller
	{
		public ActionResult Detail()
		{
			if (DateTime.Today.DayOfWeek == DayOfWeek.Friday)
			{
				return Redirect("/");
			}
			return Content("Hello World");

		}
	}
}