using ProjectTracker.Dtos.Requests;
using ProjectTracker.Dtos.Responses;

namespace ProjectTracker.Business
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryListResponse>> GetCategories();
        Task<int> CreateCategory(CreateCategoryRequest createCategoryRequest);
        Task UpdateCategory(UpdateCategoryRequest updateCategoryRequest);

        Task<CategoryListResponse> GetCategory(int id);


    }
}
