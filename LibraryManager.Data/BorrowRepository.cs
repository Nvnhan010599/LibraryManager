using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LibraryManager.Models;

namespace LibraryManager.Data
{
    public class BorrowRepository
    {
        private readonly LibraryDbContext _context;

        public BorrowRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public void BorrowBook(int bookId, int memberId)
        {
            var borrowRecord = new BorrowRecord
            {
                BookId = bookId,
                MemberId = memberId,
                BorrowDate = DateTime.Now,
                ReturnDate = DateTime.Now.AddDays(7) // Ví dụ: Mượn trong 7 ngày
            };

            _context.BorrowRecords.Add(borrowRecord);
            _context.SaveChanges();
        }

        public void ReturnBook(int bookId, int memberId)
        {
            var borrowRecord = _context.BorrowRecords.FirstOrDefault(br => br.BookId == bookId && br.MemberId == memberId && br.ActualReturnDate == null);
            if (borrowRecord != null)
            {
                borrowRecord.ActualReturnDate = DateTime.Now;
                _context.BorrowRecords.Update(borrowRecord);
                _context.SaveChanges();
            }
        }

        public List<BorrowRecord> GetBorrowHistory(int memberId)
        {
            return _context.BorrowRecords.Where(br => br.MemberId == memberId).ToList();
        }

        public List<BorrowRecord> GetOverdueBooks(DateTime currentDate)
        {
            return _context.BorrowRecords.Where(br => br.ReturnDate < currentDate && br.ActualReturnDate == null).ToList();
        }
    }
}