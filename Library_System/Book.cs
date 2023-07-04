using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; }
        public void BorrowBook()//kitabxanadan kitab goturulende ise dusecek
        {
            Available = false;
        }
        public void ReturnBook()//kitab qaytarilanda ise dusecek
        {
            Available = true;
        }
        public void PrintBookDetails()//kitabin datalarin cap edir
        { 
            Console.WriteLine("Title: "+Title);
            Console.WriteLine("Author: "+Author);
            Console.WriteLine("Available: "+Available);
            Console.WriteLine();
        }

    }
}
