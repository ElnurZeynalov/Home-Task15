using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========All==========");
            Book book = new Book();
            book.Name = "Ali";
            book.AuthorName = "Veli";
            book.PageCount = 50;
            Book book1 = new Book();
            book1.Name = "Huqo";
            book1.AuthorName = "Vuqo";
            book1.PageCount = 250;
            Book book2 = new Book();
            book2.Name = "Huqo";
            book2.AuthorName = "Suqo";
            book2.PageCount = 150;
            Book book3 = new Book();
            book3.Name = "Veli";
            book3.AuthorName = "Ali";
            book3.PageCount = 100;
            Library library = new Library();
            library.Books.Add(book);
            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name + "\n" + item.AuthorName);
            }
            Console.WriteLine("\n============FindAllBookByName============\n");
            foreach (var item in library.FindAllBookByName("Huqo"))
            {
                Console.WriteLine(item.Name+"\n"+item.AuthorName);
            }
            Console.WriteLine("\n===========RemoveAllBookByName==========\n");
            library.RemoveAllBookByName("Ali");
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name + "\n" + item.AuthorName);
            }
            Console.WriteLine("\n==========FindAllBooksByPageCountRange===========\n");
            foreach (var item in library.FindAllBooksByPageCountRange(100,300))
            {
                Console.WriteLine(item.Name + "\n" + item.AuthorName + "\n" + item.PageCount);
            }
            Console.WriteLine("\n==========RemoveBookByCode===========\n");
            library.RemoveByCode(0);
            foreach (var item in library.Books)
            {
                Console.WriteLine(item.Name + "\n" + item.AuthorName);
            }
        }
    }
}
