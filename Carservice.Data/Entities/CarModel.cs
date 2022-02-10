using Carservice.Data.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("CarModels")]
    public class CarModel : BaseEntity
    {
        [Required, StringLength(20, MinimumLength = 1)]
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public virtual CarBrand Brand { get; set; }
        public virtual ICollection<Car> Cars { get; set; }

    }
}
