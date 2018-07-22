using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FoodProjectTwo.Models
{
	public class FoodProjectTwo
	{
		public int Id { get; set; }
		public string FoodName { get; set; }
		public int UnitCost { get; set; }
		public string DescriptionHtml { get; set; }
		public Recipe[] Recipes { get; set; }
		public bool Favorite { get; set; }

		public string DisplayText
		{
			get
			{
				return FoodName + " $" + UnitCost;
			}
		}
		// series-title-issuenumber.jpg
		public string CoverImageFileName
		{
			get
			{
				return FoodName.Replace(" ", "-")
					.ToLower() + "-" + UnitCost + ".jpg";
			}
		}
	}
}