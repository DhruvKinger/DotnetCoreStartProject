using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationProject.Contracts.Persistence
{
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetIdByAsync(Guid Id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity); 
        Task<T> DeleteAsync(T entity);
        Task<IReadOnlyList<T>> ListAllAsync(); 

    }
}
