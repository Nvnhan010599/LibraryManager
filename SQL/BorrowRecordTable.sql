CREATE TABLE BorrowRecord (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    BookId INT,
    MemberId INT,
    BorrowDate DATETIME,
    ReturnDate DATETIME,
    ActualReturnDate DATETIME,
    FOREIGN KEY (BookId) REFERENCES Book(Id),
    FOREIGN KEY (MemberId) REFERENCES Member(Id)
);