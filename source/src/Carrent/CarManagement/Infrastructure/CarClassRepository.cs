using Carrent.CarManagement.Domain;
using Carrent.CarManagement.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Infrastructure
{
    public class CarClassRepository : ICarClassRepository
    {

        private readonly CarRentDbContext _dbContext;

        public CarClassRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }

        public CarClass FindEntityById(Guid id)
        {
            return _dbContext.CarClasses.Select(cl => cl).Where(cl => cl.Id.Equals(id)).FirstOrDefault();
        }

        public List<CarClass> GetAllEntities()
        {
            return _dbContext.CarClasses.Select(cl => cl).ToList();
        }

        public void Insert(CarClass carClassEntity)
        {
            _dbContext.Add(carClassEntity);
            _dbContext.SaveChanges();
        }

        public void Remove(CarClass carClassEntity)
        {
            RemoveById(carClassEntity.Id);
        }

        public void RemoveById(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.CarClasses.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(CarClass carClassEntity)
        {
            _dbContext.Update(carClassEntity);
            _dbContext.SaveChanges();
        }
    }
}
