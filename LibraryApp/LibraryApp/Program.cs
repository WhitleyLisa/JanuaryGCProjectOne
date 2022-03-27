using LibraryApp;
using LibraryApp.BusinessLayer;
using LibraryApp.DataAccessLayer.Repositories;

bool repeat = true;
string error = "I'm sorry, that is not a valid option.";
var librarian = new Librarian();



while (repeat)
{
    Console.WriteLine("\nWelcome to the library! What would you like to do? (Please choose a number below)" +
        "\n 1. View list of books 2. Search books 3. Return a book 4. Exit");
    int userInput;
    bool tryParseBool = int.TryParse(Console.ReadLine(), out userInput);

    if (tryParseBool)
    {
        switch (userInput)
        {
            case 1:
                librarian.getBookList();
                break;

            case 2:
                librarian.BookSearch();
                break;

            case 3:
                Console.WriteLine("Return book stuff");
                break;

            case 4:
                repeat = false;
                break;

            default:
                Console.WriteLine(error);
                break;
        }
    }
    else
        Console.WriteLine(error); 
}