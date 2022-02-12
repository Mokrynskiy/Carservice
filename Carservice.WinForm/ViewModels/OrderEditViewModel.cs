using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class OrderEditViewModel: ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual OrderModel Order { get; set; }
        public virtual int OrderId { get; set; }
        public virtual ObservableCollection<ServiceModel> Services { get; set; }
        public virtual ServiceModel SelectedService { get; set; }

        public OrderEditViewModel()
        {
            uow = new UnitOfWork();
            Order = new OrderModel();
            Services = new ObservableCollection<ServiceModel>();
            SelectedService = new ServiceModel();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var order = uow.OrderRepos.Get(3);
                if (order != null)
                {
                    Order.Id = order.Id;
                    Order.OpenDate = order.OpenDate;
                    Order.DueDate = order.DueDate;
                    Order.CloseDate = order.CloseDate;
                    Order.CarId = order.CarId;
                    Order.EmployeeId = order.EmployeeId;
                    Order.Car = new CarModel
                    {
                        Id = order.CarId,
                        RegNumber = order.Car.RegNumber,
                        Color = order.Car.Color,
                        Model = new CarModelModel
                        {
                            Id = order.Car.CarModel.Id,
                            ModelName = order.Car.CarModel.ModelName,
                            CarBrand = new CarBrandModel
                            {
                                Id = order.Car.CarModel.Brand.Id,
                                BrandName = order.Car.CarModel.Brand.BrandName

                            }
                        },
                        Client = new ClientModel
                        {
                            Id = order.Car.Client.Id,
                            Surname = order.Car.Client.Surname,
                            Name = order.Car.Client.Name,
                            Patronymic = order.Car.Client.Patronymic
                        }
                    };
                    Order.Employee = new EmployeeModel
                    {
                        Id = order.Employee.Id,
                        Surname = order.Employee.Surname,
                        Name = order.Employee.Name,
                        Patronymic = order.Employee.Patronymic,
                        Position = new PositionModel
                        {
                            Id = order.Employee.Position.Id,
                            PositionName = order.Employee.Position.PositionName
                        }
                    };
                    foreach (var service in uow.OrderServiceRepos.FindAll(x => x.OrderId == Order.Id).ToList())
                    {
                        var mesure = uow.MeasureRepos.Get(service.Service.MeasureId);
                        Services.Add(new ServiceModel
                        {
                            Id = service.Service.Id,
                            Name = service.Service.ServiceName,
                            Cost = service.Service.ServiceCost,
                            NamberOfServices = service.NumberOfServices,
                            MeasureShortName = mesure.MeasureShortName,
                            Sum = service.NumberOfServices * service.Service.ServiceCost
                        });
                    }
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
