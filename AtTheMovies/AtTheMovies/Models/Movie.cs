using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AtTheMovies.Models
{
    public class Movie
    {
        public Movie() { }
        public int ID { get; set; }
        public string Title { get; set; }
        public int Runtime { get; set; }
        public int ReleaseYear { get; set; }
    }
}