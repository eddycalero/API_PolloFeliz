
using AutoMapper;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class ServicesManager:IServiceManager
    {
        private readonly Lazy<CategoryServices> categoryServices;
        private readonly Lazy<UnitMeasureServices> unitMeasureServices;
        public ServicesManager(IUnitofWork unitofWork, IMapper mapper) 
        {
            categoryServices = new Lazy<CategoryServices>(() => new CategoryServices(unitofWork, mapper));
            unitMeasureServices = new Lazy<UnitMeasureServices>(() => new UnitMeasureServices(unitofWork, mapper));

        }


        public ICategoryService CategoryService => categoryServices.Value;

        public IUnitMeasureServices UnitMeasureService => unitMeasureServices.Value;
    }
}
