using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using LibraryManager.Models;

namespace LibraryManager.Data
{
    public class BookHistoryRepository
    {
        private readonly LibraryDbContext _context;

        public BookHistoryRepository(LibraryDbContext context)
        {
            _context = context;
        }

        public void AddBookHistory(BookHistory bookHistory)
        {
            _context.BookHistories.Add(bookHistory);
            _context.SaveChanges();
        }

        public List<BookHistory> GetBookHistory(int bookId)
        {
            return _context.BookHistories.Where(bh => bh.BookId == bookId).ToList();
        }
    }
}