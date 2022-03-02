using Business.Abstract;
using Business.Constans;
using Core2.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.Name.Length<2)
            {
                return new  ErrorResult(Messages.BrandAddedFailed);
            }
            _brandDal.Add(brand);

            return new SuccessResult(Messages.BrandAdded);
        
         }

        //public IResult Delete(Brand brand)
        //{
        //    if (brand.Id==5)
        //    {
        //        return new ErrorResult("Bu numaralı id silinemez");
        //    }

        //    _brandDal.Delete(brand);
        //    return new SuccessResult(Messages.BrandDeleted);
        //}
    
    
        public IResult Delete(Brand brand)
        {
            if (brand.Id==6)
            {
                return new ErrorResult(Messages.BrandDeletedFailed);
            }
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
             
                
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            
            //return new DataResult<Brand>(_brandDal.Get(p => p.Id == brandId),true,Messages.BrandIded);
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == brandId));
        }

        public IResult Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
