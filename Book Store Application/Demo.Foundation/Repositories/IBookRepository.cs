
using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public interface IBookRepository : IRepository<Book, int, BookStoreContext>
    {
        IList<Book> GetLatestBooks();
    }
}
