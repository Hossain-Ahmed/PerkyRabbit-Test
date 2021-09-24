using Autofac;
using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Web.Models
{
    public class RegistrationData:BaseModel
    {
        public IList<Book> Books { get; set; }
        public Book Book { get; set; }
        private const string IMAGE_PATH = "temp";

        private readonly IGetService _getService;
        private readonly BookStoreContext _bookStoreContext;
        public RegistrationData(IGetService getService,
            BookStoreContext bookStoreContext) 
        {
            _getService = getService;
            _bookStoreContext = bookStoreContext;
        }
        public RegistrationData()
        {
            _getService = Startup.AutofacContainer.Resolve<IGetService>();
            _bookStoreContext = Startup.AutofacContainer.Resolve<BookStoreContext>(); 
        }

        public void LoadBooks() 
        {
            Books = ConvertToBookList(_getService.GetBookList());
        }
        private IList<Book> ConvertToBookList(IList<Book> books) 
        {
            IList<Book> bookList = new List<Book>(); 

            foreach (var Bookitem in books)
            {
                if (Bookitem.Title!="" && Bookitem.Author!="")
                {
                    bookList.Add(new Book()
                    {
                        Id = Bookitem.Id,
                        Author = Bookitem.Author,
                        Title = Bookitem.Title,
                        Description = Bookitem.Description,
                        TotalPages = Bookitem.TotalPages
                    });
                }
                
            }
            return bookList;
        }
    }
}