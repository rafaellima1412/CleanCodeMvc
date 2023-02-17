using Aplication.DTOs;
using Aplication.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class ProductVmService : IProductVwService
    {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public ProductVmService(IMapper mapper, IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }

        public async Task<ProductVw> AddAsync(ProductVw entity)
        {
            var product = _mapper.Map<CreateCommand>(entity);
            if (product == null) 
            throw new Exception("error create entity");

            await _mediator.Send(product);
        }

        public Task<ProductVw> DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<ProductVw> GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductVw>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductVw> UpdateAsync(ProductVw entity)
        {
            throw new NotImplementedException();
        }
    }
}
