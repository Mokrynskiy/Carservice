using DevExpress.Mvvm.DataAnnotations;
using System.Collections.ObjectModel;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class ClientModel
    {
        public virtual int Id { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Name { get; set; }
        public virtual string Patronymic { get; set; }
        public virtual string FullName { get; set; }
        public virtual ObservableCollection<CarModel> Cars { get; set; }
    }
}
