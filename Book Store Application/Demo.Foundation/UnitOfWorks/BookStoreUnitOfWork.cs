using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public class BookStoreUnitOfWork : UnitOfWork, IBookStoreUnitOfWork
    {
        
        public IBookRepository BookRepository { get; set; } 


        public BookStoreUnitOfWork(BookStoreContext context, 
          
            IBookRepository bookRepository     
            )
            : base(context)
        {
           
            BookRepository = bookRepository;
        }
    }
}