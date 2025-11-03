
namespace UNI.Repository
{
    public class CategoryRepository: Repositorygeneric<Category>, ICategoryRepository
    {
        public CategoryRepository(UNIDapperContext uNIDapper) : base(uNIDapper)
        {
            
        }
    }
}
