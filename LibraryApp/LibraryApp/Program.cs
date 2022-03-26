using LibraryApp;
using LibraryApp.DataAccessLayer.Repositories;

var bookRepo = new BookRepo();
var testList = bookRepo.GetBooks();

foreach(Book book in testList)
{
    Console.WriteLine($"{book.isbn}. {book.title}, by {book.author}");
}
