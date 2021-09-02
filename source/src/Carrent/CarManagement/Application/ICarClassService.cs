using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Application
{
    public interface ICarClassService
    {
        List<CarClass> GetAllClasses();
        CarClass GetClassById(Guid id);
        void Add(CarClass carClass);
        void Delete(CarClass carClass);
        void DeleteClassById(Guid id);
        void Update(CarClass carClass);
    }
}
