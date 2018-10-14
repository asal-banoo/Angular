using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtTheMovies.Models
{
    public class MovieDb:DbContext
    {
        public MovieDb() { }
        public DbSet<Movie> movies { get; set; }
    }
}