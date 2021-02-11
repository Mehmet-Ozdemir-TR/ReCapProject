using Core.Untilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorsService
    {

        IDataResult<List<Colors>> GetAll();
        IResult Add(Colors colors);
        IResult Delete(Colors colors);
        IResult Update(Colors colors);
    }
}
