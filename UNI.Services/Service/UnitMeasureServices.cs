

using AutoMapper;
using UNI.Models;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class UnitMeasureServices: IUnitMeasureServices
    {
        private readonly IUnitofWork _uni;
        private readonly IMapper _mapper;
        public UnitMeasureServices( IUnitofWork unitof, IMapper mapper)
        { 
          _uni = unitof;
          _mapper = mapper;
        }



        public async Task<UnitMeasureCreateDto> CreateUnitMeasureDto(UnitMeasureCreateDto unitMeasureCreateDto)
        {
            _uni.BeginTransaction();

            try
            {
                UnitMeasure unitMeasure = _mapper.Map<UnitMeasure>(unitMeasureCreateDto);
                unitMeasureCreateDto.UnitMeasureId = await _uni.UnitMeasureRepository.CreateAsync(unitMeasure);
                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }
            return unitMeasureCreateDto;
        }

        public async Task<bool> DeleteUnitMeasureById(int id)
        {
            try
            {
                UnitMeasure measure = await _uni.UnitMeasureRepository.GetByIdAsync(id);

                if (measure is null)
                {
                    return false;
                }

                await _uni.UnitMeasureRepository.DeleteAsync(measure);
            }
            catch (Exception ex)
            {

            }

            return true;
        }

        
      
        public async Task<List<UnitMeasureCreateDto>> GetAllUnitMeasure()
        {

            List<UnitMeasureCreateDto> ListMeasure = new List<UnitMeasureCreateDto>();

            try
            {
                List<UnitMeasure> unitMeasures = await _uni.UnitMeasureRepository.GetAllAsync();
                ListMeasure = _mapper.Map<List<UnitMeasureCreateDto>>(unitMeasures);
            }
            catch (Exception ex)
            {

            }

            return ListMeasure;

        }

        public Task<UnitMeasureCreateDto> GetUnitMeasureById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CategoryCreateDto> UpdateCategory(int id, CategoryCreateDto categoryCreateDto)
        { 
            
            _uni.BeginTransaction();
            try
            {
                Category category = await _uni.CategoryRepository.GetByIdAsync(id);
                _mapper.Map(categoryCreateDto, category);

                await _uni.CategoryRepository.UpdateAsync(category);

                _uni.Commit();
            }
            catch (Exception ex) 
            {
                 _uni.Rollback();
            }
            
            return categoryCreateDto;   

        }

        public async Task<UnitMeasureCreateDto> UpdateUnitMeasure(int id, UnitMeasureCreateDto unitMeasureCreateDto)
        {
            _uni.BeginTransaction();
            try
            {
                UnitMeasure unitMeasure = await _uni.UnitMeasureRepository.GetByIdAsync(id);
                _mapper.Map(unitMeasureCreateDto, unitMeasure);

                await _uni.UnitMeasureRepository.UpdateAsync(unitMeasure);

                _uni.Commit();
            }
            catch (Exception ex)
            {
                _uni.Rollback();
            }

            return unitMeasureCreateDto;
        }
    }
}
