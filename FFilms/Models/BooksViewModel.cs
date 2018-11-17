using FFilms.Services;
using FFParser.Models;
using System.Collections.Generic;
using FFilms.Repositories.Models;

namespace FFilms.Models
{
    public class BooksViewModel
    {
        public string BookName { get; set; }

        public int CurrentPage { get; set; }

        public GoogleBookModel BooksModels { get; set; }

        public Pager Pager { get; set; }

        public List<GenresBooks> GenresBooks { get; set; }
    }
}