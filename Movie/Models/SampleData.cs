using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie.Models;

namespace Movie.Models
{
    public class SampleData
    {
        public static void Initialize(MovieContext context)
        {
            if (!context.Movies.Any())
            {
                context.Movies.AddRange(
                    new Movie
                    {
                        Name = "The Shawshank Redemption",
                        Year = "1994",
                        Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                        ReleaseDate = "17 February 1995",
                        Runtime = 144,
                        Genre = "Drama",
                        IMDbRating = 9,
                        IMDbVotes = 9,
                        IMDbLink = "https://www.imdb.com/title/tt0111161/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_1"
                    },
                    new Movie
                    {
                        Name = "The Godfather",
                        Year = "1972",
                        Synopsis = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                        ReleaseDate = "24 August 1972",
                        Runtime = 172,
                        Genre = "Crime, Drama'",
                        IMDbRating = 9,
                        IMDbVotes = 9,
                        IMDbLink = "https://www.imdb.com/title/tt0068646/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_2"
                    },
                    new Movie
                    {
                        Name = "The Godfather: Part",
                        Year = "1974",
                        Synopsis = "The early life and career of Vito Corleone in 1920s New York City is portrayed, while his son, Michael, expands and tightens his grip on the family crime syndicate.",
                        ReleaseDate = "15 May 1975",
                        Runtime = 202,
                        Genre = "Crime, Drama",
                        IMDbRating = 9,
                        IMDbVotes = 9,
                        IMDbLink = "https://www.imdb.com/title/tt0071562/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_3"
                    },
                    new Movie
                    {
                        Name = "The Dark Knight",
                        Year = "2008",
                        Synopsis = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
                        ReleaseDate = "24 July 2008",
                        Runtime = 212,
                        Genre = "Action, Crime, Drama",
                        IMDbRating = 9,
                        IMDbVotes = 9,
                        IMDbLink = "https://www.imdb.com/title/tt0468569/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_4"
                    },
                    new Movie
                    {
                        Name = "12 Angry Men",
                        Year = "1957",
                        Synopsis = "A jury holdout attempts to prevent a miscarriage of justice by forcing his colleagues to reconsider the evidence.",
                        ReleaseDate = "10 April 1957",
                        Runtime = 96,
                        Genre = "Drama",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0050083/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_5"
                    },
                    new Movie
                    {
                        Name = "Schindlers List",
                        Year = "1993",
                        Synopsis = "In German-occupied Poland during World War II, industrialist Oskar Schindler gradually becomes concerned for his Jewish workforce after witnessing their persecution by the Nazis.",
                        ReleaseDate = "18 February 1994",
                        Runtime = 195,
                        Genre = "Biography, Drama, History",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0108052/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_6"
                    },
                    new Movie
                    {
                        Name = "The Lord of the Rings: The Return of the King",
                        Year = "2003",
                        Synopsis = "Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.",
                        ReleaseDate = "17 December 2003",
                        Runtime = 201,
                        Genre = "Adventure, Drama, Fantasy",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0167260/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_7"
                    },
                    new Movie
                    {
                        Name = "Pulp Fiction",
                        Year = "1994",
                        Synopsis = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                        ReleaseDate = "21 October 1994",
                        Runtime = 154,
                        Genre = "Crime, Drama",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0110912/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_8"
                    },
                    new Movie
                    {
                        Name = "The Good, the Bad and the Ugly",
                        Year = "1966",
                        Synopsis = "A bounty hunting scam joins two men in an uneasy alliance against a third in a race to find a fortune in gold buried in a remote cemetery.",
                        ReleaseDate = "8 September 1968",
                        Runtime = 148,
                        Genre = "Western",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0060196/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_9"
                    },
                    new Movie
                    {
                        Name = "Fight Club",
                        Year = "1999",
                        Synopsis = "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.",
                        ReleaseDate = "12 November 1999",
                        Runtime = 139,
                        Genre = "Drama",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0137523/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_10"
                    },
                    new Movie
                    {
                        Name = "The Lord of the Rings: The Fellowship of the Ring",
                        Year = "2001",
                        Synopsis = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                        ReleaseDate = "19 December 2001",
                        Runtime = 178,
                        Genre = "Adventure, Drama, Fantasy",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0120737/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_11"
                    },
                    new Movie
                    {
                        Name = "Forrest Gump",
                        Year = "1994",
                        Synopsis = "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate, and other history unfold through the perspective of an Alabama man with an IQ of 75.",
                        ReleaseDate = "7 October 1994",
                        Runtime = 142,
                        Genre = "Drama, Romance",
                        IMDbRating = 8,
                        IMDbVotes = 8,
                        IMDbLink = "https://www.imdb.com/title/tt0109830/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=e31d89dd-322d-4646-8962-327b42fe94b1&pf_rd_r=8SXBSGPY2ZZZ7DMV8WX0&pf_rd_s=center-1&pf_rd_t=15506&pf_rd_i=top&ref_=chttp_tt_12"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
