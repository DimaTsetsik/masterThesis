using System.Threading.Tasks;
using FFParser.Models;

namespace FFParser.Services.Abstractions
{
    public interface IImdbService
    {
        Task<ImdbEntity> GetFilmByName(string filmName);
    }
}