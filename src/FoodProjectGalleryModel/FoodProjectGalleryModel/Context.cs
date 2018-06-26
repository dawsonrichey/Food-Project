using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodProjectGalleryModel.Models;

namespace FoodProjectGalleryModel
{
	public class Context : DbContext
	{
		public DbSet<FoodItem> FoodItems { get; set; }
	}
}
