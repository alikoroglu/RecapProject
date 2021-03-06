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

            //carManager.Add(newCar);


            Console.WriteLine("-----Brand ID --------");
            foreach (var item in carManager.GetAllByBrandId(3))
            {
                Console.WriteLine(item.CarName);

            }
            Console.WriteLine("-----Color ID --------");
            foreach (var item in carManager.GetAllByColorId(3))
            {
                Console.WriteLine(item.CarName);
                

            }

            




        }
    }
}
