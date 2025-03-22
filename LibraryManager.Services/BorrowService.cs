using System;
using System.Collections.Generic;
using LibraryManager.Interfaces;
using LibraryManager.Models;

namespace LibraryManager.Services
{
    public class BorrowService : IBorrowService
    {
        public void BorrowBook(int bookId, int memberId)
        {

        }
        public void ReturnBook(int bookId, int memberId)
        {

        }
        public List<BorrowRecord> GetBorrowHistory(int memberId)
        {
            return null;
        }
        public List<BorrowRecord> GetOverdueBooks(DateTime currentDate)
        {

            return null;
        }
    }
}