using System.Threading.Tasks;
using FFParser.Models;

namespace FFilms.Services.Abstractions
{
    public interface IMoonwalkService
    {
        Task<MoonwalkModel[]> GetFilmsByName(string name);
    }
}
