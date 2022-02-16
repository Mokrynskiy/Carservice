using Carservice.Data;
using Carservice.WinForm.Reports.Abstract;
using Carservice.WinForm.Reports.Models;
using System.Collections.Generic;
using System.Linq;

namespace Carservice.WinForm.Reports
{
    public class OrderReportBuilder : IOrderReportBuilder
    {
        public OrderReportModel Build(int orderId)
        {
            var uow = new UnitOfWork();
            var order = uow.OrderRepos.Get(orderId);
            var car = uow.CarRepos.Get(order.CarId);
            var client = uow.ClientRepos.Get(car.ClientId);
            var carModel = uow.CarModelRepos.Get(car.CarModelId);
            var carBrand = uow.CarBrandRepos.Get(carModel.BrandId);
            var employee = uow.EmployeeRepos.Get(order.EmployeeId);
            var employeePosition = uow.PositionRepos.Get(employee.PositionId);
            var header = new OrderReportHeaderModel
            {
                Id = order.Id,
                ClientSurname = client.Surname,
                ClientName = client.Name,
                ClientPatronymic = client.Patronymic,
                OpenDate = order.OpenDate.ToShortDateString(),
                DueDate = order.DueDate.ToShortDateString(),
                CloseDate = order.CloseDate == null ? "Наряд открыт" : order.CloseDate.ToString(),
                CarBrand = carBrand.BrandName,
                CarModel = carModel.ModelName,
                CarColor = car.Color,
                CarProductionDate = car.ProductionDate.Year.ToString(),
                CarRegNumber = car.RegNumber,
                EmployeeSurname = employee.Surname,
                EmployeeName = employee.Name,
                EmployeePatronymic = employee.Patronymic,
                EmployeePosition = employeePosition.PositionName
            };
            var items = new List<OrderReportItemModel>();
            foreach (var item in uow.OrderServiceRepos.FindAll(x => x.OrderId == order.Id).ToList())
            {
                var measure = uow.MeasureRepos.Get(item.Service.MeasureId);
                items.Add(new OrderReportItemModel(item.Service.ServiceName, item.Service.ServiceCost, item.NumberOfServices, measure.MeasureShortName));
            }
            return new OrderReportModel(header, items);
        }
    }
}
