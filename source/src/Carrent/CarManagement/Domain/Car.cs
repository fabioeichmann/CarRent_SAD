using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public class Car
    {
        public Guid Id { get; set; }

        [Required]
        public Guid ClassId { get; set; }

        public CarClass Class { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Type { get; set; }
    }
}
