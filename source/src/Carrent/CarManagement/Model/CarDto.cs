using Carrent.CarManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Model
{
    public class CarDto
    {
        public Guid Id { get; set; }
        public Guid ClassId { get; set; }
        public CarClass Class { get; set; }
        public string Type { get; set; }
        public string Make { get; set; }
    }
}
