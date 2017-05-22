using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace mvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        // Members
        public DbSet<Movie> Movies { get; set; }
    }
}