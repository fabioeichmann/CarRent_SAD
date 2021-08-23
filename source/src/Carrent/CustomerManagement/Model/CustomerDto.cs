using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Model
{
    public class CustomerDto
    {
        public Guid Id { get; set; }

        public string Firstname { get; set; }

        public string Familyname { get; set; }

        public string Street { get; set; }

        public string HouseNumber { get; set; }
    }
}
