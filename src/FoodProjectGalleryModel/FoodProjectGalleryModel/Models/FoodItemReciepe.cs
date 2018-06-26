using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class FoodItemReciepe
	{
		public int Id { get; set; }
		public int FoodItemId { get; set; }
		public int ReciepeId { get; set; }
		public int RoleId { get; set; }

		public FoodItem FoodItem { get; set; }
		public Reciepe Reciepe { get; set; }
		public Role Role { get; set; }
	}
}
