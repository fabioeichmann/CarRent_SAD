using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public interface ICarRepository
    {
        List<Car> FindEntityById(Guid id);
        List<Car> GetAllEntities();
        void Insert(Car carEntity);
        void Update(Car carEntity);
        void Remove(Car carEntity);
        void RemoveById(Guid id);
    }
}
