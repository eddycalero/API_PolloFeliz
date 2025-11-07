namespace UNI.Services.IService
{
    public interface IUnitMeasureServices
    {
        public Task<UnitMeasureCreateDto> CreateUnitMeasureDto(UnitMeasureCreateDto unitMeasureCreateDto);


        public Task<List<UnitMeasureCreateDto>> GetAllUnitMeasure();

        public Task<UnitMeasureCreateDto> GetUnitMeasureById(int id);

        public Task<bool> DeleteUnitMeasureById(int id);

        public Task<UnitMeasureCreateDto> UpdateUnitMeasure(int id, UnitMeasureCreateDto unitMeasureCreateDto);
    }
}
