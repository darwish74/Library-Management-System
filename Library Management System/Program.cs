namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library=new Library();
            library.AddBook(new Book("C#","Darwish","123456789"));
            library.AddBook(new Book("SQL","Mohamed","111213141"));
            library.AddBook(new Book("OOP","Ahmed","123456789"));
            Console.WriteLine(library.BorrowBook("C#"));
            Console.WriteLine(library.BorrowBook("C#"));
            Console.WriteLine(library.ReturnBook("C#"));
            Console.WriteLine(library.BorrowBook("C#"));

        }
    }
}
