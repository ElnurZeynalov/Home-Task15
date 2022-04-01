using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Book> FindAllBookByName(string name)
        {
            List<Book> FoundBook = new List<Book>();
            foreach (Book book in Books)
            {
                if(book.Name == name)
                    FoundBook.Add(book);
            }
            return FoundBook;
        }
        public void RemoveAllBookByName(string name)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name == name)
                {
                    Books.RemoveAt(i);
                }
            }
        }
        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            List<Book> FoundByPage = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.PageCount>=min && book.PageCount<=max)
                {
                    FoundByPage.Add(book);
                }
            }
            return FoundByPage;
        }
        public void RemoveByCode(int no)
        {
            if (no>=0 && no< Books.Count)
            {
                for (int i = 0; i < Books.Count; i++)
                {
                    if (Books[i].No ==no)
                    {
                    Books.RemoveAt(i);
                    }
                }
            }
            else
                Console.WriteLine("Bele Bir No Yoxdur");
            
        }
    }
}
