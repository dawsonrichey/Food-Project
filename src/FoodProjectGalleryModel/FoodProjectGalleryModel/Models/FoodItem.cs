using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class FoodItem
	{
		public FoodItem()
		{
			Reciepes = new List<Reciepe>();
		}
		// ID, FoodItemId, FoodItemID
		public int Id { get; set; }
		public int DepartmentId { get; set; }
		public string FoodName { get; set; }
		public int QuantityOnHand { get; set; }
		public int ItemNumber { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
		public decimal? UnitCost { get; set; }

		public Department Department { get; set; }
		public ICollection<Reciepe> Reciepes { get; set; }

		public string DisplayText
		{
			get
			{
				return $"{Department?.Title} #{ItemNumber}";
			}
		
		}
	}
}
