using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using tableApi.Models;

namespace tableApi.Controllers
{
    public class MoviesController : ApiController
    {
        
        Movie[] mvs = new Movie[] { new Movie { movieId = 500, price = 1.00, studio = "testStudio", title = "testTitle", year = 1994} };

        //DB connection
        MovieDb dbConnection = new MovieDb { dbname = "bradentc_movie_managment", password = "something", servername = "localhost", username = "bradentc_movie" };
        
        //TEST

        //PUT

        //POST
        
        //GET
        public IHttpActionResult GetMovie(int id)
        {
            var movie = mvs.FirstOrDefault((p) => p.movieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            return Ok(movie);
        }

        //DELETE

        //OPTIONS

        public IEnumerable<Movie> ProcessMovies()
        {
            return mvs;
        }

   
    }

    
}
