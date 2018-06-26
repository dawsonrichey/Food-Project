using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodProjectGalleryModel.Models;

namespace FoodProjectGalleryModel
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				context.FoodItems.Add(new FoodItem()
				{
					FoodName = "Banana",
					QuantityOnHand = 1,
					PublishedOn = DateTime.Today
				});
				context.SaveChanges();

				var foodItems = context.FoodItems.ToList();
				foreach (var foodItem in foodItems)
				{
					Console.WriteLine(foodItem.FoodName);
				}

				Console.ReadLine();
			}


		}
	}
}
