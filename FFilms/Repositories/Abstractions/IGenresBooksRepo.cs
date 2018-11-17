using System.Collections.Generic;
using System.Threading.Tasks;
using FFilms.Repositories.Models;

namespace FFilms.Repositories.Abstractions
{
    public interface IGenresBooksRepo
    {
        Task<List<GenresBooks>> GetGenresBooksListAsync();
    }
}