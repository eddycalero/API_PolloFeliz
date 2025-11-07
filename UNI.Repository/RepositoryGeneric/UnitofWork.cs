

using System.Data;

namespace UNI.Repository
{
    public class UnitofWork : IUnitofWork
    {
        private readonly UNIDapperContext _context;
        private bool _disposed;

        public ICategoryRepository CategoryRepository { get; }

        public IUnitMeasureRepository UnitMeasureRepository { get; }

        public ISubCategoryRepository SubCategoryRepository { get; }
        

        public UnitofWork(UNIDapperContext uNIDapper)
        {
            _context = uNIDapper;
            CategoryRepository = new CategoryRepository(_context);
            UnitMeasureRepository = new UnitMeasureRepository(_context);
            SubCategoryRepository = new SubCategoryRepository(_context);
        }

        public void BeginTransaction()
        {
            _context.Connection?.Open();
            _context.Transaction = _context.Connection?.BeginTransaction();
        }

        public void Commit()
        {
            _context.Transaction?.Commit();
            _context.Transaction?.Dispose();
            _context.Transaction = null;

            if (_context.Connection?.State == ConnectionState.Open)
                _context.Connection.Close();
        }

        public void Rollback()
        {
            _context.Transaction?.Rollback();
            _context.Transaction?.Dispose();
            _context.Transaction = null;

            if (_context.Connection?.State == ConnectionState.Open)
                _context.Connection.Close();
        }
    }
}
