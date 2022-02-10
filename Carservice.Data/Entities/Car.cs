using Carservice.Data.Entities.Abstract;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Cars")]
    public class Car : BaseEntity
    {
        [Required, Column(TypeName = "date")]
        public DateTime ProductionDate { get; set; }
        [Required, StringLength(20, MinimumLength = 5)]
        public string RegNumber { get; set; }
        [StringLength(15, MinimumLength = 3)]
        public string Color { get; set; }
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        public int CarModelId { get; set; }
        [ForeignKey("CarModelId")]
        public virtual CarModel CarModel { get; set; }
    }
}
