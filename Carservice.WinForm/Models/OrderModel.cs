using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.ObjectModel;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class OrderModel
    {
        public virtual int Id { get; set; }
        public virtual DateTime OpenDate { get; set; }
        public virtual DateTime DueDate { get; set; }
        public virtual DateTime? CloseDate { get; set; }
        public virtual int CarId { get; set; }
        public virtual CarModel Car { get; set; }
        public virtual int EmployeeId { get; set; }
        public virtual EmployeeModel Employee { get; set; }
        public virtual decimal Sum { get; set; }
        public virtual ObservableCollection<OrderServicesModel> OrderServices { get; set; }
    }
}
