using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class CarBrandModel
    {
        public virtual int Id { get; set; }
        public virtual string BrandName { get; set; }
        public virtual ObservableCollection<CarModelModel> CarModels { get; set; }

    }
}
