using Microsoft.AspNetCore.Mvc;

namespace webgentle.bookstore.Controllers
{
    public class BookController : Controller
    {
        public string BookName()
        {
            return "Wel come to Coreapp";
        }
        public string BookNumber(int i)
        {
            return $"your book number is {i}";
        }
        public string AuthorBook(string Authorname,string Bookname)
        {
            return $"Author name is {Authorname} and his book name is {Bookname}";
        }
    }
}
