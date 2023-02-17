using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetListGeneric();
        Task<T> GetByID(int? id);
        Task<T> CreateAsync(T entity);
        Task<T> RemoveAsync(T entity);
        Task<T> UpdateAsync(T entity);


    }
}
