using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Games.Data;
using System;
using System.Linq;

namespace Games.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GamesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GamesContext>>()))
            {
                // Look for any movies.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }

                context.Game.AddRange(
                    new Game
                    {
                        Title = "Battlefield 4",
                        ReleaseDate = DateTime.Parse("2013-10-29"),
                        Genre = "FPS",
                        PegiRating = 18,
                        Price = 19.21M
                    },

                    new Game
                    {
                        Title = "World Of Warcraft ",
                        ReleaseDate = DateTime.Parse("2004-11-23"),
                        Genre = "MMORPG",
                        PegiRating = 12,
                        Price = 39.99M
                    },

                    new Game
                    {
                        Title = "Genshin Impact",
                        ReleaseDate = DateTime.Parse("2020-09-28"),
                        Genre = "RPG",
                        PegiRating = 12,
                        Price = 00.00M
                    },

                    new Game
                    {
                        Title = "Counter Strike 1.6",
                        ReleaseDate = DateTime.Parse("2000-11-14"),
                        Genre = "FPS",
                        PegiRating = 18,
                        Price = 9.99M
                    },

                    new Game
                    {
                        Title = "Stardew Valley",
                        ReleaseDate = DateTime.Parse("2016-02-26"),
                        Genre = "RPG",
                        PegiRating = 12,
                        Price = 14.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
