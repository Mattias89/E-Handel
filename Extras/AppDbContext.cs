using Microsoft.Data.SqlClient;

namespace E_Handel.Extras
{
    public interface IDBContext
    {
        SqlConnection GetConnection();
    }

    public class AppDbContext : IDBContext
    {
        private readonly string? _connString;

        public AppDbContext(IConfiguration config)
        {
            _connString = config.GetConnectionString("DefaultConnection");
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connString);
        }
    }
}