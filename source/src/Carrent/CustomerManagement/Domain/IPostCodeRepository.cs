using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carrent.CustomerManagement.Domain
{
    interface IPostCodeRepository
    {
        PostCode GetById(int id);
        IEnumerable<PostCode> GetAll();
        bool Insert(PostCode postCodeObject);
        bool Delete(PostCode postCodeObject);
    }
}
