using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.ReservationManagement.Domain
{
    public class Reservation
    {
        public Guid Id { get; set; }

        [Required]
        public DateTime Start { get; set; }

        [Required]
        public DateTime End { get; set; }

        public string State { get; set; }
        [Required]
        public Guid CarId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }
    }

    public enum ReservationState
    {
        Reserved,
        Rented
    }
}
