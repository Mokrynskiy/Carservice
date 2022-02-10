using System.ComponentModel.DataAnnotations;

namespace Carservice.Data.Entities.Abstract
{
    public abstract class BasePersoneEntity : BaseEntity
    {
        [Required, StringLength(25, MinimumLength = 2)]
        public string Surname { get; set; }
        [Required, StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }
        [Required, StringLength(25, MinimumLength = 2)]
        public string Patronymic { get; set; }
    }
}
