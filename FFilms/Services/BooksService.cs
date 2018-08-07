using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using FFilms.Services.Abstractions;
using FFParser.Models;
using FFParser.Services.Abstractions;

namespace FFilms.Services
{
    public class BooksService : IBooksService
    {
        private IGoogleBookService iGoogleBookService;

        public BooksService(IGoogleBookService iGoogleBookService)
        {
            this.iGoogleBookService = iGoogleBookService;
        }

        public async Task<GoogleBookModel> GetBooksByName(string name, int startIndex, int itemsOnPage)
        {
            return await iGoogleBookService.GetBooksByNameAsync(name, startIndex * itemsOnPage, itemsOnPage);
        }
    }
}