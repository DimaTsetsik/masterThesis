using System.Threading.Tasks;
using System.Web.Mvc;
using FFilms.Repositories;
using FFilms.Services.Abstractions;
using FFParser.Services.Abstractions;

namespace FFilms.Controllers
{
    public class HomeController : Controller
    {
        private IMailService iMailService;
        private IGoogleBookService iGoogleBookService;

        public HomeController (IMailService ImailService, IGoogleBookService iGoogleBookService) {
            iMailService = ImailService;
            this.iGoogleBookService = iGoogleBookService;            
        }

        public async Task<ActionResult>  Index()
        {
            //var result = false;
            //try
            //{
            //    result = await iMailService.SendMessage("test@mail", "userName", "userMessage");
            //}
            //catch
            //{
            //    throw new NotImplementedException();
            //}

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}