﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorsService
    {

        List<Colors> GetAll();
        void Add(Colors colors);
        void Delete(Colors colors);
        void Update(Colors colors);
    }
}
