using Library.Presentation.ngApp.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Library.Presentation.Controllers
{
    public class BooksController : ApiController
    {
        private BookServices _bookServices;

        public BooksController(BookServices bookService)
        {
            _bookServices = bookService;
        }
        public IList<BookDTO> Get()
        {
            return _bookServices.ListBooks();
        }
    }
}
