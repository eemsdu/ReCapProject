using Core2.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int userId);
        IResult Update(Users user);
        IResult Add(Users user);
        IResult Delete(Users user);
    }
}
