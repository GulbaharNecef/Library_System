using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Member
    {
        public string Name { get; set; }//store membership number of member
        public List<Book> BooksBorrowed { get; set; }//üzvün(yəni kitabxanaya üzv olan şəxsin) kitabxanadan götürdüyü kitabı özundə saxlayan data
        public Member()
        {
            BooksBorrowed = new List<Book>();
        }

        
        public void BorrowBook(Book book)
        {
            if (book.Available)
            {
                BooksBorrowed.Add(book);
                book.BorrowBook();
            }
            else
            {
                Console.WriteLine("Book is not available ");
            }

        }
        public void ReturnBook(Book book)
        {
            if (BooksBorrowed.Contains(book))
            {
                BooksBorrowed.Remove(book);
                book.ReturnBook();
            }
            else
            {
                Console.WriteLine("Book is not borrowed by this member");
            }
        }
        public void PrintMemberDetails()
        {
            Console.WriteLine("Member Details");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("BorrowedBooks: ");
            foreach(var book in BooksBorrowed)
            {
                book.PrintBookDetails();
            }

        }
    }
}
