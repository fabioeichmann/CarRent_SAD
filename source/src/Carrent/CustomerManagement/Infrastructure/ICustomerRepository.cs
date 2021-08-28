using Carrent.Common.Interfaces;
using Carrent.CustomerManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Infrastructure
{
    public interface ICustomerRepository : IRepository<Customer>
    {

    }
}
