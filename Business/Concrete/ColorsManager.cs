using Business.Abstract;
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

        public void Add(Colors colors)
        {
            _colorsDal.Add(colors);
        }

        public void Delete(Colors colors)
        {
            _colorsDal.Delete(colors);
        }

       

        public List<Colors> GetAll()
        {
            return _colorsDal.GetAll();
        }

        public void Update(Colors colors)
        {
            _colorsDal.Update(colors);
        }
    }
}
