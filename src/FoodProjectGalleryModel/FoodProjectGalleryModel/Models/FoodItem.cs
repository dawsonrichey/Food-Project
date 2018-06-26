﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodProjectGalleryModel.Models
{
	public class FoodItem
	{
		// ID, FoodItemId, FoodItemID
		public int Id { get; set; }
		public string FoodName { get; set; }
		public int QuantityOnHand { get; set; }
		public string Description { get; set; }
		public DateTime PublishedOn { get; set; }
	}
}