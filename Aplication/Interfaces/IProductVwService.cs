using Aplication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IProductVwService : IGenericService<ProductVw>
    {
        Task<ProductVw> AddAsync(ProductVw entity);
    }
}
