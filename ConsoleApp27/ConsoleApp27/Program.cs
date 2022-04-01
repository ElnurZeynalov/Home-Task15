using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);
            nums.ForEach(x => Console.WriteLine("\t"+x));
            Console.WriteLine("-------------------");
            nums.Remove(4);
            nums.ForEach(x =>Console.WriteLine("\t"+x));
            Console.WriteLine("-------------------");
            nums.RemoveAt(1);
            nums.ForEach(x => Console.WriteLine("\t" + x));
            Console.WriteLine("-------------------");
            if (nums.Contains(1))
            {
                Console.WriteLine(true);
            }
            int searchednums = nums.BinarySearch(4);
            Console.WriteLine(searchednums);
            int[] nums2 = new int[5];
            nums2[0] = 5;
            nums2[1] = 8;
            nums2[2] = 9;
            nums2[3] = 15;
            Console.WriteLine("-------------------");
            List<int> list = new List<int>(nums2);
            list.ForEach(x => Console.WriteLine("\t"+x));
            Console.WriteLine("-------------------");
            List<Student> student = new List<Student>();
            Student student1 = new Student();
            Student student2 = new Student();

            student1.Name = "Sarvan";
            student1.Age = 6;
            student2.Name = "Ferid";
            student2.Age = 5;
            student.Add(student1);
            student.Add(student2);
            student.ForEach(x => Console.WriteLine(x.Name + " - " + x.Age));
            Console.WriteLine("--------------------");

            Person<string> person = new Person<string>()
            {
                First = "Ehmed",
                Last = "Ehmedov"
            };
            Console.WriteLine(person.First + " " + person.Last);

            Person<int> person1 = new Person<int>()
            {
                First = 50,
                Last = 2500
            };
            Console.WriteLine(person1.First+ " - " + person1.Last);
        }
    }
}
