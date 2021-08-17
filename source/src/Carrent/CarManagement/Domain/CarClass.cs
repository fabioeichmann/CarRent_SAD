using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CarManagement.Domain
{
    public class CarClass
    {
        public CarClassType Type { get; set; }
    }

    public enum CarClassType
    {
        Luxury,
        Medium,
        Basic
    }
}
