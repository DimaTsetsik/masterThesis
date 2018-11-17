using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using FFilms.Repositories.Abstractions;
using FFilms.Repositories.Models;

namespace FFilms.Repositories
{
    public class GenresFilmsRepo : IGenresFilmsRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Task<List<GenresFilms>> GetGenresFilmsAsync()
        {
            return Task.Run(() => GetGenresFilms());
        }

        public List<GenresFilms> GetGenresFilms()
        {
            List<GenresFilms> booksGenres = new List<GenresFilms>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                booksGenres = db.Query<GenresFilms>("SELECT * FROM GenresFilmsListTable WHERE IsActive = 1").ToList();
            }
            return booksGenres;
        }
    }
}