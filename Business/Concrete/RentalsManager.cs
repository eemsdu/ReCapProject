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
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals rental)
        {

   
                if (CheckIfRentable(rental.CarId).Success == false)
                {
                    return new ErrorResult(Messages.RentalAddingFailed);
                }

                _rentalsDal.Add(rental);

                return new SuccessResult(Messages.RentalAdded);
            }

            public IResult CheckIfRentable(int carId)
            {
                var checkedRental = _rentalsDal.Get(r => r.CarId == carId && r.ReturnDate == null);

                if (checkedRental != null)
                {
                    return new ErrorResult();
                }

                return new SuccessResult();
            }


            public IResult Delete(Rentals rental)
        {
            _rentalsDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll());
        }

        public IDataResult<Rentals> GetById(int rentalId)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(p => p.Id == rentalId));
        }


        public IResult Update(Rentals rental)
        {
            _rentalsDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }
    }
}
