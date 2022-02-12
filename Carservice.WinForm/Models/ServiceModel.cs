using DevExpress.Mvvm.DataAnnotations;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class ServiceModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int MeasureId { get; set; }
        public virtual string MeasureShortName { get; set; }
        public virtual decimal Cost { get; set; }
        public virtual int NamberOfServices { get; set; }
        public virtual decimal Sum { get; set; }
        public virtual MeasureModel Measure { get; set; }
    }
}