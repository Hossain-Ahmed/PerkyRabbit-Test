using Demo.Foundation.Contexts;
using Demo.Foundation.Entities;
using Demo.Foundation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Demo.Foundation.BusinessObjects;

namespace Demo.Web.Models
{
        public class IndexModel : BaseModel
        {
            private readonly IAddingService _addingService;
            private readonly IGetService _getService;

            public IndexModel(IAddingService addingService,
                IGetService getService)
            {
                _addingService = addingService;
                _getService = getService;
            }
            public int AddModelBook(BookBO bookBO)
            {
            var newBook = new Book
            {
                Title = (bookBO.Title != null) ? bookBO.Title : string.Empty,
                Author = (bookBO.Author != null) ? bookBO.Author : string.Empty,
                TotalPages = (bookBO.TotalPages != null) ? bookBO.TotalPages : 0,
                Description = (bookBO.Description != null) ? bookBO.Description : string.Empty,
            };

            _addingService.AddBook(newBook);
            return newBook.Id;
            }
        public void BookUpdate(BookBO bookBO)
        {
            _addingService.EditBook(new Book
            {
                Id = bookBO.Id,
                Title = (bookBO.Title != null) ? bookBO.Title : string.Empty,
                Author = (bookBO.Author != null) ? bookBO.Author : string.Empty,
                TotalPages = (bookBO.TotalPages != null) ? bookBO.TotalPages : 0,
                Description = (bookBO.Description != null) ? bookBO.Description : string.Empty,
            });
        }
        public void DeleteBook(int id)
        {
            _addingService.DeleteSingleBook(id); 
        }
      }
    }
