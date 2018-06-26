using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodProjectGalleryModel.Models;
using System.Data.Entity;

namespace FoodProjectGalleryModel
{
	class Program
	{
		static void Main(string[] args)
		{
			using (var context = new Context())
			{
				var department = new Department()
				{
					Title = "Produce"
				};
				context.FoodItems.Add(new FoodItem()
				{
					Department = department,
					FoodName = "Banana",
					ItemNumber = 1,
					PublishedOn = DateTime.Today
				});
				context.FoodItems.Add(new FoodItem()
				{
					Department = department,
					FoodName = "Orange",
					ItemNumber = 2,
					PublishedOn = DateTime.Today
				});
				context.SaveChanges();

				var foodItems = context.FoodItems
					.Include(fi => fi.Department)
					.ToList();

				foreach (var foodItem in foodItems)
				{
					Console.WriteLine(foodItem.DisplayText);
				}

				Console.ReadLine();
			}


		}
	}
}
