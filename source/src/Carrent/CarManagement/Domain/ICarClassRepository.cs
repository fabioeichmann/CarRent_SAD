using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public interface ICarClassRepository
    {
        CarClass GetById(int id);
        IEnumerable<CarClass> GetAll();
        bool Insert(CarClass carClassObject);
        bool Delete(CarClass carClassObject);

    }
}
