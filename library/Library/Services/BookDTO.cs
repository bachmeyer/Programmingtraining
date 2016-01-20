using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Presentation.ngApp.services
{
    public class BookDTO
    {    
        public string Title { get; set; }
        public int Id { get; set; }
        public string Isbn { get; set; }
        public AuthorDTO Author { get; set; }
    }
}
