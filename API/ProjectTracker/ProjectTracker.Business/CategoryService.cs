using AutoMapper;
using ProjectTracker.DataAccess.Repositories;
using ProjectTracker.Domain;
using ProjectTracker.Dtos.Requests;
using ProjectTracker.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public async Task<int> CreateCategory(CreateCategoryRequest createCategoryRequest)
        {
            var category = mapper.Map<Category>(createCategoryRequest);
            await categoryRepository.Add(category);
            return category.Id;

        }

        public async Task<IEnumerable<CategoryListResponse>> GetCategories()
        {
            var categories = await categoryRepository.GetAll();
            var result = mapper.Map<IEnumerable<CategoryListResponse>>(categories);
            return result;
        }

        public async Task<CategoryListResponse> GetCategory(int id)
        {
            var category = await categoryRepository.GetById(id);
            return mapper.Map<CategoryListResponse>(category);
        }

        public async Task UpdateCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            var category = mapper.Map<Category>(updateCategoryRequest);
            await categoryRepository.Update(category);
        }
    }
}
