using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SplittyTest.API.Domain.Models;
using SplittyTest.API.Services;
using SplittyTest.API.Repositories.Interface;
using SplittyTest.API.Responses;


namespace SplittyTest.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CategoryService(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }

        public async Task<CategoryResponse> SaveAsync(Category category)
        {
            try
            {
                Category _category = await _categoryRepository.GetCategoryByNameAsync(category.Name);
                if (_category != null)
                    return new CategoryResponse($"Category Name= {category.Name} already exist.");

                await _categoryRepository.AddAsync(category);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(category);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CategoryResponse($"An error occurred when saving the category: {ex.Message}");
            }
        }
        public async Task<CategoryResponse> UpdateAsync(int id, Category category)
        {
            try
            {
                Category existingCategory = await _categoryRepository.GetCategoryByIdAsync(id);
                if (existingCategory == null)
                    return new CategoryResponse($"Category not found.");

                existingCategory.Name = category.Name;
                _categoryRepository.Update(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CategoryResponse($"An error occurred when updating the category: {ex.Message}");
            }
        }

        public async Task<CategoryResponse> DeleteAsync(int id)
        {
            try
            {
                Category existingCategory = await _categoryRepository.GetCategoryByIdAsync(id);
                if (existingCategory == null)
                    return new CategoryResponse($"Category not found.");

                _categoryRepository.Remove(existingCategory);
                await _unitOfWork.CompleteAsync();

                return new CategoryResponse(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new CategoryResponse($"An error occurred when updating the category: {ex.Message}");
            }
        }
    }
}