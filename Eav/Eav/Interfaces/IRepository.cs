using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Eav.Models;

namespace Eav.Interfaces
{
    public interface IRepository<T> where T : DatabaseObject
    {
        Task Add(T obj);
        Task<IEnumerable<T>> GetAll();
        Task<bool> Update(Guid id,T obj);
        Task<bool> Remove(Guid id);
        Task<T> GetByIdAsync(Guid id);
    }
}
