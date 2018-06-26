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
		public Context()
		{
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>());
			//Database.SetInitializer(new CreateDatabaseIfNotExists<Context>());
			//Database.SetInitializer(new DropCreateDatabaseAlways<Context>());
		}
		public DbSet<FoodItem> FoodItems { get; set; }
	}
}
