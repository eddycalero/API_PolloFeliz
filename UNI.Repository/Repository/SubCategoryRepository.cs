
namespace UNI.Repository
{
    public class SubCategoryRepository: Repositorygeneric<SubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(UNIDapperContext uNIDapper) : base(uNIDapper)
        {
            
        }
    }
}
