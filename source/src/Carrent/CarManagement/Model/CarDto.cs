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
        public string Name { get; set; }
        public string Make { get; set; }
        public string Class { get; set; }
        public decimal DailyPrice { get; set; }

        public CarDto(Guid id, Guid classId, string name)
        {
            Id = id;
            ClassId = classId;
            Name = name;
        }
    }
}
