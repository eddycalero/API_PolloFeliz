

using UNI.Services.IService;

namespace UNI.Services
{
    public interface IServiceManager
    {
        public ICategoryService CategoryService { get; }                                                                                                                     

       public IUnitMeasureServices UnitMeasureService { get; }

       public ISubCategoryServices SubCategoryService { get; }
    }
}
