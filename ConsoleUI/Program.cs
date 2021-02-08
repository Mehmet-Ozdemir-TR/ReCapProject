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

            carManager.Delete(new Car { Id = 2 });
            carManager.AddCar(new Car { Id = 2 ,ColorId = 2 , BrandId = 2 , ModelYear = "2014", DailyPrice = 365000 , Description = "Volvo"});
            carManager.Update(new Car { Id = 1 , BrandId = 2, ColorId = 4 , DailyPrice = 567895 , ModelYear = "2000" , Description = "Tofaşk" });
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

            Console.WriteLine("**************************************************************************");

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.BrandName + " " + car.ColorName + " renkli arabanın fiyatı=>" + car.DailyPrice);
            }

            Console.WriteLine("**************************************************************************");

            ColorsManager colorsManager = new ColorsManager(new EfColorsDal());
            colorsManager.Delete(new Colors { ColorsId = 1});
            colorsManager.Add(new Colors { ColorsId = 1, ColorsName = "Eflatun" });
            colorsManager.Update(new Colors { ColorsId = 2 , ColorsName = "Mor"});

            foreach (var colors in colorsManager.GetAll())
            {
                Console.WriteLine(colors.ColorsName);
            }

            Console.WriteLine("**************************************************************************");

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 3});
            brandManager.Add(new Brand { BrandId = 3, BrandName = "Jeep" });
            brandManager.Update(new Brand { BrandId = 4, BrandName = "Nissan" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }

            Console.WriteLine("**************************************************************************");
            
        }
    }
}
