using System.Threading.Tasks;
using FFParser.Models;

namespace FFilms.Services.Abstractions
{
    public interface IBooksService
    {
        Task<GoogleBookModel> GetBooksByName(string name, int startIndex, int itemsOnPage);
    }
}