using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //Veritabanı yerine
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{CarName="BMW",CarId=1,BrandId=1,ColorId=1,ModelYear=2008,DailyPrice=150.0m,Description="Kırmızı BMW temiz"},
                new Car{CarName="Mercedes",CarId=2,BrandId=2,ColorId=1,ModelYear=2015,DailyPrice=200.0m,Description="Kırmızı Mercedes temiz"},
                new Car{CarName="...",CarId=3,BrandId=1,ColorId=2,ModelYear=2016,DailyPrice=213.80m,Description="Siyah BMW temiz"},
                new Car{CarName="...",CarId=4,BrandId=3,ColorId=3,ModelYear=2005,DailyPrice=150.0m,Description="Beyaz Renault temiz"}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.CarId+": Araç eklendi");
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
            Console.WriteLine(car.CarId + ": Araç silindi");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.BrandId = car.BrandId;
            
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

            Console.WriteLine(car.CarId + ": Araç güncellendi");
        }
    }
}
