using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        //Injection Dal'dan
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
           if(car.CarName.Length>2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine(car.CarName + ": Veritabanına eklendi");

            }
            else { Console.WriteLine("Geçersiz araç ismi veya günlük ücret"); }
        }

        public List<Car> GetAll()
        {
            /// İş kodları
            /// .
            /// .
            /// .
            /// .
            /// 
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
            return _carDal.GetAll(p=>p.BrandId==brandId);
        
        }

        public List<Car> GetAllByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        
        }
    }
}
