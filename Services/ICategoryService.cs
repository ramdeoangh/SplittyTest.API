using System.Collections.Generic;
using System.Threading.Tasks;
using SplittyTest.API.Domain.Models;
using SplittyTest.API.Responses;
namespace SplittyTest.API.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
        Task<CategoryResponse> SaveAsync(Category category);
        Task<CategoryResponse> UpdateAsync(int id, Category category);
        Task<CategoryResponse> DeleteAsync(int id);

    }
}