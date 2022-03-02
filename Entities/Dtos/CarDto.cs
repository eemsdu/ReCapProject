using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class CarDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime YearOfModel { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
