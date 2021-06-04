
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SplittyTest.API.Domain.Models;
using SplittyTest.API.Repositories.Interface;
using SplittyTest.API.Persistence.Contexts;

namespace SplittyTest.API.Persistence.Repositories.Implementation
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public async Task<Category> GetCategoryByNameAsync(string categoryName)
        {
            var result = await _context.Categories.Where(w => string.Equals(w.Name, categoryName)).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            var result = await _context.Categories.Where(c => c.Id == categoryId).FirstOrDefaultAsync();
            return result;
        }
        public void Update(Category category)
        {
            _context.Categories.Update(category);
        }
        public void Remove(Category category)
        {
            _context.Categories.Remove(category);
        }
    }
}