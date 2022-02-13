using Core2.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomersService
    {
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetById(int customerId);
        IResult Update(Customers customer);
        IResult Add(Customers customer);
        IResult Delete(Customers customer);
    }
}
