using M6L4.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6L4.Core.Services
{
    public interface IBookService
    {
        Book GetBook(int id);
        List<Book> GetBooks();
        void DeleteBook(int Id);
        void AddBook(Book book);
        void UpdateBook(int id, string desc);
    }
}
