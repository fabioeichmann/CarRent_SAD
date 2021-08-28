using Carrent.CarManagement.Domain;
using Carrent.CarManagement.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Infrastructure
{
    public class CarRepository : ICarRepository
    {

        private readonly CarRentDbContext _dbContext;

        public CarRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }

        public Car FindEntityById(Guid id)
        {
            return _dbContext.Cars.Include(e => e.Class).Where(c => c.Id.Equals(id)).FirstOrDefault();
        }

        public List<Car> GetAllEntities()
        {
            return _dbContext.Cars.Select(e => e).Include(e => e.Class).ToList();
        }

        public void Insert(Car carEntity)
        {
            _dbContext.Cars.Add(carEntity);
            _dbContext.SaveChanges();
        }

        public void Remove(Car carEntity)
        {
            Remove(carEntity);
        }

        public void RemoveById(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.Cars.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(Car carEntity)
        {
            _dbContext.Update(carEntity);
            _dbContext.SaveChanges();
        }
    }
}
