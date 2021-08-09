using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Infrastructure
{
    public class CarClassRepository : ICarClassRepository
    {
        public List<CarClass> FindEntityById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<CarClass> GetAllEntities()
        {
            throw new NotImplementedException();
        }

        public void Insert(CarClass carEntity)
        {
            throw new NotImplementedException();
        }

        public void Remove(CarClass carEntity)
        {
            throw new NotImplementedException();
        }

        public void RemoveById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(CarClass carEntity)
        {
            throw new NotImplementedException();
        }
    }
}
