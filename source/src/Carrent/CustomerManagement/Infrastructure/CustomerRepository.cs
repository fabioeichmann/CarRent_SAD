using Carrent.CustomerManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Infrastructure
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool Delete(Customer customerObject)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Customer customerObject)
        {
            throw new NotImplementedException();
        }
    }
}
