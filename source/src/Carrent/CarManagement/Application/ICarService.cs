using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Application
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        List<Car> GetCarById(Guid id);
        List<Car> GetCarByType(CarClassType type);
        void Add(Car car);
        void Delete(Car car);
        void DeleteById(Guid id);
        void Update(Car car);
    }
}
