using FFilms.Repositories.Models;
using FFParser.Models;
using System.Collections.Generic;

namespace FFilms.Models
{
    public class MoonwalkViewModel
    {
        public MoonwalkModel[] MoonwalkModel { get; set; }

        public string FilmName { get; set; }

        public int CurrentPage { get; set; }

        public string Poster { get; set; }

        public List<GenresFilms> GenresFilms { get; set; }

        //public Pager Pager { get; set; }
    }
}