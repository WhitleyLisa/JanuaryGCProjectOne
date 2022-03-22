using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        string author { get; set; }
        string title { get; set; }  
        string genre { get; set; }  
        bool status { get; set; }
        DateTime checkedOutDate { get; set; }   
        DateTime dueDate { get; set; }  

    }
}
