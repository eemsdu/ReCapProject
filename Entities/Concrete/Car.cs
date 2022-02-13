
using Core2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime YearOfModel { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual List<Rentals> Rentals { get; set; }

    }
}
