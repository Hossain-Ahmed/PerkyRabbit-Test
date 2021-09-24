using Demo.Foundation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public interface IAddingService
    {
        void AddBook(Book book);
        void DeleteSingleBook(int id);
        void EditBook(Book book); 
    }
}
