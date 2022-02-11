using DevExpress.Mvvm.DataAnnotations;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class MeasureModel
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string ShortName { get; set; }

    }
}
