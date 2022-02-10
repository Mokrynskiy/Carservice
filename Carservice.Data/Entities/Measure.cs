using Carservice.Data.Entities.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Measures")]
    public class Measure : BaseEntity
    {
        [Required, StringLength(15, MinimumLength = 3)]
        public string MeasureName { get; set; }
        [Required, StringLength(10, MinimumLength = 1)]
        public string MeasureShortName { get; set; }
    }
}
