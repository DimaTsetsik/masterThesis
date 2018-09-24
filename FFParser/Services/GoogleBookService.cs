using System.Threading.Tasks;
using FFParser.Enumerations;
using FFParser.Models;
using FFParser.Services.Abstractions;

namespace FFParser.Services
{
    public class GoogleBookService : IGoogleBookService
    {
        private IWebClientHelper iWebClientHelper = new WebClientHelper();
        private readonly IEnumeration Enumerator = new Enumeration();

        public async Task<GoogleBookModel> GetBooksByNameAsync(string name, int startIndex = 0, int itemsOnPage = 12)
        {
            string url = $"{Enumerator.GetGoogleBooksApiUrl}{name}{"&startIndex="}{startIndex}{"&maxResults="}{itemsOnPage}";

            var result = await iWebClientHelper.GetWebReuestAsync<GoogleBookModel>(url);

            return result;
        }
    }
}