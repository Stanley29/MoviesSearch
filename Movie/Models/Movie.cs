using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Year { get; set; }

        [MaxLength(1000)]
        public string Synopsis { get; set; }

        [MaxLength(50)]
        public string ReleaseDate { get; set; }

        public int Runtime { get; set; }

        [MaxLength(100)]
        public string Genre { get; set; }

        public int IMDbRating { get; set; }

        public int IMDbVotes { get; set; }

        [MaxLength(1000)]
        public string IMDbLink { get; set; }
    }
}
