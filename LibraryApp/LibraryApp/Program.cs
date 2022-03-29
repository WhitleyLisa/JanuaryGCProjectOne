using LibraryApp;
using LibraryApp.BusinessLayer;
using LibraryApp.DataAccessLayer.Repositories;

bool repeat = true;
string error = "\nI'm sorry, that is not a valid option.";
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
                    //Adjusts user input to match index of the book they chose, then checks the book out
                    librarian.CheckOutBook(displayMe[checkOutInt-1]);
                }
                break;

            case 2:
                var displaySearchResults = librarian.BookSearch();
                librarian.DisplayList(displaySearchResults);
                string searchResultCheckout;
                //If there's only one search result, why have them input a number to choose the book? This is better
                if (displaySearchResults.Count == 1)
                {
                    Console.WriteLine("\nWould you like to check out this book?(Y/N)");
                    searchResultCheckout = Console.ReadLine().ToLower();
                    if (searchResultCheckout == "y")
                        librarian.CheckOutBook(displaySearchResults[0]);
                }
                else
                {
                    //If there are multiple results, we'll treat this similar to the full display list
                    Console.WriteLine("\nWould you like to check out one of these books?(Y/N)");
                    var searchResultsCheckOut = Console.ReadLine().ToLower();
                    if(searchResultsCheckOut == "y")
                    {
                        //Ensures user input is valid
                        Console.WriteLine("\nPlease enter the number of the book you would like to check out:");
                        int searchCheckOutInt;
                        bool searchCheckOutInputParse = int.TryParse(Console.ReadLine(), out searchCheckOutInt);
                        while (!searchCheckOutInputParse || searchCheckOutInt >= displaySearchResults.Count || searchCheckOutInt <= 0)
                        {
                            Console.WriteLine(error);
                            searchCheckOutInputParse = int.TryParse(Console.ReadLine(), out searchCheckOutInt);
                        }
                        //Adjusts user input to match index of the book they chose, then checks the book out
                        librarian.CheckOutBook(displaySearchResults[searchCheckOutInt - 1]);
                    }
                }
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