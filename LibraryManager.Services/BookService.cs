using System.Collections.Generic;
using LibraryManager.Interfaces;
using LibraryManager.Models;

namespace LibraryManager.Services
{
    public class BookService : IBookService
    {
        // TODO: Triển khai các phương thức
        public void AddBook(Book book)
        {
            // Thêm sách vào cơ sở dữ liệu
        }

        public void UpdateBook(Book book)
        {
            // Cập nhật thông tin sách trong cơ sở dữ liệu
        }

        public void DeleteBook(int bookId)
        {
            // Xóa sách khỏi cơ sở dữ liệu
        }

        public List<Book> GetAllBooks()
        {
            // Lấy danh sách tất cả các sách từ cơ sở dữ liệu
            return new List<Book>();
        }

        public Book GetBookById(int bookId)
        {
            // Lấy thông tin sách theo ID từ cơ sở dữ liệu
            return new Book();
        }
    }
}