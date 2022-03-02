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
    public class CustomersManager : ICustomersService
    {
        ICustomersDal _customerDal;

        public CustomersManager(ICustomersDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customers customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customers customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerDeleted);
        }

        public IDataResult<List<Customers>> GetAll()
        {
            return new SuccessDataResult<List<Customers>>(_customerDal.GetAll());
        }

        public IDataResult<Customers> GetById(int customerId)
        {
            return new SuccessDataResult<Customers>(_customerDal.Get(p => p.Id == customerId));
        }

        public IResult Update(Customers customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerUpdated);
        }
    }
}
