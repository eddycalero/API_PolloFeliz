namespace UNI.Services.IService
{
    public interface ICategoryService
    {
        public Task<CategoryCreateDto> CreateCategoryDto(CategoryCreateDto categoryCreateDto);
        public Task<List<CategoryCreateDto>> GetAllCategories();

        public Task<CategoryCreateDto> GetCategoryById(int id);

        public Task<bool> DeleteCategoryById(int id);

        public Task<CategoryCreateDto> UpdateCategory(int id, CategoryCreateDto categoryCreateDto);
    }
}
