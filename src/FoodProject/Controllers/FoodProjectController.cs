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
			ViewBag.FoodName = "Carrots";
			ViewBag.UnitCost = 7;
			ViewBag.Description = "<p>Carrots are orange. Rabbits love to eat carrots.</p>";
			ViewBag.Recipes = new string[]{
				"carrot cake",
				"carrot stew",
				"carrot pie"
			};

			return View();
		}
	}
}