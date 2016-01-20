using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library.Presentation.ngApp.services
{
    public class BookServices
    {
        private BookRepository _bookRepo;
        public BookServices(BookRepository bookrepo)
        {
            _bookRepo = bookrepo;
        }

        private BookDTO Map(Book dbBook)
        {
            return new BookDTO()
            {
                Id = dbBook.Id,
                Title = dbBook.Title,
                Author = dbBook.Author != null ? new AuthorDTO()
                {
                    Id = dbBook.Author.Id,
                    Name = dbBook.Author.Name
                } : null,
                Isbn = dbBook.Isbn
            };
        }
        public IList<BookDTO> ListBooks()
        {
            return (from b in _bookRepo.List()
                    select Map(b)).ToList();
        }

    }
}