using LibraryApp;
using LibraryApp.BusinessLayer;
using LibraryApp.DataAccessLayer.Repositories;

bool repeat = true;
string error = "\nI'm sorry, that is not a valid option.";
var librarian = new Librarian();



while (repeat)
{
    Console.WriteLine("\nWelcome to the library! What would you like to do? (Please choose a number below)" +
        "\n 1. View list of books/Check out a book 2. Search books 3. Return a book 4. Exit");
    int userInput;
    bool tryParseBool = int.TryParse(Console.ReadLine(), out userInput);

    if (tryParseBool)
    {
        switch (userInput)
        {
            case 1:
                var displayMe = librarian.getBookList();
                librarian.DisplayList(displayMe);
                Console.WriteLine("\nWould you like to check out one of these books?(Y/N)");
                var checkOutInput = Console.ReadLine().ToLower();
                if (checkOutInput == "y")
                {
                    //Ensures user input is a valid option
                    Console.WriteLine("\nPlease enter the number of the book you would like to check out:");
                    int checkOutInt;
                    bool checkOutInputParse  = int.TryParse(Console.ReadLine(), out checkOutInt);
                    while (!checkOutInputParse || checkOutInt >= displayMe.Count || checkOutInt <= 0)
                    {
                        Console.WriteLine(error);
                        checkOutInputParse = int.TryParse(Console.ReadLine(), out checkOutInt);
                    }
                    //Uses LINQ to find the book matching the user input, then generates a "list" that only contains that book                    
                    librarian.CheckOutBook(displayMe[checkOutInt-1]);
                }
                break;

            case 2:
                var displaySearchResults = librarian.BookSearch();
                librarian.DisplayList(displaySearchResults);
                break;

            case 3:
                Console.WriteLine("\nReturn book stuff");
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