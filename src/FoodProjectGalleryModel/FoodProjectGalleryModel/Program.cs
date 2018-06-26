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
				var department1 = new Department()
				{
					Title = "Produce"
				};
				var department2 = new Department()
				{
					Title = "Dairy"
				};
				var reciepe1 = new Reciepe()
				{
					Name = "Mac&Cheese"
				};
				var reciepe2 = new Reciepe()
				{
					Name = "Fruit Salad"
				};
				var reciepe3 = new Reciepe()
				{
					Name = "PB&J"
				};
				var foodItem1 = new FoodItem()
				{
					Department = department1,
					FoodName = "Banana",
					ItemNumber = 1,
					PublishedOn = DateTime.Today
				};
				foodItem1.Reciepes.Add(reciepe1);
				foodItem1.Reciepes.Add(reciepe2);

				var foodItem2 = new FoodItem()
				{
					Department = department2,
					FoodName = "Orange",
					ItemNumber = 2,
					PublishedOn = DateTime.Today
				};
				foodItem2.Reciepes.Add(reciepe1);
				foodItem2.Reciepes.Add(reciepe2);

				var foodItem3 = new FoodItem()
				{
					Department = department1,
					FoodName = "Bread",
					ItemNumber = 3,
					PublishedOn = DateTime.Today
				};
				foodItem3.Reciepes.Add(reciepe1);
				foodItem3.Reciepes.Add(reciepe3);


				context.FoodItems.Add(foodItem1);
				context.FoodItems.Add(foodItem2);
				context.FoodItems.Add(foodItem3);
				context.SaveChanges();

				var foodItems = context.FoodItems
					.Include(fi => fi.Department)
					.Include(fi => fi.Reciepes)
		
					.ToList();

				foreach (var foodItem in foodItems)
				{
					var reciepeNames = foodItem.Reciepes.Select(a => a.Name).ToList();
					var reciepesDisplayText = string.Join(", ", reciepeNames);

					Console.WriteLine(foodItem.DisplayText);
					Console.WriteLine(reciepesDisplayText);

				}

				Console.ReadLine();
			}


		}
	}
}
