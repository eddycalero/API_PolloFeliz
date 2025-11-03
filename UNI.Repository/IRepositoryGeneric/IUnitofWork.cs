
namespace UNI.Repository
{
    public interface IUnitofWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();

        public ICategoryRepository CategoryRepository { get; }
    }


}
