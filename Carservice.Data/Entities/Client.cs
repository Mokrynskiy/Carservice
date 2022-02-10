using Carservice.Data.Entities.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carservice.Data.Entities
{
    [Table("Clients")]
    public class Client : BasePersoneEntity
    {
        public virtual ICollection<Car> Cars { get; set; }
    }
}
