using DevExpress.Mvvm.DataAnnotations;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class CarModelModel
    {       
        public virtual int Id { get; set; }            
        public virtual int CarBrandId { get; set; }            
        public virtual string ModelName { get; set; }
        public virtual  CarBrandModel CarBrand { get; set; }
    }
}