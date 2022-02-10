using Carservice.Data.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Employees")]
    public class Employee : BasePersoneEntity
    {
        public int PositionId { get; set; }
        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
        public virtual ICollection<Order> Order { get; set; }
    }
}
