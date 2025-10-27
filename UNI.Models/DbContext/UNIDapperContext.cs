

using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace UNI.Models
{
    public class UNIDapperContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;

        private IDbConnection _dbConnection;
        private IDbTransaction _dbTransaction;
        public UNIDapperContext( IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection Connection {
            get {
                if(_dbConnection  is null || _dbConnection.State != ConnectionState.Open)
                {
                    _dbConnection = new NpgsqlConnection( _connectionString );
                }
                return _dbConnection;
                    
             }
        }

        public IDbTransaction Transaction
        {
            get => _dbTransaction;
            set => _dbTransaction = value;
        }
    }
}
