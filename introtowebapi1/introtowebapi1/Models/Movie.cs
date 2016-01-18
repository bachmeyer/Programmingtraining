using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace introtowebapi1.Models
{
    public class Movie
    {
        //every model should have an Id in order to link to databases
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genra { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Actor> Actors { get; set; }




    }
}