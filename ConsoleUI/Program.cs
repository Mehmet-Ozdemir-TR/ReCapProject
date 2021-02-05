using Business.Concrete;
using DataAccess.Concrete.IEntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            carManager.Add(new Brand { BrandName = "Ford Focus" }, new Car { DailyPrice = 1000000 });
            carManager.Add(new Brand { BrandName = "Volvo S90" }, new Car { DailyPrice = 1000000000 });
        }
    }
}
