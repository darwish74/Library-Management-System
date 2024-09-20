using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Library
    {
        public List<Book> Books=new List<Book> ();
        public void AddBook(Book book) 
        {
            Books.Add(book);
            Console.WriteLine($"Book '{book.Title}' by {book.Author} added to the library.");
        }
        public string SearchBookByTitle(string Title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Title == Title)
                    return $"Book '{Books[i].Title}' by {Books[i].Author} ISBN {Books[i].ISBN}";
            }
            return $"This Book with {Title} is not found";
        }
        public string BorrowBook(string Title)
        {                                                      
         for(int i = 0;i < Books.Count;i++) 
            {
                if (Books[i].Title == Title && Books[i].Availability)
                {
                    Books[i].Availability = false ;
                    return $"You have borrowed '{Books[i].Title}'.";
                }                
            }  
         return $"This book is not found or already borrowed .";
        }
        public string ReturnBook(string Title)
        {
            for (int i = 0; i <Books.Count; i++)
            {
                if (Books[i].Title == Title && !Books[i].Availability)
                {
                    Books[i].Availability = true;
                    return $"You have returned '{Books[i].Title}'.";
                }
            }
            return $"This book is not borrowed.";
        }

    }
}
