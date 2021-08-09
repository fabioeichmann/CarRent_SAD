using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {
        public List<Car> FindEntityById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public void Insert(Car carEntity)
        {
            throw new NotImplementedException();
        }

        public void Remove(Car carEntity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car carEntity)
        {
            throw new NotImplementedException();
        }
    }
}
