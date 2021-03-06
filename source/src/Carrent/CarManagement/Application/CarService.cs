using Carrent.CarManagement.Domain;
using Carrent.CarManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Application
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _repository;

        public CarService(ICarRepository repository)
        {
            _repository = repository;
        }

        public void Add(Car car)
        {
            _repository.Insert(car);
        }

        public void Delete(Car car)
        {
            _repository.Remove(car);
        }

        public void DeleteCarById(Guid id)
        {
            _repository.RemoveById(id);
        }

        public List<Car> GetAllCars()
        {
            return _repository.GetAllEntities();
        }

        public Car GetCarById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public List<Car> GetCarByType(CarClass type)
        {
            return _repository.GetAllEntities().Where(e => e.Type == type.Type).ToList();
        }

        public void Update(Car car)
        {
            _repository.Update(car);
        }
    }
}
