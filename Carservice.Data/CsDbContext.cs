using Carservice.Data.Entities;
using System.Data.Entity;

namespace Carservice.Data
{
    public class CsDbContext : DbContext
    {
        static CsDbContext()
        {
            Database.SetInitializer(new CsDbInitializer());
        }
        public CsDbContext() : base("DefaultConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Measure> Measures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarsBrands { get; set; }
        public DbSet<CarModel> CarsModels { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<OrderService> OrdersServices { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}
