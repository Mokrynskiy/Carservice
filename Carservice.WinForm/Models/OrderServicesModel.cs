using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class OrderServicesModel
    {
        public virtual int Id { get; set; }
        public virtual int NumberOfServices { get; set; }
        public virtual OrderModel Order { get; set; }
        public virtual ServiceModel Service { get; set; }
    }
}
