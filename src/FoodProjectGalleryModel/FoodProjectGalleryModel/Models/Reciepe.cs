using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class Reciepe
	{
		public Reciepe()
		{
			FoodItems = new List<FoodItem>();
		}
	
		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<FoodItem> FoodItems { get; set; }
	}
}
