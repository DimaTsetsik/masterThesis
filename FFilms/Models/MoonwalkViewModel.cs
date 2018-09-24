using FFParser.Models;

namespace FFilms.Models
{
    public class MoonwalkViewModel
    {
        public MoonwalkModel[] MoonwalkModel { get; set; }

        public string FilmName { get; set; }

        public int CurrentPage { get; set; }

        //public Pager Pager { get; set; }
    }
}