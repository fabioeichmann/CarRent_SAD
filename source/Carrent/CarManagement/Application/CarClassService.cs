using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Application
{
    public class CarClassService : ICarClassService
    {
        private readonly ICarClassRepository _repository;

        public CarClassService(ICarClassRepository repository)
        {
            _repository = repository;
        }

        public void Add(CarClass carClass)
        {
            _repository.Insert(carClass);
        }

        public void Delete(CarClass carClass)
        {
            _repository.Remove(carClass);
        }

        public void DeleteById(Guid id)
        {
            _repository.RemoveById(id);
        }

        public List<CarClass> GetAllClasses()
        {
            return _repository.GetAllEntities();
        }

        public List<CarClass> GetClassById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public void Update(CarClass carClass)
        {
            _repository.Update(carClass);
        }
    }
}
