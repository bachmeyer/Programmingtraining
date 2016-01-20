using CoderCamps.Infrastructure.Repository;
using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library.Presentation.ngApp.services
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(DbContext db) : base(db) { }
    }
}