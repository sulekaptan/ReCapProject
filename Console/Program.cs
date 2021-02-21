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
            ColorTest();
            BrandTest();
        }

        private static void BrandTest()
        {            
            Console.WriteLine("----------------BrandTest-----------------------------------------------------------------------");
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        
        private static void ColorTest()
        {
            Console.WriteLine("----------------ColorTest------------------------------------------------------------------------");
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car Name: " + car.Name + " --- Brand Name: " + car.BrandName
                    + " --- ColorName: " + car.ColorName + " --- Daily Price: " + car.DailyPrice);
            }
            //Console.WriteLine("------------------------------------------");

            //carManager.Add(new Car { Id = 14, BrandId = 112, ColorId = 21, ModelYear = 2017, DailyPrice = 400, Description = "Chevrolet Captiva" });
        }

        
    }
}
