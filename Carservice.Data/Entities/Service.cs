using Carservice.Data.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Services")]
    public class Service : BaseEntity
    {
        [Required, StringLength(150, MinimumLength = 5)]
        public string ServiceName { get; set; }
        [Required, Column(TypeName = "money")]
        public decimal ServiceCost { get; set; }
        public int MeasureId { get; set; }
        [ForeignKey("MeasureId")]
        public Measure Measure { get; set; }
        public virtual ICollection<OrderService> Orders { get; set; }
    }
}
