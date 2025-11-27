using AutoMapper;
using UNI.Models;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class SubCategoryServices: ISubCategoryServices
    {
        private readonly IUnitofWork _uni;
        private readonly IMapper _mapper;
        public SubCategoryServices( IUnitofWork unitof, IMapper mapper)
        { 
          _uni = unitof;
          _mapper = mapper;
        }

        public async Task<SubCategoryDto> CreateSubCategoryDto(SubCategoryDto SubCategoryDto)
        {
            _uni.BeginTransaction();

            try
            {
                SubCategory subCategoryDto = _mapper.Map<SubCategory>(SubCategoryDto);
                SubCategoryDto.SubCategoryId = await _uni.SubCategoryRepository.CreateAsync(subCategoryDto);
                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }
            return SubCategoryDto;
        }

        public async Task<bool> DeleteSubCategory(int id)
        {
            try
            {
                SubCategory subcategory = await _uni.SubCategoryRepository.GetByIdAsync(id);

                if (subcategory is null)
                {
                    return false;
                }

                await _uni.SubCategoryRepository.DeleteAsync(subcategory);
            }
            catch (Exception ex)
            {
            }

            return true;
        }

        public async Task<dynamic> GetSubCategory()
        {
            try
            {
                string query = "select * from category_list()";
                dynamic? result = await _uni!.SubCategoryRepository!.QueryFirst(query);
                return result;
            }
            catch (Exception ex)
            {
            }

            return null;
        }

        public Task<SubCategoryDto> GetSubCategory(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<SubCategoryDto> UpdateSubCategory(int id, SubCategoryDto SubCategoryDto)
        {
            _uni.BeginTransaction();
            try
            {
                SubCategory subcategory = await _uni.SubCategoryRepository.GetByIdAsync(id);
                _mapper.Map(SubCategoryDto, subcategory);

                await _uni.SubCategoryRepository.UpdateAsync(subcategory);

                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }

            return SubCategoryDto;
        }

    }
}
