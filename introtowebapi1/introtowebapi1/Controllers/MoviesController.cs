using introtowebapi1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace introtowebapi1.Controllers
{
    public class MoviesController : ApiController
    {

        public static IList<Movie> _movies = new List<Movie>() {
        new Movie() {
        Id = 0,
        Title = "Star Treck"
        }
        };
        //GET: /api/movies/5
        public Movie Get(int id)
        {
            return _movies.First(x => x.Id == id);
        }
        public IHttpActionResult Post(MovieBattle battle)
        {
            _movies.Add(battle.Movie1);
            _movies.Add(battle.Movie2);
            return Ok();
        }

        public IHttpActionResult Post(int id, Movie changes)
        {                               // V this is a c sharp delegate or predicate
            var dbMovie = _movies.First(x => x.Id == id);
            dbMovie.Id = changes.Id;
            dbMovie.Title = changes.Title;
            dbMovie.Genra = changes.Genra;
            dbMovie.ReleaseDate = changes.ReleaseDate;

            return Ok();
        }
    }
}
