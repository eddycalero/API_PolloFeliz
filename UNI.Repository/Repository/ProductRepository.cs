
namespace UNI.Repository
{
    public class ProductRepository:Repositorygeneric<Product>, IProductRepository
    {
        public ProductRepository(UNIDapperContext uNI)
            :base(uNI)
        {
        }
    }
}
