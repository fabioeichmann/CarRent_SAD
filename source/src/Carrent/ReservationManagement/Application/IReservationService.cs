using Carrent.Common.Application;
using Carrent.ReservationManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Application
{
    public interface IReservationService : IService<Reservation>
    {
        List<Reservation> GetReservationByCarId(Guid id);

        List<Reservation> GetReservationByCustomerId(Guid id);
    }
}
