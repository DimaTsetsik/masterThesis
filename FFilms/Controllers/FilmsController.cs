using System.Threading.Tasks;
using System.Web.Mvc;
using FFilms.Models;
using FFilms.Services.Abstractions;

namespace FFilms.Controllers
{
    public class FilmsController : Controller
    {
        private IMoonwalkService moonwalkService;

        public FilmsController(IMoonwalkService moonwalkService)
        {
            this.moonwalkService = moonwalkService;
        }

        public async Task<ActionResult> Index()
        {
            return View();
        }

        public async Task<ActionResult> Films(string filmName = "Во все", int page = 1)
        {
            MoonwalkViewModel model = new MoonwalkViewModel
            {
                FilmName = filmName.Trim() 
            };

            model.MoonwalkModel = await moonwalkService.GetFilmsByName(filmName);

            return View(model);
        }

        public async Task<ActionResult> GetFilmById(string filmId, string posterImg) {
            MoonwalkViewModel model = new MoonwalkViewModel
            {
                Poster = posterImg
            };

            model.MoonwalkModel = await moonwalkService.GetFilmsById(filmId);

            return View(model);
        }

    }
}