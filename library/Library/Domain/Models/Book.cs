using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Domain.Models
{
    public class Book
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Isbn { get; set; }
        public Author Author { get; set; }
    }
}