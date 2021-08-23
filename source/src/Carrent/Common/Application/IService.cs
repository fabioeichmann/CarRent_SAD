using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.Common.Application
{
    public interface IService<T>
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Delete(T entity);
        void DeleteById(Guid id);
        void Update(T entity);
    }
}

