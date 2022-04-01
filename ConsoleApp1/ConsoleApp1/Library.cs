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
                if(book.Name.Contains(name))
                    FoundBook.Add(book);
            }
            return FoundBook;
        }
        public void RemoveAllBookByName(string name)
        {
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Name.Contains(name))
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
                    if (Books[i].No == no)
                    {
                    Books.RemoveAt(i);
                    }
                }
            }
            else
                Console.WriteLine("Bele Bir No Yoxdur");
            
        }
        public List<Book> SearchBooks(string str)
        {
            List <Book> FoundBook = new List<Book>();
            foreach (Book book in Books)
            {
                string PageCount =Convert.ToString(book.PageCount);
                if (book.Name.Contains(str) || book.AuthorName.Contains(str) || PageCount == str)
                {
                    FoundBook.Add(book);
                }
            }
            return FoundBook;
        }
    }
}
