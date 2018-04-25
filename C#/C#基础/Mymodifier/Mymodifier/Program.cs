using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mymodifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(3);
            Console.WriteLine(person.i);
            Console.ReadKey();
        }
    }
    class Person
    {
        public const double PI = 3.1415;
        public readonly int i;
        public Person(int i)
        {
            this.i = i;
        }
    }
    abstract class boy
    {
        public abstract int chen { get; set; }
    }
}
