using Carservice.Data.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Positions")]
    public class Position : BaseEntity
    {
        [Required, StringLength(30, MinimumLength = 5)]
        public string PositionName { get; set; }
    }
}
