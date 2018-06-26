using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class Reciepe
	{
		public Reciepe()
		{
			FoodItems = new List<FoodItemReciepe>();
		}

		public int Id { get; set; }
		public string Name { get; set; }

		public ICollection<FoodItemReciepe> FoodItems { get; set; }
	}
}
