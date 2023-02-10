using Aplication.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface ICategoryVwService : IGenericService<CategoryVw>
    {
        Task AddAsync(CategoryVw entity);
        Task CreateAsync(Category category);
        Task DeleteAsync(int? id);
        Task GetByIdAsync(int? id);
        Task RemoveAsync(CategoryVw category);
    }
}
