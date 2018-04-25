using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.show();
            Console.ReadKey();
        }
    }
    public class Person
    {
        public int chen(int k) => k;
        public void show() => Console.WriteLine("chen");
    }
}
