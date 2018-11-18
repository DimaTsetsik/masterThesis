using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace FFilms.Repositories
{
    public class BaseRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Task<List<T>> GetDataByQueryAsync<T>(string query)
        {
            return Task.Run(() => GetDataByQuery<T>(query));
        }

        public List<T> GetDataByQuery<T>(string query)
        {
            List<T> booksGenres = new List<T>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                booksGenres = db.Query<T>(query).ToList();
            }
            return booksGenres;
        }
    }
}