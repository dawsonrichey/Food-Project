﻿using System;
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
			var foodProject = new FoodProject();
			{
				FoodName = "hgjg";
			};


			ViewBag.FoodName = "Carrots";
			ViewBag.UnitCost = 7;
			ViewBag.Description = "<p>Carrots are orange. Rabbits love to eat carrots.</p>";
			ViewBag.Recipes = new string[]{
				"Dessert: carrot cake",
				"Dinner: carrot stew",
				"Lunch: carrot pie"
			};

			return View();
		}
	}
}