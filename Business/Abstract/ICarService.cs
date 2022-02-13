using Core2.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
       IDataResult<List<Car>> GetAll();
       IDataResult<List<Car>> GetAllBrandId(int id);
       IDataResult<List<Car>> GetAllColorId(int id);
       IDataResult<List<CarDetailDto>> GetCarDetails();
       IDataResult<Car> GetById(int carId);
       IResult Add(Car car);

    }
}
