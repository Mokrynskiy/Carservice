using Carservice.Data;
using Carservice.Data.Repositories.Abstract;
using Carservice.WinForm.Views;
using CarService.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraEditors;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {
        private IUnitOfWork uow;
        public virtual ObservableCollection<OrderRowModel> Orders { get; set; }
        public virtual OrderRowModel SelectedOrder { get; set; } 
        public MainViewModel()
        {
            
            Orders = new ObservableCollection<OrderRowModel>();
            SelectedOrder = new OrderRowModel();
            Messenger.Default.Register<int>(this, "UpdateMainView", UpdateDataGrid);
            LoadOrders();
        }
        private void UpdateDataGrid(int id)
        {            
            LoadOrders();
            SelectedOrder = (from o in Orders where o.Id == id select o).FirstOrDefault();
        }
        private void LoadOrders()
        {
            uow = new UnitOfWork();
            Orders.Clear();
            foreach (var item in uow.OrderRepos.GetAll().ToList())
            {                
                var order = new OrderRowModel();
                var car = uow.CarRepos.Get(item.CarId);
                var client = uow.ClientRepos.Get(item.Car.ClientId);                
                order.Id = item.Id;
                order.OpenDate = item.OpenDate;
                order.DueDate = item.DueDate;
                order.CloseDate = item.CloseDate;
                order.Client = $"{client.Surname} {client.Name} {client.Patronymic}";
                order.Car = $"{car.Color} {car.CarModel.Brand.BrandName} {car.CarModel.ModelName} {car.RegNumber}";
                decimal sum = 0;
                foreach (var serv in uow.OrderServiceRepos.FindAll(x => x.OrderId == item.Id).ToList())
                {
                    var service = uow.ServiceRepos.Get(serv.ServiceId);
                    sum += service.ServiceCost * serv.NumberOfServices;
                }
                order.Sum = sum;
                Orders.Add(order);
            }
            SelectedOrder = Orders.FirstOrDefault();
        }                     
        public void DeleteOrder()
        {
            if (SelectedOrder != null)
            {
                if (XtraMessageBox.Show($"Вы действительно хотите удалить данные о заказе: №{SelectedOrder.Id} {SelectedOrder.Client} {SelectedOrder.Car}", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        uow.OrderRepos.Delete(SelectedOrder.Id);
                        uow.Save();
                        Orders.Remove(SelectedOrder);
                    }
                    catch (System.Exception e)
                    {
                        XtraMessageBox.Show(e.Message);
                    }
                }
            }
        }
        public void EditOrder()
        {            
            ShowEditOrderView();
            Messenger.Default.Send(SelectedOrder.Id);
        }
        public void PrintOrder()
        {
            ReportView report = new ReportView(SelectedOrder.Id);
            report.Show();            
        }
        public void AddOrder()
        {
            ShowEditOrderView();
            Messenger.Default.Send(0);                       
        }


    }
}