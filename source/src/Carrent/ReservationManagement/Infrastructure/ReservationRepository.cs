using Carrent.CarManagement.Infrastructure.Context;
using Carrent.ReservationManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Infrastructure
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CarRentDbContext _dbContext;

        public ReservationRepository(CarRentDbContext carRentDbContext)
        {
            _dbContext = carRentDbContext;
        }

        public Reservation FindEntityById(Guid id)
        {
            return _dbContext.Reservations.Select(r => r).Where(r => r.Id.Equals(id)).FirstOrDefault();
        }

        public List<Reservation> FindByCustomerId(Guid id)
        {
            return _dbContext.Reservations.Select(r => r).Where(r => r.CustomerId.Equals(id)).ToList();
        }

        public List<Reservation> FindByCarId(Guid id)
        {
            return _dbContext.Reservations.Select(r => r).Where(r => r.CarId.Equals(id)).ToList();
        }

        public List<Reservation> GetAllEntities()
        {
            return _dbContext.Reservations.Select(r => r).ToList();
        }

        public void Insert(Reservation entity)
        {
            _dbContext.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Remove(Reservation entity)
        {
            Remove(entity.Id);
        }

        public void Remove(Guid id)
        {
            var isNotNull = FindEntityById(id);
            if (isNotNull != null)
            {
                _dbContext.Reservations.Remove(isNotNull);
                _dbContext.SaveChanges();
            }
        }

        public void Update(Reservation entity)
        {
            _dbContext.Reservations.Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
