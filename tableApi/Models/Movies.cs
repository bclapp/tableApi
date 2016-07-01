using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tableApi.Models
{
    public class Movie
    {
        public int movieId { get; set; }
        public string title { get; set; }
        public double price { get; set; }
        public string studio { get; set; }
        public int year { get; set; }

    }

    public class MovieDb
    {
        public string servername { get; set; }
        public string username  { get; set; }
        public string password { get; set; }
        public string dbname { get; set; }
    }

}