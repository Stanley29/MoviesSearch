using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Movie.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public MovieContext(DbContextOptions<MovieContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
