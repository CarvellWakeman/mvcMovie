using System;

using System.Data.Entity;

namespace mvcMovie.Models
{
    public class Movie
    {
        // Members
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }


        // Accessors and Mutators


    }

    public class MovieDBContext : DbContext
    {
        // Members
        public DbSet<Movie> Movies { get; set; }



    }
}