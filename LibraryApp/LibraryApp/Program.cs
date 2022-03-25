using LibraryApp;
using LibraryApp.DataAccessLayer.Repositories;

var bookRepo = new BookRepo();
var testList = bookRepo.GetBooks();


Console.WriteLine(testList);