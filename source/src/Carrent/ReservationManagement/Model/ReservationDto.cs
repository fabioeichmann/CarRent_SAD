using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Model
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string State { get; set; }
        public Guid CarId { get; set; }
        public Guid CustomerId { get; set; }
    }
}

