using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Demo.Foundation.BusinessObjects;
using Autofac;

namespace Demo.Web.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetAllBooks()
        {
            var model = Startup.AutofacContainer.Resolve<RegistrationData>();
            model.LoadBooks();
            return View(model);
        }          
        public ActionResult AddNewBook(bool isSuccess=false,int bookId=0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }
        [HttpPost]
        public ActionResult AddNewBook(BookBO bookBO)  
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            int id=model.AddModelBook(bookBO);
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
            }
            return View(bookBO);
        }
        public IActionResult DeleteSingleBook(int id) 
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.DeleteBook(id);
            return RedirectToAction(nameof(GetAllBooks));
        }
        public IActionResult BookUpdate(int id) 
        {
            ViewBag.bookId = id;
            return View();
        }
        [HttpPost]
        public IActionResult BookUpdate(BookBO bookBO)
        {
            var model = Startup.AutofacContainer.Resolve<IndexModel>();
            model.BookUpdate(bookBO);
            return RedirectToAction(nameof(GetAllBooks));
        }
    }
}
