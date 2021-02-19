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
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(111))
            {
                Console.WriteLine("Car Name: " + car.Description);
            }

            carManager.Add(new Car {Id = 14, BrandId = 112, ColorId = 21, ModelYear = 2017, DailyPrice = 400, Description = "Chevrolet Captiva" });

        }
    }
}
