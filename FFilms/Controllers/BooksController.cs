using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using FFilms.Models;
using FFilms.Services;
using FFilms.Services.Abstractions;
using FFParser.Models;

namespace FFilms.Controllers
{
    public class BooksController : Controller
    {
        private IBooksService iBookService;

        public BooksController(IBooksService iBookService)
        {
            this.iBookService = iBookService;
        }

        // GET: Books
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetBooksByName(string bookName = "Angular", int page = 1)
        {
            BooksViewModel model = new BooksViewModel
            {
                BookName = bookName.Trim(),
                CurrentPage = page,
            };

            model.BooksModels = await iBookService.GetBooksByName(bookName, page, 20);
            var pager = new Pager(model.BooksModels.totalItems, page, 20);
            model.Pager = pager;
           
            return View(model);
        }
    }
}