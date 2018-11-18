using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using FFilms.Repositories.Abstractions;
using FFilms.Repositories.Models;

namespace FFilms.Repositories
{
    public class GenresBooksRepo : BaseRepo, IGenresBooksRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public async Task<List<GenresBooks>> GetGenresBooksListAsync()
        {
           return await GetDataByQueryAsync<GenresBooks>("SELECT * FROM GenresBooksListTable WHERE IsActive = 1");
        }
    }
}