using Carservice.Data.Entities;
using Carservice.Data.Repositories;
using Carservice.Data.Repositories.Abstract;
using System;

namespace Carservice.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CsDbContext context;
        private IRepository<Client> clientRepos;
        private IRepository<Car> carRepos;
        private IRepository<CarBrand> carBrandRepos;
        private IRepository<CarModel> carModelRepos;
        private IRepository<Employee> employeeRepos;
        private IRepository<Position> positionRepos;
        private IRepository<Order> orderRepos;
        private IRepository<Service> serviceRepos;
        private IRepository<Measure> measureRepos;
        private IRepository<OrderService> orderServiceRepos;

        public UnitOfWork()
        {
            context = new CsDbContext();
        }
        private bool disposed = false;

        public IRepository<Client> ClientRepos => clientRepos ?? (clientRepos = new GenericRepository<Client>(context));

        public IRepository<Car> CarRepos => carRepos ?? (carRepos = new GenericRepository<Car>(context));

        public IRepository<CarBrand> CarBrandRepos => carBrandRepos ?? (carBrandRepos = new GenericRepository<CarBrand>(context));

        public IRepository<CarModel> CarModelRepos => carModelRepos ?? (carModelRepos = new GenericRepository<CarModel>(context));

        public IRepository<Order> OrderRepos => orderRepos ?? (orderRepos = new GenericRepository<Order>(context));

        public IRepository<OrderService> OrderServiceRepos => orderServiceRepos ?? (orderServiceRepos = new GenericRepository<OrderService>(context));

        public IRepository<Service> ServiceRepos => serviceRepos ?? (serviceRepos = new GenericRepository<Service>(context));

        public IRepository<Employee> EmployeeRepos => employeeRepos ?? (employeeRepos = new GenericRepository<Employee>(context));

        public IRepository<Position> PositionRepos => positionRepos ?? (positionRepos = new GenericRepository<Position>(context));
        public IRepository<Measure> MeasureRepos => measureRepos ?? (measureRepos = new GenericRepository<Measure>(context));

        public void Save()
        {
            context.SaveChanges();
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
