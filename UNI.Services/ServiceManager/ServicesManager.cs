
using AutoMapper;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class ServicesManager:IServiceManager
    {
        private readonly Lazy<CategoryServices> categoryServices;
        private readonly Lazy<UnitMeasureServices> unitMeasureServices;
        private readonly Lazy<SubCategoryServices> subCategoryServices;
        private readonly Lazy<ProductServices> productServices;
        public ServicesManager(IUnitofWork unitofWork, IMapper mapper) 
        {
            categoryServices = new Lazy<CategoryServices>(() => new CategoryServices(unitofWork, mapper));
            unitMeasureServices = new Lazy<UnitMeasureServices>(() => new UnitMeasureServices(unitofWork, mapper));
            subCategoryServices = new Lazy<SubCategoryServices>(()  => new SubCategoryServices(unitofWork,mapper));
            productServices = new Lazy<ProductServices>(() => new ProductServices(unitofWork, mapper));
        }


        public ICategoryService CategoryService => categoryServices.Value;

        public IUnitMeasureServices UnitMeasureService => unitMeasureServices.Value;

        public ISubCategoryServices SubCategoryService => subCategoryServices.Value;

        public ProductServices ProductServices => productServices.Value;
    }
}
