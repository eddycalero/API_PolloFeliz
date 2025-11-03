namespace UNI.Services.IService
{
    public interface ICategoryService
    {
        public Task<CategoryCreateDto> CreateCategoryDto(CategoryCreateDto categoryCreateDto);
        public Task<List<CategoryCreateDto>> GetAllCategories();
    }
}
