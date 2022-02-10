using DevExpress.Mvvm.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carservice.WinForm.Models
{
    [POCOViewModel]
    public class EmployeeModel
    {
        public virtual int Id { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Name { get; set; }
        public virtual string Patronymic { get; set; }
        public virtual int PositionId { get; set; }
        public virtual string PositionName { get; set; }
        public virtual PositionModel Position { get; set; }
    }
}
