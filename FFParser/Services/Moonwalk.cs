using System;
using System.Threading.Tasks;
using FFParser.Enumerations;
using FFParser.Models;

namespace FFParser.Services.Abstractions
{
    public class Moonwalk : IMoonwalk
    {
        private IWebClientHelper iWebClientHelper = new WebClientHelper();
        private readonly IEnumeration Enumerator = new Enumeration();

        public async Task<MoonwalkModel[]> GetFilmByName(string filmName)
        {
            try
            {
                string url = $"{Enumerator.GetMoonwalkUrl}title={filmName}&api_token={Enumerator.GetMoonwalkToken[0]}";
                var result = await iWebClientHelper.GetWebReuestAsync<MoonwalkModel[]>(url);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Internal fucked error: {e.Data}");
            }
        }
    }
}
