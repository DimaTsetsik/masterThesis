using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using FFilms.Repositories.Abstractions;
using FFilms.Repositories.Models;

namespace FFilms.Repositories
{
    public class GenresFilmsRepo : BaseRepo, IGenresFilmsRepo
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public async Task<List<GenresFilms>> GetGenresFilmsAsync()
        {
            return await GetDataByQueryAsync<GenresFilms>("SELECT * FROM GenresFilmsListTable WHERE IsActive = 1");
        }
    }
}