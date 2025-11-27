namespace UNI.Services.IService
{
    public interface ISubCategoryServices
    {
        public Task<SubCategoryDto> CreateSubCategoryDto(SubCategoryDto SubCategoryDto);

        public Task<dynamic> GetSubCategory();

        public Task<SubCategoryDto> GetSubCategory(int id);

        public Task<bool> DeleteSubCategory(int id);

        public Task<SubCategoryDto> UpdateSubCategory(int id, SubCategoryDto SubCategoryDto);
    }
}
