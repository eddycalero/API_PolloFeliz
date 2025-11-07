
namespace UNI.Repository
{
    public class UnitMeasureRepository: Repositorygeneric<UnitMeasure>, IUnitMeasureRepository
    {
        public UnitMeasureRepository(UNIDapperContext uNIDapper) : base(uNIDapper)
        {
            
        }
    }
}
