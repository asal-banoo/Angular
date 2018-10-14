namespace AtTheMovies.Migrations
{
    using AtTheMovies.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtTheMovies.Models.MovieDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtTheMovies.Models.MovieDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            context.movies.AddOrUpdate(
                m => m.Title, new Movie
                {
                    Title = "dddd",
                    Runtime = 120,
                    ReleaseYear = 2010
                }, new Movie
                {
                    Title = "dfr",
                    Runtime = 120,
                    ReleaseYear = 2010
                }
                );
        }
    }
}
