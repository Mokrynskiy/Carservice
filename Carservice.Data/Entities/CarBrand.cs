using Carservice.Data.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("CarBrands")]
    public class CarBrand : BaseEntity
    {
        [Required, StringLength(20, MinimumLength = 2)]
        public string BrandName { get; set; }
        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}
