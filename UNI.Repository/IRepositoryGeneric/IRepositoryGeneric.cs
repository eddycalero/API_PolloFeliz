

namespace UNI.Repository
{
    public interface IRepositoryGeneric<T>where T : class
    {
        Task<dynamic?> QueryFirst(string query);
        Task<int> CreateAsync(T entity);
        Task<List<T>> GetAllAsync();
        Task<bool> DeleteAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task UpdateAsync(T entity);
    }
}
