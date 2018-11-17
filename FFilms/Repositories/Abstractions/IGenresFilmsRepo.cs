using System.Collections.Generic;
using System.Threading.Tasks;
using FFilms.Repositories.Models;

namespace FFilms.Repositories.Abstractions
{
    public interface IGenresFilmsRepo
    {
        Task<List<GenresFilms>> GetGenresFilmsAsync();
    }
}