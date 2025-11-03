

using AutoMapper;
using UNI.Models;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class CategoryServices: ICategoryService
    {
        private readonly IUnitofWork _uni;
        private readonly IMapper _mapper;
        public CategoryServices( IUnitofWork unitof, IMapper mapper)
        { 
          _uni = unitof;
          _mapper = mapper;
        }


        public async Task<CategoryCreateDto> CreateCategoryDto(CategoryCreateDto categoryCreateDto)
        {
   
            _uni.BeginTransaction();

            try
            {
                Category category = _mapper.Map<Category>(categoryCreateDto);
                categoryCreateDto.CategoryId = await _uni.CategoryRepository.CreateAsync(category);
                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }
            return categoryCreateDto;
        }

        public async Task<List<CategoryCreateDto>> GetAllCategories()
        {
            List<CategoryCreateDto> ListCategory = new List<CategoryCreateDto>();

            try
            {
                List<Category> categories = await _uni.CategoryRepository.GetAllAsync();
                ListCategory = _mapper.Map<List<CategoryCreateDto>>(categories);
            }
            catch (Exception ex) 
            { 
                
            }

            return ListCategory;
        }
    }
}
