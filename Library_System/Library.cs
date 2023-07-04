using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_System
{
    public class Library
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Books { get; set; }
        public List<Member> Members { get; set; }

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
        }
        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void AddMember(Member member)
        {
            Members.Add(member);
        }
        public void PrintLibraryDetails()
        {
            Console.WriteLine("Library Details: ");
            Console.WriteLine("Name: "+ Name);
            Console.WriteLine("Address: "+ Address);

            Console.WriteLine("Books: ");
            foreach (var book in Books)
            {
                book.PrintBookDetails();
            }
            Console.WriteLine("Members: ");
            foreach(var member in Members)
            {
                member.PrintMemberDetails();
            }
        }
    }
}
