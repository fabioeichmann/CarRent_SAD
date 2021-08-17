using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Domain
{
    interface ICustomerRepository
    {
        Customer GetById(Guid id);
        IEnumerable<Customer> GetAll();
        bool Insert(Customer customerObject);
        bool Delete(Customer customerObject);
    }
}
