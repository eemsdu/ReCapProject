using Core2.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    // Car ile ilgili veritabanında yapacağım operasyonları (CRUD) içeren interface
    public interface ICarDal : IEntityRepository<Car>
    {
        public List<CarDetailDto> GetCarDetails();
    }
}
