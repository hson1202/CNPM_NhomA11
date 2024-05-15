using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Shopping.Models;

namespace Shopping.Repository
{
	public class DataContext : DbContext
	{
		public DataContext() 
		{ 

		}
		public DataContext(DbContextOptions<DataContext>options) : base(options) 
		{ 

		}
		public DbSet<BrandModel> Brands { get; set; }

		public DbSet <ProductModel> Products { get;set; }
		public DbSet<CategoryModel> Categories { get; set; }
	}
	public class BloggingContextFactory : IDesignTimeDbContextFactory<DataContext>
	{
		public DataContext CreateDbContext(string[] args)
		{
			var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
			optionsBuilder.UseSqlServer("Data Source=-PC;Initial Catalog=Shopping;Integrated Security=True;Trust Server Certificate=True");

			return new DataContext(optionsBuilder.Options);
		}
	}
}
