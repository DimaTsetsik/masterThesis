using System.Threading.Tasks;
using FFilms.Services.Abstractions;
using FFParser.Models;
using FFParser.Services.Abstractions;

namespace FFilms.Services
{
    public class MoonwalkService : IMoonwalkService
    {
        private IMoonwalk iMoonwalk;

        public MoonwalkService(IMoonwalk iMoonwalk)
        {
            this.iMoonwalk = iMoonwalk;
        }

        public async Task<MoonwalkModel[]> GetFilmsByName(string name)
        {
            return await iMoonwalk.GetFilmByName(name);
        }
    }
}