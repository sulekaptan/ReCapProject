using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();
            //BrandTest();
        }

        private static void BrandTest()
        {            
            Console.WriteLine("----------------BrandTest-----------------------------------------------------------------------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        
        private static void ColorTest()
        {
            Console.WriteLine("----------------ColorTest------------------------------------------------------------------------");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Car Name: " + car.Name + " --- Brand Name: " + car.BrandName
                         + " --- ColorName: " + car.ColorName + " --- Daily Price: " + car.DailyPrice);
                }

            }
            else 
            {
                Console.WriteLine(result.Message);
            }

            
            //Console.WriteLine("------------------------------------------");

            //carManager.Add(new Car { Id = 14, BrandId = 112, ColorId = 21, ModelYear = 2017, DailyPrice = 400, Description = "Chevrolet Captiva" });
        }

        
    }
}
