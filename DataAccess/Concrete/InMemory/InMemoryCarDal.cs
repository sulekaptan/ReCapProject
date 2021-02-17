using DataAccess.Abstract;
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
            _cars = new List<Car>{ //ColorId = 21: Black, 10: White, 14 = Red, 29 = Grey
                new Car { Id = 1, BrandId = 100, ColorId = 21, ModelYear = 2020, DailyPrice = 1500, Description = "Range Rover" },
                new Car { Id = 2, BrandId = 101, ColorId = 21, ModelYear = 2020, DailyPrice = 420, Description = "BMW X5" },
                new Car { Id = 3, BrandId = 102, ColorId = 10, ModelYear = 2020, DailyPrice = 900, Description = "Jeep Reneage" },
                new Car { Id = 4, BrandId = 103, ColorId = 14, ModelYear = 2018, DailyPrice = 250, Description = "Mini Cooper" },
                new Car { Id = 5, BrandId = 104, ColorId = 21, ModelYear = 2019, DailyPrice = 380, Description = "Audi A6" },
                new Car { Id = 6, BrandId = 105, ColorId = 14, ModelYear = 2019, DailyPrice = 275, Description = "Volkswagen Golf" },
                new Car { Id = 7, BrandId = 106, ColorId = 10, ModelYear = 2019, DailyPrice = 435, Description = "Volvo S90" },
                new Car { Id = 8, BrandId = 107, ColorId = 29, ModelYear = 2019, DailyPrice = 200, Description = "Renault Clio" },
                new Car { Id = 9, BrandId = 108, ColorId = 29, ModelYear = 2020, DailyPrice = 600, Description = "Nissan Qashqai" },
                new Car { Id = 10, BrandId = 109, ColorId = 21, ModelYear = 2019, DailyPrice = 750, Description = "Mercedes Benz-Vito" }
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

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
