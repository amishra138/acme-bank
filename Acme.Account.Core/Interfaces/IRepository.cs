using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Acme.Account.Core.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        Task<T> CreateAsync(T entity);
        Task DeleteAsync(Guid id);
        Task<T> DeleteAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetAsync(Guid id);
    }
}
