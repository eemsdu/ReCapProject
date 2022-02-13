using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarDbContext>, ICarDal

    {
        public List<CarDetailDto> GetCarDetails()
        {

            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Description = c.Description,
                                 BrandName = b.Name,
                                 ColorName = col.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
