using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccessLayer.Repositories
{
    public class BookRepo
    {
        //private List<Book> Cache { get; set; } = new List<Book> { };

        public List<Book> GetBooks()
        {
            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;

            
            string[] files = Directory.GetFiles(executableLocation + @"\Database\BookTable\", "*.json", SearchOption.TopDirectoryOnly);
            //string[] files = Directory.GetFiles(@"~\desktop\midtermrepo\")

            var books = new List<Book>();

            //Iterate through the files and deserialize them
            foreach (var f in files)
            {
                var b = JsonConvert.DeserializeObject <List<Book>>(File.ReadAllText(f));

                if(b != null)
                {
                    //AddToCache(b);
                    books.AddRange(b);
                }
            }

            books = books.OrderBy(x => x.id).ToList();

            return books;

        }

        public List<Book> GetByAuthor(string author)
        {
            /// get all books
            var book = GetBooks();
            /// filter book by author
            return book.Where(x => x.author.ToLower() == author.ToLower()).ToList();
        }

        public List<Book> GetByTitleKeyword(string keyword)
        {
            /// get books
            var book = GetBooks();
            /// filter by keyword
            return book.Where(x => x.title.ToLower().Contains(keyword.ToLower())).ToList();
        }

        //public string DisplayBooks(List<Book>)
        //{
        //    foreach

        //}

        //private void AddToCache(Book book)
        //{
        //    //Any is a boolean. It checks if if one or more objects fit this criteria
        //    if (!Cache.Any(x => x.isbn == book.isbn))
        //    {
        //        Cache.Add(book);
        //    }
        //}

    }
}
