

namespace UNI.Repository
{
    public interface IRepositoryGeneric<T>where T : class
    {
        Task<int> CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
    }
}
