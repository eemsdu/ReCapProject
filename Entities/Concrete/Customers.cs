using Core2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customers:IEntity
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CustomerName { get; set; }
        public virtual Users User { get; set; }
        public virtual List<Rentals> Rentals { get; set; }

    }
}
