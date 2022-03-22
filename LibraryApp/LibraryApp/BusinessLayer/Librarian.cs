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

        public Librarian (List<Book> listOfBooks, Member member)
        {
            this.BookList = listOfBooks;
            this.Member = member;
        }

        public void getBookList()
        {

        }


    }
}



// this will have a list of book
// this will have an instance of book
// this will have our methods