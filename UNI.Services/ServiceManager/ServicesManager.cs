
using AutoMapper;
using UNI.Repository;
using UNI.Services.IService;

namespace UNI.Services
{
    public class ServicesManager:IServiceManager
    {
        private readonly Lazy<CategoryServices> categoryServices;
        public ServicesManager(IUnitofWork unitofWork, IMapper mapper) 
        {
            categoryServices = new Lazy<CategoryServices>(() => new CategoryServices(unitofWork, mapper));
        }

        public ICategoryService CategoryService => categoryServices.Value;
    }
}
