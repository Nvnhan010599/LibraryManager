using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager.Interfaces
{
    public interface IBookService
    {
        void AddBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(int bookId);
        List<Book> GetAllBooks();
        Book GetBookById(int bookId);
    }
}