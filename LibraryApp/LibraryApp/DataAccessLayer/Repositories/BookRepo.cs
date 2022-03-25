using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.DataAccessLayer.Repositories
{
    public class BookRepo
    {
        private List<Book> BookList { get; set; } = new List<Book> { Book };

        public Book DisplayBooks()
        {
            string executableLocation = AppDomain.CurrentDomain.BaseDirectory;

            string[] files = Directory.GetFiles(executableLocation + @"\Database\BookTable\", "*.json", SearchOption.TopDirectoryOnly);
        }
    }
}
