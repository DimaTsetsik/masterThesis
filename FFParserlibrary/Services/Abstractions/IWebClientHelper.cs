using System.Threading.Tasks;

namespace FFParserlibrary.Services.Abstractions
{
    interface IWebClientHelper
    {
        Task<T> GetWebReuest<T>(string url);
    }
}
