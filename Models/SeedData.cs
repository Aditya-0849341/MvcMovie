using Humanizer.Localisation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using MvcMovie.Migrations;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Once upon a time in hollywood",
                    ReleaseDate = DateTime.Parse("2021-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Revenent",
                    ReleaseDate = DateTime.Parse("2019-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 2.99M
                },
                new Movie
                {
                    Title = "La la Land",
                    ReleaseDate = DateTime.Parse("2015-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Fast & Furious",
                    ReleaseDate = DateTime.Parse("2012-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 4.99M
                },
                new Movie
                {
                    Title = "Superman",
                    ReleaseDate = DateTime.Parse("2004-4-15"),
                    Genre = "Western",
                    Rating = "R",
                    Price = 6.99M
                }
            );
            context.SaveChanges();
        }
    }
}