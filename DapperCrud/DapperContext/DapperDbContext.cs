using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DapperCrud.DapperContext
{
    public class DapperDbContext:DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string connectionString;
        public DapperDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public IDbConnection CreateConnection() => new SqlConnection(connectionString);
    }
}
