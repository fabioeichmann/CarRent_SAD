using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public class CarClass
    {
        public Guid Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public decimal DailyPrice { get; set; }
    }
}
