using System;
using Should;
using Xunit;

namespace WriteGoodTests.Test.Antipatterns.FreeRide
{
    public class When_Borrowing_Book
    {
        [Fact]
        public void Should_Have_New_Loan()
        {
            var loan = BorrowBook(666);

            loan.Book.Title.ShouldEqual("Harry Potter and Goblet of Fire", "Did not get the expected book title checked out.");
            loan.DueDate.ShouldEqual(DateTime.Parse("2017-03-01"), "Did not get the expected due date on the loan.");
        }

        private Loan BorrowBook(int bookId)
        {
            return new Loan {Book = new Book {Title = "Harry Potter and Goblet of Fire"}, DueDate = DateTime.Parse("2017-03-01")};
        }
    }

    public class Loan
    {
        public Book Book { get; set; }
        public DateTime DueDate { get; set; }
    }

    public class Book
    {
        public string Title { get; set; }
    }
}
