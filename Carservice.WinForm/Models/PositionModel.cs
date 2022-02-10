using DevExpress.Mvvm.DataAnnotations;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class PositionModel
    {
        public virtual int Id { get; set; }
        public virtual string PositionName { get; set; }
    }
}
