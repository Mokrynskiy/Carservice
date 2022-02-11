using DevExpress.Mvvm.DataAnnotations;
using System;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class CarModel
    {
        public virtual int Id { get; set; }
        public virtual string Color { get; set; }
        public virtual string RegNumber { get; set; }
        public virtual DateTime ProductionDate { get; set; }
        public virtual int ModelId { get; set; }
        public virtual CarModelModel Model { get; set; }
        public virtual int ClientId { get; set; }
        public virtual ClientModel Client { get; set; }
        public virtual string BrandName { get; set; }
        public virtual string ModelName { get; set; }
    }
}
