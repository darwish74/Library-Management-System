using System;
namespace Library_Management_System
{
    internal class Book
    {
         public string title;
         public string author;
         public string isbn;
         public bool availability;

        public Book(string title, string author, string isbn)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            availability = true;
        }
    }                  
}
