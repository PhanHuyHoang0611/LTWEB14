using Microsoft.EntityFrameworkCore;

namespace LTWEB14.Models
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { 
		}
		public DbSet<Menu> Menus { get; set; }	
		public DbSet<Service> Services { get; set; }
		public DbSet<Room> Rooms { get; set; }
		public DbSet<Review> Reviews { get; set; }
		public DbSet<Customer> Customers { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
    }

}
