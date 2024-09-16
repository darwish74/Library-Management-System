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
            Console.WriteLine($"Book '{book.title}' by {book.author} added to the library.");
        }
        public string SearchBookByTitle(string title)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].title == title)
                    return $"Book '{Books[i].title}' by {Books[i].author} ISBN {Books[i].isbn}";
            }
            return $"This Book with {title} is not found";
        }
        public string BorrowBook(string title)
        {                                                      
         for(int i = 0;i < Books.Count;i++) 
            {
                if (Books[i].title == title && Books[i].availability)
                {
                    Books[i].availability = false ;
                    return $"You have borrowed '{Books[i].title}'.";
                }                
            }  
         return $"This book is not found or already borrowed .";
        }
        public string ReturnBook(string title)
        {
            for (int i = 0; i <Books.Count; i++)
            {
                if (Books[i].title == title && !Books[i].availability)
                {
                    Books[i].availability = true;
                    return $"You have returned '{Books[i].title}'.";
                }
            }
            return $"This book is not borrowed.";
        }

    }
}
