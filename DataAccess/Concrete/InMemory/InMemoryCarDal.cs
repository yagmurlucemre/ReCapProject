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
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=2018, DailyPrice=150, Description="Toyota CHR"},
                new Car{CarId=2, BrandId=2, ColorId=2, ModelYear=2019, DailyPrice=170, Description="Audi A4"},
                new Car{CarId=3, BrandId=3, ColorId=3, ModelYear=2020, DailyPrice=160, Description="Pegeout 3008"},
                new Car{CarId=4, BrandId=4, ColorId=4, ModelYear=2021, DailyPrice=180, Description="Mercedes"},
                new Car{CarId=5, BrandId=5, ColorId=5, ModelYear=2017, DailyPrice=130, Description="Opel"}
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.CarId == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

           

        }

        

    }
}
