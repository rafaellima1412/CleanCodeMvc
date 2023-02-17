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
        public async Task AddAsync(CategoryVw entity)
        {
            var category = _mapper.Map<Category>(entity);
            if (category == null)
                throw new Exception("Error add entity");
            await _categoryRepository.CreateAsync(category);
        }


        public async Task DeleteAsync(int? id)
        {
            var category = _categoryRepository.GetByID(id).Result;
            if (category == null)
                throw new Exception("Error remove entity");
            await _categoryRepository.RemoveAsync(category);
        }


        public async Task GetByIdAsync(int? id)
        {
            var category = await _categoryRepository.GetByID(id);
            if (category == null) throw new Exception("error id entity");
            _mapper.Map<CategoryVw>(category);
        }



        public async Task UpdateAsync(CategoryVw entity)
        {
            var category = _mapper.Map<Category>(entity);
            if (category == null) throw new Exception("error update entity");
            await _categoryRepository.UpdateAsync(category);
        }

        public async Task<IEnumerable<CategoryVw>> GetListAsync()
        {
            var categories = await _categoryRepository.GetListGeneric();
            if (categories == null) throw new Exception("error list entity");
            return (IEnumerable<CategoryVw>)_mapper.Map<CategoryVw>(categories);
        }

        Task ICategoryVwService.CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }

        Task ICategoryVwService.RemoveAsync(CategoryVw category)
        {
            throw new NotImplementedException();
        }

        async Task<CategoryVw> IGenericService<CategoryVw>.GetByIdAsync(int? id)
        {
            var category = await _categoryRepository.GetByID(id); 
            if(category == null) throw new Exception("Error id Entity");
            return _mapper.Map<CategoryVw>(category);
        }

        Task<CategoryVw> IGenericService<CategoryVw>.AddAsync(CategoryVw entity)
        {
            throw new NotImplementedException();
        }


        Task<CategoryVw> IGenericService<CategoryVw>.DeleteAsync(int? id)
        {
            throw new NotImplementedException();
        }

        Task<CategoryVw> IGenericService<CategoryVw>.UpdateAsync(CategoryVw entity)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
