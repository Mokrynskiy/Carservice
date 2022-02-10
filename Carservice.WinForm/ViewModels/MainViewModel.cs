using Carservice.Data;
using CarService.WinForm.Models;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace Carservice.WinForm.ViewModels
{
    [POCOViewModel]
    public class MainViewModel : ViewModelBase
    {

        private readonly UnitOfWork uow;
        public virtual ObservableCollection<OrderRowModel> Orders { get; set; }
        public virtual OrderRowModel SelectedOrder { get; set; }



        public MainViewModel()
        {
            uow = new UnitOfWork();
            SelectedOrder = new OrderRowModel();
            LoadOrders();
        }
        private void LoadOrders()
        {
            Orders = new ObservableCollection<OrderRowModel>();
            foreach (var item in uow.OrderRepos.GetAll().ToList())
            {
                var order = new OrderRowModel();
                order.Id = item.Id;
                order.OpenDate = item.OpenDate;
                order.DueDate = item.DueDate;
                order.CloseDate = item.CloseDate;
                order.Client = $"{item.Car.Client.Surname} {item.Car.Client.Name} {item.Car.Client.Patronymic}";
                order.Car = $"{item.Car.Color} {item.Car.CarModel.Brand.BrandName} {item.Car.CarModel.ModelName} {item.Car.RegNumber}";
                decimal sum = 0;
                foreach (var serv in item.Services.ToList())
                {
                    sum += serv.Service.ServiceCost * serv.NumberOfServices;
                }
                order.Sum = sum;
                Orders.Add(order);
            }
            SelectedOrder = Orders.FirstOrDefault();
        }
        // Редактирование заказа
        public void Edit()
        {
            MessageBox.Show(SelectedOrder.Client);
        }
        // Удаление заказа
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
                    


    }
}