using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear="2021", DailyPrice=2000000, Description="Mercedes G-Series G63"},
                new Car{CarId=2, BrandId=1, ColorId=1, ModelYear="2018", DailyPrice=1500000, Description="Mercedes G-Series G350"},
                new Car{CarId=3, BrandId=2, ColorId=2, ModelYear="2010", DailyPrice=175000, Description="BMW A180d"},
                new Car{CarId=4, BrandId=2, ColorId=3, ModelYear="2017", DailyPrice=550000, Description="BMW i8"},
                new Car{CarId=5, BrandId=2, ColorId=3, ModelYear="2015", DailyPrice=750000, Description="BMW M5"},
                new Car{CarId=6, BrandId=3, ColorId=4, ModelYear="1967", DailyPrice=900000, Description="Ford Mustang"},
                new Car{CarId=7, BrandId=3, ColorId=5, ModelYear="2020", DailyPrice=250000, Description="Ford Mustang Shelby GT500"},
                new Car{CarId=8, BrandId=4, ColorId=6, ModelYear="2021", DailyPrice=5000000, Description="Tesla Model 5"},
                new Car{CarId=9, BrandId=5, ColorId=5, ModelYear="2018", DailyPrice=3000000, Description="Range Rover Evoque"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
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

        public List<Car> GetCarById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList(); 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
