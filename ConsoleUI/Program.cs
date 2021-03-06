using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car()
            {
                CarId = 5,
                BrandId = 3,
                ColorId = 3,
                DailyPrice = 130.0m,
                ModelYear = 2007,
                Description = "Gri Tofaş Hasarlı"

            };

            // Yeni araç ekle
            InMemoryProductDal carDal = new InMemoryProductDal();
            carDal.Add(newCar);

            // Tüm araçları listele
            CarManager carManager = new CarManager(new InMemoryProductDal());
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.Description);
            }
            
            
        }
    }
}
