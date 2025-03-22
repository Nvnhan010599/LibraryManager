using System;

namespace LibraryManager.Models
{
    public class BookHistory
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Action { get; set; }
        public DateTime ActionDate { get; set; }
    }
}