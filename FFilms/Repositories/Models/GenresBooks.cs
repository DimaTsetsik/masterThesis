using System;

namespace FFilms.Repositories.Models
{
    public class GenresBooks
    {
        public int ID { get; set; }
        public string GenreName { get; set; }
        public Nullable<bool> IsActive { get; set; }
    }
}