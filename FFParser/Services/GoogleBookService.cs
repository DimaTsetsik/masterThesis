using System.Threading.Tasks;
using FFParser.Models;
using FFParser.Services.Abstractions;

namespace FFParser.Services
{
    public class GoogleBookService : IGoogleBookService
    {
        private readonly string ApiUrl = @"https://www.googleapis.com/books/v1/volumes/?q=";
        private IWebClientHelper iWebClientHelper = new WebClientHelper();

        public async Task<GoogleBookModel> GetBooksByNameAsync(string name)
        {
            string url = $"{ApiUrl}{name}";

            var result = await iWebClientHelper.GetWebReuestAsync<GoogleBookModel>(url);

            return result;
        }
    }
}
