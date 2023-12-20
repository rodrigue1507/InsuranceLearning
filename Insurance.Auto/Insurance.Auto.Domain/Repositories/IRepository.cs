using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Insurance.Auto.Domain.Models;

namespace Insurance.Auto.Domain.Abstractions
{
    internal interface IRepository<T>
    {
        Task<long> Create(T toCreate);
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(long id);
    }
}
