using Aplication.DTOs;
using Aplication.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Services
{
    public class CategoryVwService : ICategoryVwService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryVwService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task AddAsync(CategoryVm entity)
        {
            var category = _mapper.Map<Category>(entity);
            if (category == null)
                throw new Exception("Error add entity");
            await _categoryRepository.CreateAsync(category);
        }

        public Task CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int? id)
        {
            var category = _categoryRepository.GetById(id).Result;
            if (category == null)
                throw new Exception("Error remove entity");
            await _categoryRepository.RemoveAsync(category);
        }


        public Task GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryVm>> GetListAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(CategoryVm category)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryVm> UpdateAsync(CategoryVm entity)
        {
            throw new NotImplementedException();
        }

        Task<CategoryVm> IGenericService<CategoryVm>.AddAsync(CategoryVm entity)
        {
            throw new NotImplementedException();
        }

        Task<CategoryVm> IGenericService<CategoryVm>.DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        Task<CategoryVm> IGenericService<CategoryVm>.GetByIdAsync(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
