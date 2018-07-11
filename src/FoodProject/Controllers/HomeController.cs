using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodProject.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page. I Found my About page message content. I am the smartest boy in the world. It's in the Controller folder in the file named HomeController.cs";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "This is my applications contact page information. This content can be edited by accessing the the HomeController.cs file. This file can be found in the Controller folder.";

			return View();
		}
	}
}