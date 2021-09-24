using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IGetService
    {
        IList<Book> GetBookList();
        //Book GetBook(int id);        
    }
}
