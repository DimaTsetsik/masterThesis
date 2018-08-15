using FFilms.Services;
using FFParser.Models;

namespace FFilms.Models
{
    public class BooksViewModel
    {
        public string BookName { get; set; }

        public int CurrentPage { get; set; }

        public GoogleBookModel BooksModels { get; set; }

        public Pager Pager { get; set; }
    }
}