using Carservice.Data.Entities;
using System;

namespace Carservice.Data.Repositories.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Order> OrderRepos { get; }
        IRepository<Car> CarRepos { get; }
        IRepository<CarBrand> CarBrandRepos { get; }
        IRepository<CarModel> CarModelRepos { get; }
        IRepository<Employee> EmployeeRepos { get; }
        IRepository<Client> ClientRepos { get; }
        IRepository<Service> ServiceRepos { get; }
        IRepository<Position> PositionRepos { get; }
        IRepository<Measure> MeasureRepos { get; }
        IRepository<OrderService> OrderServiceRepos { get; }
        void Save();
    }
}
