// See https://aka.ms/new-console-template for more information
using Library_System;

Library library = new Library();
library.Name = "My Library";
library.Address = " Baki Tiblisi 59";

Book book1 = new Book();
book1.Title = "The book thief";
book1.Author = "Markus Zusak";
book1.Available = true;

library.AddBook(book1);

Member member = new Member();
member.Name = "Gulbahar";

library.AddMember(member);

member.BorrowBook(book1);

library.PrintLibraryDetails();