using Carrent.ReservationManagement.Domain;
using Carrent.ReservationManagement.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Application
{
    public class ReservationService : IReservationService
    {
        private readonly IReservationRepository _repository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _repository = reservationRepository;
        }

        public void Add(Reservation entity)
        {
            _repository.Insert(entity);
        }

        public void Delete(Reservation entity)
        {
            _repository.Remove(entity);
        }





        public void DeleteById(Guid id)
        {
            _repository.Remove(id);
        }

        public List<Reservation> GetAll()
        {
            return _repository.GetAllEntities();
        }

        public Reservation GetById(Guid id)
        {
            return _repository.FindEntityById(id);
        }

        public List<Reservation> GetReservationByCarId(Guid id)
        {
            return _repository.FindByCustomerId(id);
        }

        public List<Reservation> GetReservationByCustomerId(Guid id)
        {
            return _repository.FindByCustomerId(id);
        }

        public void Update(Reservation entity)
        {
            _repository.Update(entity);
        }
    }
}
