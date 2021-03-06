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
            Car newCar = new Car()
            {
                CarName = "Tofas",
                CarId = 5,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 130.0m,
                ModelYear = 2007,
                Description = "Gri Tofaş Hasarlı"

            };

            carManager.Add(newCar);


            
            
            
        }
    }
}
