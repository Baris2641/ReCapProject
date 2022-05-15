using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryProductDal()

        {
            _cars = new List<Car> {
            new Car { CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 350, Desctription = "Renault Clio 1.0 Benzinli" },
            new Car { CarId = 2, BrandId = 1, ColorId = 1, ModelYear = 2022, DailyPrice = 350, Desctription = "Renault Symbol 1.5 Dizel" },
            new Car { CarId = 3, BrandId = 2, ColorId = 1, ModelYear = 2022, DailyPrice = 350, Desctription = "Fiat Egea 1.0 Benzinli" },
            new Car { CarId = 4, BrandId = 2, ColorId = 1, ModelYear = 2022, DailyPrice = 350, Desctription = "Fiat Egea 1.0 Benzinli" },
            new Car { CarId = 5, BrandId = 3, ColorId = 1, ModelYear = 2022, DailyPrice = 350, Desctription = "Volswagen Passat 2.0 Benzinli" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Desctription = car.Desctription;
        }
    }
}
