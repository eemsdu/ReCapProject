﻿using Core2.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalsService
    {
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetById(int rentalId);
        IResult Update(Rentals rental);
        IResult Add(Rentals rental);
        IResult Delete(Rentals rental);
    }
}
