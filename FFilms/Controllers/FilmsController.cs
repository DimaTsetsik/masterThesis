using System.Threading.Tasks;
using System.Web.Mvc;
using FFilms.Models;
using FFilms.Repositories.Abstractions;
using FFilms.Services.Abstractions;

namespace FFilms.Controllers
{
    public class FilmsController : Controller
    {
        private IMoonwalkService moonwalkService;
        private IGenresFilmsRepo iGenresFilmsRepo;


        public FilmsController(IMoonwalkService moonwalkService, IGenresFilmsRepo iGenresFilmsRepo)
        {
            this.moonwalkService = moonwalkService;
            this.iGenresFilmsRepo = iGenresFilmsRepo;
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
            model.GenresFilms = await iGenresFilmsRepo.GetGenresFilmsAsync();

            return View(model);
        }

        public async Task<ActionResult> GetFilmById(string filmId, string posterImg) {
            MoonwalkViewModel model = new MoonwalkViewModel
            {
                Poster = posterImg
            };

            model.MoonwalkModel = await moonwalkService.GetFilmsById(filmId);
            model.GenresFilms = await iGenresFilmsRepo.GetGenresFilmsAsync();

            return View(model);
        }

    }
}