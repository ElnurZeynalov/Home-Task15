using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Book
    {
        private int _no;
        public int No { get => _no; }
        public string Name { get; set; }
        public string  AuthorName { get; set; }
        public int PageCount { get; set; }
        public Book()
        {
            _no++;
        }
    }
}
