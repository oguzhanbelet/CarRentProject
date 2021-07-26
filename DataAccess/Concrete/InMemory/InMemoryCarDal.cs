using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=300, ModelYear=2019, Description= "Ford Focus Beyaz Dizel" },
                new Car{CarId=2, BrandId=1, ColorId=1, DailyPrice=300, ModelYear=2019, Description= "Ford Focus Beyaz Dizel" },
                new Car{CarId=3, BrandId=1, ColorId=1, DailyPrice=300, ModelYear=2019, Description= "Ford Focus Beyaz Dizel" },
                new Car{CarId=4, BrandId=2, ColorId=1, DailyPrice=400, ModelYear=2020, Description= "Ford Focus Beyaz Dizel" },
                new Car{CarId=5, BrandId=2, ColorId=2, DailyPrice=400, ModelYear=2020, Description= "Renault Clio Siyah Dizel" },
                new Car{CarId=6, BrandId=2, ColorId=2, DailyPrice=400, ModelYear=2020, Description= "Renault Clio Siyah Dizel" },
                new Car{CarId=7, BrandId=3, ColorId=2, DailyPrice=500, ModelYear=2021, Description= "Seat Leon Siyah Dizel" },
                new Car{CarId=8, BrandId=3, ColorId=2, DailyPrice=500, ModelYear=2021, Description= "Seat Leon Siyah Dizel" }
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
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

        public List<Car> GetById(Car car)
        {
            return _cars.Where(c => c.CarId == car.CarId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
