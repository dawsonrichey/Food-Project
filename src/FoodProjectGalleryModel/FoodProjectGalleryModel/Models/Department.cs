using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class Department
	{
		public Department()
		{
			FoodItems = new List<FoodItem>();
		}

		public int Id { get; set; }
		[Required, StringLength(200)]
		public string Title { get; set; }
		public string Description { get; set; }

		public ICollection<FoodItem> FoodItems { get; set; }
	}
}
