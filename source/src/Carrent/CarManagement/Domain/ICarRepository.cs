using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public interface ICarRepository
    {
        Car GetById(int id);
        IEnumerable<Car> GetAll();
        bool Insert(Car carObject);
        bool Delete(Car carObject);

    }
}
