using System;
namespace Library_Management_System
{
    internal class Book
    {
         public string Title {get;set;}
         public string Author { get;set;}   
         public string ISBN { get;set;} 
         public bool Availability { get;set;}   

        public Book(string title, string author, string isbn)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            Availability = true;
        }
    }                  
}
