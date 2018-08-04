using FFParser.Models;
using System.Threading.Tasks;

namespace FFParser.Services.Abstractions
{
    public interface IGoogleBookService
    {
        Task<GoogleBookModel> GetBooksByNameAsync(string name);
    }
}