using LibraryApp.DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.BusinessLayer
{
    public class Librarian
    {
        List<Book> BookList { get; set; }
        Member Member { get; set; }
        private BookRepo _bookRepo; 

        //public Librarian (List<Book> listOfBooks, Member member)
        //{
        //    this.BookList = listOfBooks;
        //    this.Member = member;
        //}
        public Librarian()
        {
            _bookRepo = new BookRepo();
        }

        public List<Book> getBookList()
        {
            return _bookRepo.GetBooks();
        }

        public void CheckOutBook(Book book)
        {
            /// select a book from the list
            /// if its checked out let them know
            if (book.status == true)
            {
                Console.WriteLine("This book is already checked out, please select another.");
            }
            else
            {
                /// if its not checked out - check it out to them and set due date for 2 weeks from today
                book.status = true;
                var dueDate = DateTime.Now.AddDays(14);
                book.dueDate = dueDate.ToString();

                _bookRepo.UpdateBook(book);

                Console.WriteLine($"I have checked out this book for you - please return it in two weeks on {book.dueDate}");
            }
        }

        public void createNewMembership()
        {
            throw new NotImplementedException();
        }

        public void cancelMembership()
        {
            throw new NotImplementedException();
        }

        public void calculateFees()
        {
            throw new NotImplementedException();
        }

        public void trackBookStatus()
        {
            throw new NotImplementedException();
        }


    }
}



// this will have a list of book
// this will have an instance of book
// this will have our methods