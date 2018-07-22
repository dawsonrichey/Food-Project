using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodProject.Models
{
	public class FoodProject
	{
		public int Id { get; set; }
		public string FoodName { get; set; }
		public int UnitCost { get; set; }
		public string DescriptionHtml { get; set; }
		public Recipe[] Recipes { get; set; }
		public bool Favorite { get; set; }
	}
}