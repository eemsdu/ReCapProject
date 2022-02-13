using Core2.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Brand : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Car> Cars { get; set; }


    }
}
