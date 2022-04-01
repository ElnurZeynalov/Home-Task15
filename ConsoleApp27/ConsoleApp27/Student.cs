using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp27
{
    internal class Student
    {
       public int Age { get; set; }
       public string Name { get; set; }
    }
    internal class Person<T>
    {
        public T First { get; set; }
        public T Last { get; set; }
    }
}
