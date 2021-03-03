using Core.Untilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IResult Add(CarImage carImage , IFormFile formFile);
        IResult Delete(CarImage carImage);
        IResult Update(CarImage carImage , IFormFile formFile);
        IDataResult<CarImage> GetById(int id);
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
