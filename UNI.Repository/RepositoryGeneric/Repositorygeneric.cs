

namespace UNI.Repository
{
    public class Repositorygeneric<T> : IRepositoryGeneric<T> where T : class
    {
        private readonly UNIDapperContext _context;
        public Repositorygeneric(UNIDapperContext dapperContext)
        {
            _context = dapperContext;
        }
        public async Task<int> CreateAsync(T entity)
        {
            return await _context.Connection.InsertAsync(entity);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            return await _context.Connection.DeleteAsync(entity);
        }

        public async Task UpdateAsync(T entity)
        {
             await _context.Connection.UpdateAsync(entity);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return (await _context.Connection.GetAllAsync<T>()).ToList();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Connection.GetAsync<T>(id);
        }
    }
}
