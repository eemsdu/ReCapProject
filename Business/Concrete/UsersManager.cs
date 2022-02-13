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
    public class UsersManager : IUsersService
    {
        IUsersDal _usersDal;

        public UsersManager(IUsersDal usersDal)
        {
            _usersDal = usersDal;
        }

        public IResult Add(Users user)
        {
            _usersDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(Users user)
        {
            _usersDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_usersDal.GetAll());
        }

        public IDataResult<Users> GetById(int userId)
        {
            return new SuccessDataResult<Users>(_usersDal.Get(p => p.Id == userId));
        }

        public IResult Update(Users user)
        {
            _usersDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
