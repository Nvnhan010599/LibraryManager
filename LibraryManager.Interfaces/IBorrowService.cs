using System;
using System.Collections.Generic;
using LibraryManager.Models;

namespace LibraryManager.Interfaces
{
    public interface IBorrowService
    {
        void BorrowBook(int bookId, int memberId);
        void ReturnBook(int bookId, int memberId);
        List<BorrowRecord> GetBorrowHistory(int memberId);
        List<BorrowRecord> GetOverdueBooks(DateTime currentDate);
    }
}