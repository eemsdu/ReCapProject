using Core2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Color : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Car> Cars { get; set; }


    }
}
