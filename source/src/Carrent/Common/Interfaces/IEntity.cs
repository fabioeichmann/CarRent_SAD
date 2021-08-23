using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.Common.Interfaces
{
    public interface IEntity<T>
    {
        [Key]
        T Id { get; set; }
    }
}
