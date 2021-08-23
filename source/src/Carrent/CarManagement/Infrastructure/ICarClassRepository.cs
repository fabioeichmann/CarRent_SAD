using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Infrastructure
{
    public interface ICarClassRepository
    {
        List<CarClass> FindEntityById(Guid id);
        List<CarClass> GetAllEntities();
        void Insert(CarClass carEntity);
        void Update(CarClass carEntity);
        void Remove(CarClass carEntity);
        void RemoveById(Guid id);

    }
}
