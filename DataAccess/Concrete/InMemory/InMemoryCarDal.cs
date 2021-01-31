﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { Id = 1, BrandId =1 , ColorId = 1, ModelYear = "2019", DailyPrice =156000, Description ="Renault Clio"},
                new Car { Id = 2, BrandId =1 , ColorId = 2, ModelYear = "2018", DailyPrice =136000, Description ="Renault Symbol"},
                new Car { Id = 3, BrandId =2 , ColorId = 4, ModelYear = "2019", DailyPrice =176000, Description ="Ford Focus"},
                new Car { Id = 4, BrandId =3 , ColorId = 4, ModelYear = "2015", DailyPrice =196000, Description ="Audi A3"},
                new Car { Id = 5, BrandId =4 , ColorId = 5, ModelYear = "2020", DailyPrice =1560000, Description ="Volvo S90"},
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
