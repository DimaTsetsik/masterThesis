using System.Threading.Tasks;

namespace FFilms.Services.Abstractions
{
    public interface IMailService
    {
        Task<bool> SendMessage(string userEmail, string userName, string message, string subject, string path);
    }
}
