using Carrent.Common.Application;
using Carrent.CustomerManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Application
{
    public interface ICustomerService : IService<Customer>
    {
    }
}
