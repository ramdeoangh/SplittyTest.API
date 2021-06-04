using System.Collections.Generic;
using System.Threading.Tasks;
using SplittyTest.API.Domain.Models;

namespace SplittyTest.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> ListAsync();
        Task AddAsync(Category category);
        Task<Category> GetCategoryByNameAsync(string categoryName);
        Task<Category> GetCategoryByIdAsync(int categoryId);
        void Update(Category category);
        void Remove(Category category);
    }
}