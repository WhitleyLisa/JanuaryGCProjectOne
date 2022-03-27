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