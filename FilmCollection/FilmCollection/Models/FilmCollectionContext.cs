using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmCollection.Models
{
    public class FilmCollectionContext : DbContext
    {
        public FilmCollectionContext(DbContextOptions<FilmCollectionContext> options) : base(options) 
        { 
        
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<NewMovie> Films { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { category_id = 1, category_name = "Action/Adventure"},
                new Category { category_id = 2, category_name = "Comedy" },
                new Category { category_id = 3, category_name = "Drama" },
                new Category { category_id = 4, category_name = "Family" },
                new Category { category_id = 5, category_name = "Horror/Suspense" },
                new Category { category_id = 6, category_name = "Miscellaneous" },
                new Category { category_id = 7, category_name = "Television" },
                new Category { category_id = 8, category_name = "VHS" }
            );


            mb.Entity<NewMovie>().HasData(
                
                new NewMovie
                {
                    film_id = 1,
                    category_id = 1,
                    title = "Casino Royale",
                    year = 2006,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                },
                new NewMovie
                {
                    film_id = 2,
                    category_id = 1,
                    title = "Skyfall",
                    year = 2013,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                },
                new NewMovie
                {
                    film_id = 3,
                    category_id = 1,
                    title = "No Time To Die",
                    year = 2021,
                    director = "John Doe",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "",
                    notes = ""
                }
            );
        }
    }
}
