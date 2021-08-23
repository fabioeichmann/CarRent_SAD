using Carrent.Common.Interfaces;
using Carrent.ReservationManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Infrastructure
{
    public interface IReservationRepository : IRepository<Reservation>
    {
        List<Reservation> FindByCustomerId(Guid id);
        List<Reservation> FindByCarId(Guid id);
    }
}
