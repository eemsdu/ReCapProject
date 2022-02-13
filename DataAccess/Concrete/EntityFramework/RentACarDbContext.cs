using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //projenin hangi veri tabanı ile ilişkili olduğunu söylediğim yer 
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8M7D7GE\MSSQLSERVER1;Initial Catalog=RentACarDb;User ID=sa;Password=1234");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands{ get; set; }
        public DbSet<Color> Colors{ get; set; }
        public DbSet<Users> Users{ get; set; }
        public DbSet<Customers> Customer{ get; set; }
        public DbSet<Rentals> Rentals { get; set; }

    }
     
}
