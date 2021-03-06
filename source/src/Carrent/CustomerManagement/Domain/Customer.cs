using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Domain
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Familyname { get; set; }

        [Required]
        public string Street { get; set; }

        public string HouseNumber { get; set; }
    }
}
