using Demo.DataAccessLayer;
using Demo.Foundation.Contexts;
using Demo.Foundation.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.UnitOfworks
{
    public interface IBookStoreUnitOfWork : IUnitOfWork
    {       
        IBookRepository BookRepository { get; set; }
      
    }
}
