using System.Collections.Generic;
using System.Linq;
using webgentle.bookstore.Models;

namespace webgentle.bookstore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return dataSource();
        }
        public BookModel GetBookById(int id)
        {
            return dataSource().Where(x => x.id == id).FirstOrDefault();
        }
        public List<BookModel> GetAllBooks(string title, string author)
        {
            return dataSource().Where(x=>x.Title==title && x.Author==author).ToList();
        }

        private List<BookModel> dataSource()
        {
            return new List<BookModel>() { 
             new BookModel{id=1,Author="AAUTHOR",Title="ATITLE"},
             new BookModel{id=2,Author="BAUTHOR",Title="BTITLE"},
             new BookModel{id=3,Author="CAUTHOR",Title="CTITLE"},
             new BookModel{id=4,Author="DAUTHOR",Title="DTITLE"},
             new BookModel{id=5,Author="EAUTHOR",Title="ETITLE"},
            
            };

        }

    }
}
