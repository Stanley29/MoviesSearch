using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using System.Net;
using System.Web;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using System.Web.Mvc;


namespace Movie.Controllers
{
    public class HomeController : Controller
    {
         MovieContext db;

        public HomeController(MovieContext context)
        {
            db = context;
        }

        //public IActionResult Index()
        //{
        //    return View(db.Movies.ToList());
        //}

        public async Task<IActionResult> Index(string searching)
        {
            if (db.Movies.Where(x => x.Name.Contains(searching) || searching == null).ToList().Count() != 0)
            {
                return View(db.Movies.Where(x => x.Name.Contains(searching) || searching == null).ToList());
            }
            else
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://www.omdbapi.com");
                        var response = await client.GetAsync($"/?apikey=4bb2542e&t={searching}");
                        response.EnsureSuccessStatusCode();

                        var stringResult = await response.Content.ReadAsStringAsync();

                        var myJObject = JObject.Parse(stringResult);
                        var rawMovie = JsonConvert.DeserializeObject<Movie.Models.RawMoviecs>(stringResult);
                       
                        List<Movie.Models.Movie> viewModel = new List<Models.Movie>();
                        Movie.Models.Movie tempMovie = new Models.Movie();
                        if (rawMovie.Title != null)
                        {
                            tempMovie.Name = rawMovie.Title;
                            tempMovie.Year = rawMovie.Year;
                            tempMovie.Synopsis = rawMovie.Plot;
                            tempMovie.ReleaseDate = rawMovie.Released;
                            try
                            {
                                tempMovie.Runtime = Convert.ToInt32(rawMovie.Runtime.Substring(0, 3));
                                tempMovie.IMDbRating = (int)Convert.ToInt32(rawMovie.imdbRating.Substring(0, 1));
                                tempMovie.IMDbVotes = (int)Convert.ToInt32(rawMovie.imdbVotes.Substring(0, 3));
                            }
                            catch (Exception)
                            {
                                tempMovie.Runtime = 122;
                                tempMovie.IMDbRating = 7;
                                tempMovie.IMDbVotes = 6754;
                            }
                            //tempMovie.Runtime = Convert.ToInt32(rawMovie.Runtime.Substring(0, 3));//
                            
                            tempMovie.Genre = rawMovie.Genre;  
                            tempMovie.IMDbLink = rawMovie.Poster;


                            // ViewBag.JSon = myJObject.ToString();
                            ViewBag.JSon = tempMovie.Name;
                            //return View();



                            viewModel.Add(tempMovie);
                            return View(viewModel);
                        }
                        else
                        {
                            return View(viewModel);
                        }
                        
                    }
                    catch (HttpRequestException httpRequestException)
                    {
                        return BadRequest($"Error getting movie from OMDb: {httpRequestException.Message}");
                    }
                }
            } 

            
            //return View(db.Movies.Where(x => x.Name.StartWith(searching) || searching == null).ToList());
        }

        // GET: Tickets/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                // return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                ViewBag.BadRequest = "HttpStatusCode BadRequest";


            }
            Movie.Models.Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                //return HttpNotFound();
                ViewBag.HttpNotFound = "Http Not Found";
            }
            return View(movie);
            //return View();
        }


        
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
