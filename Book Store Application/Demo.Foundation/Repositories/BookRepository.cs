using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Repositories
{
    public class BookRepository : Repository<Book, int, BookStoreContext>, IBookRepository
    {
        public BookRepository(BookStoreContext dbContext)
            : base(dbContext)
        {

        }

        public IList<Book> GetLatestBooks()
        {
            throw new NotImplementedException();
        }
    }
}
