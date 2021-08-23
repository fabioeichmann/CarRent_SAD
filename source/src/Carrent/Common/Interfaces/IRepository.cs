using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.Common.Interfaces
{
    public interface IRepository<T>
    {
        T FindEntityById(Guid id);
        List<T> GetAllEntities();
        void Insert(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(Guid id);
    }
}
