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
    public class GenresBooksRepo : IGenresBooksRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public Task<List<GenresBooks>> GetGenresBooksListAsync()
        {
            return Task.Run(() => GetGenresBooksList());
        }

        public List<GenresBooks> GetGenresBooksList()
        {
            List<GenresBooks> booksGenres = new List<GenresBooks>();
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                booksGenres = db.Query<GenresBooks>("SELECT * FROM GenresBooksListTable WHERE IsActive = 1").ToList();
            }
            return booksGenres;
        }
    }
}