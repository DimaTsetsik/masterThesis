using System.Threading.Tasks;

namespace FFParser.Services.Abstractions
{
    public interface IWebClientHelper
    {
        Task<T> GetWebReuestAsync<T>(string url);
    }
}