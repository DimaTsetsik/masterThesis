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
        private readonly ImdbService imdbService = new ImdbService();

        public async Task<MoonwalkModel[]> GetFilmByName(string filmName)
        {
            try
            {
                string url = $"{Enumerator.GetMoonwalkUrl}title={filmName}&api_token={Enumerator.GetMoonwalkToken[0]}";
                var result = await iWebClientHelper.GetWebReuestAsync<MoonwalkModel[]>(url);
                foreach (var item in result) {
                    if (item.title_en != null) {
                        var imdbResult = await imdbService.GetFilmByName(item.title_en);
                        if (imdbResult.Poster != null) {
                            item.posret = imdbResult.Poster;
                        }
                    }
                }
                return result;
            }
            catch (Exception e)
            {
                throw new Exception($"Internal fucked error: {e.Data}");
            }
        }

        public async Task<MoonwalkModel[]> GetFilmById(string id)
        {
            try
            {
                string url = $"{Enumerator.GetMoonwalkUrl}kinopoisk_id={id}&api_token={Enumerator.GetMoonwalkToken[0]}";
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
