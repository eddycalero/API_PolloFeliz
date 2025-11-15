
namespace UNI.Repository
{
    public interface IUnitofWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        public ICategoryRepository CategoryRepository { get; }
        public IUnitMeasureRepository UnitMeasureRepository { get; }
        public ISubCategoryRepository SubCategoryRepository { get; }
        public IProductRepository ProductRepository { get; }
    }
}
