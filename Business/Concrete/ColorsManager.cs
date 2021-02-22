using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspect.Autofac.Validation;
using Core.Untilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorsManager : IColorsService
    {
        IColorsDal _colorsDal;

        public ColorsManager(IColorsDal colorsDal)
        {
            _colorsDal = colorsDal;
        }

        [ValidationAspect(typeof(ColorsValidator))]
        public IResult Add(Colors colors)
        {
            _colorsDal.Add(colors);
            return new SuccessResult(Message.ColorAdded);
        }

        public IResult Delete(Colors colors)
        {
            _colorsDal.Delete(colors);
            return new SuccessResult(Message.ColorDeleted);
        }

       

        public IDataResult<List<Colors>> GetAll()
        {
            return new SuccessDataResult<List<Colors>> (_colorsDal.GetAll());
        }

        public IResult Update(Colors colors)
        {
            _colorsDal.Update(colors);
            return new SuccessResult(Message.ColorUpdated);
        }
    }
}
