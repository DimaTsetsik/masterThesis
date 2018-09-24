using System;
using System.Threading.Tasks;
using FFParser.Enumerations;
using FFParser.Models;
using FFParser.Services.Abstractions;

namespace FFParser.Services
{
    public class ImdbService
    {
        private IWebClientHelper iWebClientHelper = new WebClientHelper();
        private readonly IEnumeration Enumerator = new Enumeration();

        public async Task<ImdbEntity> GetFilmByName(string filmName)
        {
            try
            {
                string url = $"{Enumerator.GetImDbApiUrl}{filmName}&{Enumerator.GetImDbapiToken}";
                var result = await iWebClientHelper.GetWebReuestAsync<ImdbEntity>(url);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Internal fucked error: {e.Data}");
            }
        }
    }
}
