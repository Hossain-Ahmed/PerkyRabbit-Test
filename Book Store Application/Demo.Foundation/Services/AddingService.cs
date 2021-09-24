using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class AddingService : IAddingService
    {        
        private readonly IBookStoreUnitOfWork _bookStoreUnitOfWork; 
        public AddingService(IBookStoreUnitOfWork bookStoreUnitOfWork) 
        {
            _bookStoreUnitOfWork = bookStoreUnitOfWork;
        }

        public void AddBook(Book book)  
        {
            _bookStoreUnitOfWork.BookRepository.Add(book);
            _bookStoreUnitOfWork.Save();
        }
        public void EditBook(Book book)
        {
            var obj = _bookStoreUnitOfWork.BookRepository.GetById(book.Id);
            obj.Title = book.Title;
            obj.Author = book.Author;
            obj.Description = book.Description;
            obj.TotalPages = book.TotalPages;
            _bookStoreUnitOfWork.BookRepository.Edit(obj);
            _bookStoreUnitOfWork.Save();
        }
        public void DeleteSingleBook(int id) 
        {
            _bookStoreUnitOfWork.BookRepository.Remove(id);
            _bookStoreUnitOfWork.Save(); 
        }
    }
}