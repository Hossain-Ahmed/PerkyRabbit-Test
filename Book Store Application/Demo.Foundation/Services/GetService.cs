using Demo.Foundation.Entities;
using Demo.Foundation.UnitOfworks;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Foundation.Services
{
    public class GetService : IGetService
    {
        private readonly IBookStoreUnitOfWork _bookStoreUnitOfWork; 

        public GetService(IBookStoreUnitOfWork bookStoreUnitOfWork)
        {
            _bookStoreUnitOfWork = bookStoreUnitOfWork;
        }        
        public IList<Book> GetBookList()  
        {
            return _bookStoreUnitOfWork.BookRepository.GetAll();
        }

        //public void RemoveAllData(ElectionRegistration studentRegistration)
        //{
        //    _registrationUnitOfWork.RegistrationRepository.Remove(studentRegistration);
        //}        
    }
}
