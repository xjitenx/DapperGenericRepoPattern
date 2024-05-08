using System.Data.SqlClient;
using System.Data;

namespace DapperGenericRepoPattern.DataContext
{
    public class DapperDataContext: IDapperDataContext
    {
        private readonly IConfiguration _configuration;
        private readonly string? _connectionString;
        private IDbConnection? _connection;
        public DapperDataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection? Connection
        {
            get
            {
                if (_connection is null || _connection.State != ConnectionState.Open)
                    _connection = new SqlConnection(_connectionString);
                return _connection;
            }
        }
    }
}
