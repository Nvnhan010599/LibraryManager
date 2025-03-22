using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager.Interfaces
{
    public interface IBookHistoryService
    {
        void AddBookHistory(BookHistory bookHistory);
        List<BookHistory> GetBookHistory(int bookId);
    }
}