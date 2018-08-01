using FFilms.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FFilms.Controllers
{
    public class HomeController : Controller
    {
        private IMailService iMailService;

        public HomeController (IMailService ImailService) {
            iMailService = ImailService;
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