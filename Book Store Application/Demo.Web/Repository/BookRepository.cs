//using Demo.Web.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Demo.Web.Repository
//{
   
//    public class BookRepository
//    {
//        public List<BookModel> GetAllBooks()
//        {
//            return DataSource();
//        }
//        public BookModel GetBookById(int id)
//        {
//            return DataSource().Where(x => x.Id == id).FirstOrDefault();
//        }

//        public List<BookModel> SerachBook(string titleName,string authorName)
//        {
//            return DataSource().Where(x => x.Title.Contains(titleName) 
//            || x.Author.Contains(authorName)).ToList();
//        }

//        private List<BookModel> DataSource()
//        {
//            return new List<BookModel>
//            {
//                new BookModel {Id=1,Title=".NetCore",Author="Hazaed Forw",Description="Encyclopedia of DotNetCore",Category="Programming",Language="English" },
//                new BookModel {Id=2,Title="MVC",Author="Luis",Description="All About MVC",Category="Programming",Language="Hindi"},
//                new BookModel {Id=3,Title="Chokher Bali",Author="Rabindranath Tagore",Description="Chokher Bali is a 1903 Bengali novel by Rabindranath Tagore that depicts the life of the central character, Binodini, and her relationships with three individuals.",Category="Novel",Language="Bangla" },
//                new BookModel {Id=4,Title="C#",Author="A.Hifs",Description="Everything of C#",Category="Coding",Language="English" },
//                new BookModel {Id=5,Title="Php",Author="Kong",Description="Summary of Php" ,Category="Programming",Language="Latin"},
//                new BookModel {Id=6,Title="Java",Author="Kong.Kif",Description="Monster Java" ,Category="Programming",Language="Chinease"},
//            };
//        }
//    }
//}
