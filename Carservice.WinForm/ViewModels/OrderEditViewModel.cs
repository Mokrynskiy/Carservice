using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel()]
    public class OrderEditViewModel : ViewModelBase
    {
        private readonly IUnitOfWork uow;
        public virtual OrderModel Order { get; set; }
        public virtual ObservableCollection<ServiceModel> Services { get; set; }
        public virtual ObservableCollection<ServiceModel> DeletedServices { get; set; }
        public virtual ObservableCollection<ServiceModel> AddedServices { get; set; }
        public virtual ObservableCollection<ServiceModel>EditabelServices { get; set; }
        public virtual ServiceModel SelectedService { get; set; }
        public virtual string S { get; set; }
        public OrderEditViewModel()
        {
            uow = new UnitOfWork();
            Order = new OrderModel();
            Order.Car = new CarModel();
            Services = new ObservableCollection<ServiceModel>();
            DeletedServices = new ObservableCollection<ServiceModel>();
            AddedServices = new ObservableCollection<ServiceModel>();
            EditabelServices = new ObservableCollection<ServiceModel>();
            SelectedService = new ServiceModel();
            Messenger.Default.Register<int>(this, LoadData);
            Messenger.Default.Register<CarModel>(this, "SetClient", SetClient);
            Messenger.Default.Register<EmployeeModel>(this, "SetEmployee", SetEmployee);
            Messenger.Default.Register<ServiceModel>(this, "AddService", AddService);
        }
        private void LoadData(int id)
        {            
            if (id != 0)
            {
                try
                {
                    var order = uow.OrderRepos.Get(id);
                    if (order != null)
                    {
                        Order.Id = order.Id;
                        Order.OpenDate = order.OpenDate;
                        Order.DueDate = order.DueDate;
                        Order.CloseDate = order.CloseDate;
                        Order.CarId = order.CarId;
                        Order.EmployeeId = order.EmployeeId;
                        var car = uow.CarRepos.Get(order.CarId);
                        var model = uow.CarModelRepos.Get(car.CarModelId);
                        var brand = uow.CarBrandRepos.Get(model.BrandId);
                        var client = uow.ClientRepos.Get(car.ClientId);
                        var employee = uow.EmployeeRepos.Get(order.EmployeeId);
                        var position = uow.PositionRepos.Get(employee.PositionId);
                        Order.Car = new CarModel
                        {
                            Id = car.Id,
                            RegNumber = car.RegNumber,
                            Color = car.Color,
                            ProductionDate = car.ProductionDate,                            
                            Model = new CarModelModel
                            {
                                Id = model.Id,
                                ModelName = model.ModelName,
                                CarBrand = new CarBrandModel
                                {
                                    Id = brand.Id,
                                    BrandName = brand.BrandName

                                }
                            },
                            Client = new ClientModel
                            {
                                Id = client.Id,
                                Surname = client.Surname,
                                Name = client.Name,
                                Patronymic = client.Patronymic
                            }
                        };
                        Order.Employee = new EmployeeModel
                        {
                            Id = employee.Id,
                            Surname = employee.Surname,
                            Name = employee.Name,
                            Patronymic = employee.Patronymic,
                            Position = new PositionModel
                            {
                                Id = position.Id,
                                PositionName = position.PositionName
                            }
                        };                        
                        foreach (var orderService in uow.OrderServiceRepos.FindAll(x => x.OrderId == Order.Id).ToList())
                        {
                            var service = uow.ServiceRepos.Get(orderService.ServiceId);
                            var mesure = uow.MeasureRepos.Get(service.MeasureId);                            
                            Services.Add(new ServiceModel
                            {
                                Id = service.Id,
                                MeasureId = service.MeasureId,
                                Name = service.ServiceName,
                                Cost = service.ServiceCost,
                                NumberOfServices = orderService.NumberOfServices,
                                MeasureShortName = mesure.MeasureShortName,
                                OrderServiceId = orderService.Id,
                                Sum = orderService.NumberOfServices * service.ServiceCost
                            });
                        }
                    }
                    UpdateOrder();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }                
            }
            else
            {
                Order.OpenDate = DateTime.Now;
                Order.DueDate = DateTime.Now;
                Order.Car = new CarModel();
                Order.Car.Model = new CarModelModel();
                Order.Car.Model.CarBrand = new CarBrandModel();
                Order.Car.Client = new ClientModel();
                Order.Employee = new EmployeeModel();
                Order.Employee.Position = new PositionModel();
                UpdateOrder();
            }
            
        }
        protected void OnServicesChanged()
        {
            SelectedService = Services.FirstOrDefault();
        }
        private void SetClient(CarModel car)
        {
            Order.Car = car;
            UpdateOrder();
        }
        private void SetEmployee(EmployeeModel employee)
        {
            Order.Employee = employee;
            UpdateOrder();
        }
        private void UpdateOrder()
        {
            var order = new OrderModel();
            order = Order;
            Order = new OrderModel();
            Order = order;
        }
        public void SelectClient()
        {
            ShowClientsView();
            Messenger.Default.Send<bool>(true, "IsSelectClientMod");
        }
        public void SelectEmployee()
        {
            ShowEmployeesView();
            Messenger.Default.Send<bool>(true, "IsSelectEmployeeMod");
        }
        public void SelectService()
        {
            ShowServicesView();
            Messenger.Default.Send<bool>(true, "IsSelectServiceMod");
        }
        public void DeleteService()
        {
            if (XtraMessageBox.Show($"Вы действительно хотите удалить услугу: \"{SelectedService.Name}\"?", "Внимание!!!", MessageBoxButtons.YesNo) != DialogResult.No)
            {
                EditabelServices.Remove(SelectedService);
                DeletedServices.Add(SelectedService);
                Services.Remove(SelectedService);
            }                
        }
        public void AddService(ServiceModel service)
        {
            Services.Add(service);
            SelectedService = service;
            AddedServices.Add(service);
            EditService();
        }
        public void OnEditService()
        {
            EditService();  
            EditabelServices.Add(SelectedService);
        }
        private void EditService()
        {            
            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Количество услуг";
            args.Prompt = "Введите количество услуг";
            SpinEdit editor = new SpinEdit();
            editor.Properties.MinValue = 1;
            editor.Properties.MaxValue = 100000;
            editor.Value = 1;
            editor.Properties.IsFloatValue = false;
            args.Editor = editor;
            if(SelectedService.NumberOfServices>0)
                args.DefaultResponse = SelectedService.NumberOfServices;
            else
                args.DefaultResponse = 1;            
            int result = XtraInputBox.Show<int>(args);                       
            SelectedService.NumberOfServices = result;
            SelectedService.Sum = SelectedService.Cost * SelectedService.NumberOfServices;
            ServiceModel selService = SelectedService;
            SelectedService = null;
            SelectedService = selService;
        }
        public void SaveAndClose()
        {
            if (Order.CarId == 0 || Order.EmployeeId == 0 )
            {
                XtraMessageBox.Show("Необходимо указать клиента и ответственного исполнителя", "Ошибка!");
            }
            else
            {
                if (Order.Id == 0) AddOrderToDb();
                else UpdateOrderToDb();
                CloseView();
            }            
        }
        private void AddOrderToDb()
        {
            try
            {
                var orderEntity = new Data.Entities.Order
                {
                    OpenDate = Order.OpenDate,
                    DueDate = Order.DueDate,
                    CarId = Order.Car.Id,
                    EmployeeId = Order.Employee.Id,
                    CloseDate = Order.CloseDate              
                    
                };            
                var order = uow.OrderRepos.Add(orderEntity);                           
                foreach (var item in Services)
                {                    
                   var orderService =  uow.OrderServiceRepos.Add(new Data.Entities.OrderService { OrderId = order.Id, ServiceId = item.Id, NumberOfServices = item.NumberOfServices});                   
                }
                uow.Save();
                Messenger.Default.Send(order.Id, "UpdateMainView");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
        private void UpdateOrderToDb()
        {
            try
            {
                var orderEntity = uow.OrderRepos.Get(Order.Id);
                orderEntity.OpenDate = Order.OpenDate;
                orderEntity.DueDate = Order.DueDate;
                orderEntity.CloseDate = Order.CloseDate;
                orderEntity.CarId = Order.Car.Id;
                orderEntity.EmployeeId = Order.Employee.Id;
                
                uow.OrderRepos.Update(orderEntity, Order.Id);
                if (DeletedServices.Any())
                {
                    foreach (var service in DeletedServices)
                        uow.OrderServiceRepos.Delete(service.OrderServiceId);
                }
                if (AddedServices.Any())
                {
                    foreach (var item in AddedServices)
                    {
                        var orderService = uow.OrderServiceRepos.Add(new Data.Entities.OrderService { OrderId = orderEntity.Id, ServiceId = item.Id, NumberOfServices = item.NumberOfServices });                                       
                    }
                    
                }
                if (EditabelServices.Any())
                {
                    foreach (var service in EditabelServices)
                    {
                        var orderServiceEntity = uow.OrderServiceRepos.Get(service.OrderServiceId);                        
                        orderServiceEntity.NumberOfServices = service.NumberOfServices;
                        
                    }
                }                
                uow.Save();
                Messenger.Default.Send(orderEntity.Id, "UpdateMainView");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        

    }
}
