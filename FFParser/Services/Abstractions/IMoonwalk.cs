using FFParser.Models;
using System.Threading.Tasks;

namespace FFParser.Services.Abstractions
{
    public interface IMoonwalk
    {
        Task<MoonwalkModel[]> GetFilmByName(string filmName);

        Task<MoonwalkModel[]> GetFilmById(string id);
    }
}